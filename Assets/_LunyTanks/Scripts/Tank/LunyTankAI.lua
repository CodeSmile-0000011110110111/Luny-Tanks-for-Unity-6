local script = {...}

-- Possible state of the Computer controlled tank : either seeking itsd target or fleeing from it
local State =
{
    Seek = function() script.SeekUpdate() end,
    Flee = function() script.FleeUpdate() end,
}

local m_Movement = nil                -- Reference to the movement script
local m_Shooting = nil                -- Reference to the shooting script

local m_PathfindTime = 0.5            -- Only trigger a pathfind after this time, to not degrade performance
local m_PathfindTimer = 0.0           -- The time until the next pathfind call

local m_CurrentTarget = nil       -- Which Transform the tank is following
local m_MaxShootingDistance = 0.0     -- Store the max shooting distance based on TankShooting settings

local m_TimeBetweenShot = 2.0         -- The AI Tank have a cooldown on shot to avoid spamming shot
local m_ShotCooldown = 0.0            -- The remaining time until the next shot

local m_LastTargetPosition = vector3.New()           -- The position of the target last frame
local m_TimeSinceLastTargetMove = 0        -- Timer counting how long the target hasn't moved. This is used to trigger the flee state

local m_CurrentPath = nil       -- The current path followed by the tank.
local m_CurrentCorner = 0                -- Which corner of the path the tank is currently going forward to
local m_IsMoving = false                -- Is the tank currently moving or not (the tank stop to shoot)

local m_AllTanks = nil                -- List of all the tanks in the scene.

local m_CurrentState = State.Seek      -- The current AI state the Tank is in.

local gameObject = nil
local transform = nil

function script.Awake()
    gameObject = script.gameObject
    transform = script.transform

    -- Awake is still called on disabled component. So that the user can test disabling AI on a single tank
    -- we ensure that the component wasn't disabled before initializing everything
    if not script.component.isActiveAndEnabled then
        return
    end

    m_Movement = gameObject:GetComponent(lunytankmovement).script
    m_Shooting = gameObject:GetComponent(lunytankshooting).script

    -- ensure that both movement and shooting script are set in "computer controlled" mode
    m_Movement.IsComputerControlled = true
    m_Shooting.IsComputerControlled = true

    -- to avoid all computer controlled tank pathfinding together (and taxing the CPU), AI tank have a random
    -- pathfinding time that will stagger them across multiple frame
    m_PathfindTime = random.Range(0.3, 0.6)

    -- Compute and store what is the maximum distance a shot from this tank can reach. This will be used when deciding when
    -- to start charging and when to release a shot
    m_MaxShootingDistance = vector3.Distance(m_Shooting.GetProjectilePosition(1.0), transform.position)

    -- We use FindObjectByType to get all Tanks, to not depend on GameManager so user can try adding AI in an
    -- empty scene where no GameManager was added yet.
    m_AllTanks = gameobject.FindObjectsByType(lunytankmovement)

    -- we get LunyTankMovement types returned but we want to store the GameObject instance instead
    for i, tank in ipairs(m_AllTanks) do
        m_AllTanks[i] = tank.gameObject
    end
end

-- If a GameManager exist, it will call this function after creating a computer controlled tank. This just replace
-- the list of tanks with the one from the GameManager
function script.Setup(manager)
    -- If this was using manager.m_SpawnPoints.ToArray(), it will get an array of TankManager, but m_AllTanks is an array of Transform.
    -- The Select function will call the function passed as a parameter on each entry in the list (here TankManager) and make a new list
    -- containing what each return. The function we pass here, e => e.m_Instance, return the Transform of the tank the TankManager manage
    -- so effectively manager.m_SpawnPoints.Select(e => e.m_Instance) give a list of all the tanks transform.

    m_AllTanks = {}
    for i, tank in ipairs(manager.SpawnPoints) do
        m_AllTanks[i] = tank.Instance
    end
end

function script.TurnOff()
    script.component.enabled = false
end

function script.Update()
    -- If there is a cooldown active, we decrement it by the time elapsed since last frame
    if m_ShotCooldown > 0 then
        m_ShotCooldown = m_ShotCooldown - time.deltaTime
    end

    -- increment the time since last pathfind. The SeekUpdate will check if it goes over the pathfinding time
    -- and if it need to trigger a new pathfinding
    m_PathfindTimer = m_PathfindTimer + time.deltaTime

    m_CurrentState() -- run the Update function assigned to m_CurrentState
end

function script.SeekUpdate()
     -- To lighten the load on the CPU the tanks do not pathfind to their target every single frame. Instead, they
     -- wait a bit between each pathfind. They will go toward an "outdated" position in between, but as the pathfind time is
     -- under 1s, this is visually not noticeable and a lot more efficient than trying to pathfinding 30+ time each second
     if m_PathfindTimer > m_PathfindTime then
         -- reset the time since last pathfind
         m_PathfindTimer = 0

         -- This will store each path toward each tank in the scene
         local paths = {}

         -- Initialize the shorted path length to the max value a float can have, so no matter what is the length
         -- of the first found path, it will for sure be shortest than this initial value
         local shortestPath = 3.40282347E+38
         -- which of the path in the paths array we use. By default none, which is represented by -1 here.
         local usedPath = -1
         local target = nil

         -- Calculate a path to every tank and check the closest
         for i, tank in ipairs(m_AllTanks) do
             -- hotfix
             if not tank then
                 goto continue
             end

             --we don't want the tank to try to target itself, so ignore itself
             if tank == gameObject then
                 goto continue
             end

             -- this is a destroyed or deactivated tank, this is not a valid target
             if tank == nil or not tank.activeInHierarchy then
                 goto continue
             end

             print("FIXME: NavMeshPath")
             paths[i] = new NavMeshPath()

             -- this return true if a path was found
             if navmesh.CalculatePath(transform.position, tank.transform.position, bit32.bnot(0), paths[i]) then
                 -- Compute how long the path is...
                 local length = script.GetPathLength(paths[i])
                 -- And if it's the shortest path so far, this is the one we want to go after
                 if shortestPath > length then
                     -- so this path become the used path
                     usedPath = i
                     --and its length is now the shortest length to beat
                     shortestPath = length
                     target = tank.transform
                 end
             end

             ::continue::
         end

         -- usedPath will still be -1 if the tank could not find a path to any tank, otherwise we have a target
         if usedPath ~= -1 then
             -- we switched target. The last tank we were seeking got farther away than another tank, this new
             -- tank become our new target, and we reset the last position as this is now a new target
             if target ~= m_CurrentTarget then
                 m_CurrentTarget = target
                 m_LastTargetPosition = m_CurrentTarget.position
             end

             m_CurrentTarget = target
             m_CurrentPath = paths[usedPath]
             m_CurrentCorner = 1
             m_IsMoving = true
         end
     end

     -- The pathfinding is now either finished or wasn't triggered this frame as it was done recently enough
     -- The SeekUpdate now seek and try to shot at the target it have

     -- This tank have a target...
     if m_CurrentTarget then
         -- check how far our target moved since last update
         local targetMovement = vector3.Distance(m_CurrentTarget.position, m_LastTargetPosition)

         --the target didn't (or barely) moved...
         if targetMovement < 0.0001 then
             -- so we increment the timer. This is used later, if a target we're shooting at haven't moved in 2s, we flee
             m_TimeSinceLastTargetMove = m_TimeSinceLastTargetMove + time.deltaTime
         else
             --the target did move since last time, so we reset the timer since last move to 0.
             m_TimeSinceLastTargetMove = 0
         end

         -- the current position become the last position that will be used next frame to test if the target moved
         m_LastTargetPosition = m_CurrentTarget.position

         -- Get a vector from this tank to its target
         local toTarget = m_CurrentTarget.position - transform.position
         -- by setting y to 0, we ensure that the vector to the target is in the flat plane of the ground
         toTarget.y = 0

         local targetDistance = toTarget.magnitude
         -- normalize the vector to the target, setting its length to 1, which is useful for some mathematical operations.
         toTarget.Normalize()

         -- the dot product between 2 normalized vector is the cosine of the angle between those vector. This is useful as it
         -- allow to test how aligned those vector are : 1 -> in the same direction, 0 -> 90 deg angle, -1, pointing in opposite direction.
         -- As we compute the dot product between our forward vector and the vector toward our target, this give use how much we are
         -- facing our target : if this is close to 1, we are facing straight at our target.
         local dotToTarget = vector3.Dot(toTarget, transform.forward)

         --if we are charging, check if the current shot can reach the target
         if m_Shooting.IsCharging then
             -- get the estimated point of the projectile with the current charging value
             local currentShotTarget = m_Shooting.GetProjectilePosition(m_Shooting.CurrentChargeRatio)
             -- the distance from us to that estimated point
             local currentShotDistance = vector3.Distance(currentShotTarget, transform.position)

             --if we are facing the target and our shot is charged enough to reach the target, release the shot
             -- note : we remove 2 from the target distance as our shot have splash damage, so we can release the
             -- shot earlier
             if currentShotDistance >= targetDistance - 2 and dotToTarget > 0.99 then
                 m_IsMoving = false
                 m_Shooting.StopCharging()

                 -- we just shot, so we set the cooldown to the time between shot (this is decremented each frame in the update function)
                 m_ShotCooldown = m_TimeBetweenShot

                 -- We just shot, and our target haven't moved for a while. Which mean they are probably also aiming and shooting at us
                 -- we go into fleeing mode instead of staying there as a static target
                 if m_TimeSinceLastTargetMove > 2.0 then
                     script.StartFleeing()
                 end
             end
         else
             -- We aren't charging yet, so check if the target is closer than our max shooting distance, which mean we can start charging the shot
             -- (a "smarter" solution would be to compute how early we can charge so we reach max distance already max charged)
             if targetDistance < m_MaxShootingDistance then
                 -- This use the navmesh to check if there are any obstacle between us and the target. If this return false
                 -- this mean there is no unobstructed path, so there *is* an obstacle, so we shouldn't start shooting yet
                 local hit = nil
                 if not navmesh.Raycast(transform.position, m_CurrentTarget.position, hit, bit32.bnot(0)) then
                     -- we stop moving as we can reach our target with our shot
                     m_IsMoving = false

                     -- if our cooldown is not 0 or below, we have to wait for it to be before shooting. If it is
                     -- below 0, we start charging
                     if m_ShotCooldown <= 0.0 then
                         m_Shooting.StartCharging()
                     end
                 end
             end
         end
     end
 end


function script.FleeUpdate()
    -- When fleeing the tank will go toward a random point away from its target. When we reach the last corners
    -- (i.e. point) of that path, we can go back to seek mode
    if m_CurrentCorner >= m_CurrentPath.corners.Length then
        m_CurrentState = State.Seek
    end
end

function script.StartFleeing()
    -- To flee, we need to pick a point away from our current target

    -- Start by getting the vector *toward* our target...
    local toTarget = (m_CurrentTarget.position - transform.position).normalized

    -- then rotate that vector of a random angle between 90 and 180 degree, which will give us a random direction
    -- in the opposite direction
    toTarget = quaternion.AngleAxis(random.Range(90, 180) * mathf.Sign(random.Range(-1, 1)), vector3.up) * toTarget

    -- then we pick a point in that random direction at a random distance between 5 and 20 units
    toTarget = toTarget * random.Range(5, 20)

    -- Finally we compute a path toward that random point, which become our new current path.
    if navmesh.CalculatePath(transform.position, transform.position + toTarget, navmesh.AllAreas, m_CurrentPath) then
        m_CurrentState = State.Flee
        m_CurrentCorner = 1

        m_IsMoving = true
    end
end

 -- Contrary to Update (which is called every new frame, so called a variable amount of time per second depending
 -- if the game is rendering fast or not), FixedUpdate is called at a given interval define in the Physic Setting
 -- of the project. This is where all physic code should be placed.
 function script.FixedUpdate()
     -- If the tank doesn't have a path currently, exit early.
     if not m_CurrentPath or #m_CurrentPath.corners == 0 then
         return
     end

     local rb = m_Movement.Rigidbody

     --The point we will orient toward. By default, the current corner in our path
     local orientTarget = m_CurrentPath.corners[mathf.Min(m_CurrentCorner, #m_CurrentPath.corners - 1)]

     --if we are not moving, we orient toward our target instead
     if not m_IsMoving then
         orientTarget = m_CurrentTarget.position
     end

     local toOrientTarget = orientTarget - transform.position
     toOrientTarget.y = 0
     toOrientTarget.Normalize()

     local forward = rb.rotation * Vector3.forward

     local orientDot = vector3.Dot(forward, toOrientTarget)
     local rotatingAngle = vector3.SignedAngle(toOrientTarget, forward, vector3.up)

     --if we are moving we move in our forward direction by our max speed
     local moveAmount = mathf.Clamp01(orientDot) * m_Movement.m_Speed * time.deltaTime
     if m_IsMoving and moveAmount > 0.000001 then
         rb.MovePosition(rb.position + forward * moveAmount)
     end

     --the actual rotation for that frame is the smallest between the max turning speed for that time frame and the
     --angle itself. Multiplied by the sign of the angle to ensure we rotate in the right direction
     rotatingAngle = mathf.Sign(rotatingAngle) * mathf.Min(mathf.Abs(rotatingAngle), m_Movement.m_TurnSpeed * time.deltaTime)

     if mathf.Abs(rotatingAngle) > 0.000001 then
         rb.MoveRotation(rb.rotation * quaternion.AngleAxis(-rotatingAngle, vector3.up))
     end

     -- If we reached our current target, we increase our corner. We will never reach the target when the target
     -- is another tank as we stop before.
     if vector3.Distance(rb.position, orientTarget) < 0.5 then
         m_CurrentCorner = m_CurrentCorner + 1
     end
 end

 -- Utility function which will add the length of all the sections of the given path to get its effective length
function script.GetPathLength(path)
     local dist = 0
     for i = 2, #path.corners do
         dist = dist + vector3.Distance(path.corners[i-1], path.corners[i])
     end

     return dist
end

return script
