local script = {...}

-- Possible state of the Computer controlled tank : either seeking itsd target or fleeing from it
local State =
{
    Seek = script.SeekUpdate,
    Flee = script.FleeUpdate,
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
    print("AI Awake")
    -- Awake is still called on disabled component. So that the user can test disabling AI on a single tank
    -- we ensure that the component wasn't disabled before initializing everything
    if not script.component.isActiveAndEnabled then
        return
    end

    gameObject = script.gameObject
    transform = script.transform

    m_Movement = gameObject:GetComponent(lunytankmovement).script
    m_Shooting = gameObject:GetComponent(lunytankshooting).script
    print("AI components", m_Movement, m_Shooting)

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
    print("AI: need to convert LINQ statement")
    --m_AllTanks = gameObject.FindObjectsByType(lunytankmovement, FindObjectsInactive.Exclude, FindObjectsSortMode.None).
    --    Select(e => e.gameObject).ToArray()
end

-- If a GameManager exist, it will call this function after creating a computer controlled tank. This just replace
-- the list of tanks with the one from the GameManager
function script.Setup(manager)
    -- If this was using manager.m_SpawnPoints.ToArray(), it will get an array of TankManager, but m_AllTanks is an array of Transform.
    -- The Select function will call the function passed as a parameter on each entry in the list (here TankManager) and make a new list
    -- containing what each return. The function we pass here, e => e.m_Instance, return the Transform of the tank the TankManager manage
    -- so effectively manager.m_SpawnPoints.Select(e => e.m_Instance) give a list of all the tanks transform.

    print("AI: LINQ in Setup")
    --m_AllTanks = manager.m_SpawnPoints.Select(e => e.m_Instance).ToArray()
end

function script.TurnOff()
    script.component.enabled = false
end

 --function script.Update()
 --    -- If there is a cooldown active, we decrement it by the time elapsed since last frame
 --    if m_ShotCooldown > 0 then
 --        m_ShotCooldown = m_ShotCooldown - time.deltaTime
 --    end
 --
 --    -- increment the time since last pathfind. The SeekUpdate will check if it goes over the pathfinding time
 --    -- and if it need to trigger a new pathfinding
 --    m_PathfindTimer = m_PathfindTimer + Time.deltaTime
 --
 --    switch (m_CurrentState)
 --    {
 --        case State.Seek:
 --            SeekUpdate()
 --            break
 --        case State.Flee:
 --            FleeUpdate()
 --            break
 --    }
 --}
 --
local dummy1 = nil
 --void SeekUpdate()
 --{
 --    -- To lighten the load on the CPU the tanks do not pathfind to their target every single frame. Instead, they
 --    -- wait a bit between each pathfind. They will go toward an "outdated" position in between, but as the pathfind time is
 --    -- under 1s, this is visually not noticeable and a lot more efficient than trying to pathfinding 30+ time each second
 --    if (m_PathfindTimer > m_PathfindTime)
 --    {
 --        -- reset the time since last pathfind
 --        m_PathfindTimer = 0
 --
 --        -- This will store each path toward each tank in the scene
 --        NavMeshPath[] paths = new NavMeshPath[m_AllTanks.Length]
 --
 --        -- Initialize the shorted path length to the max value a float can have, so no matter what is the length
 --        -- of the first found path, it will for sure be shortest than this initial value
 --        float shortestPath = float.MaxValue
 --        -- which of the path in the paths array we use. By default none, which is represented by -1 here.
 --        int usedPath = -1
 --        Transform target = null
 --
 --        -- Calculate a path to every tank and check the closest
 --        for (var i = 0 i < m_AllTanks.Length i++)
 --        {
 --            -- hotfix
 --            var tankMove = m_AllTanks[i]
 --            if (tankMove == null)
 --            {
 --                continue
 --            }
 --
 --            var tank = m_AllTanks[i].gameObject
 --
 --            --we don't want the tank to try to target itself, so ignore itself
 --            if (tank == gameObject)
 --                continue
 --
 --            -- this is a destroyed or deactivated tank, this is not a valid target
 --            if(tank == null || !tank.activeInHierarchy)
 --                continue
 --
 --            paths[i] = new NavMeshPath()
 --
 --            -- this return true if a path was found
 --            if (NavMesh.CalculatePath(transform.position, tank.transform.position, ~0, paths[i]))
 --            {
 --                -- Compute how long the path is...
 --                float length = GetPathLength(paths[i])
 --                -- And if it's the shortest path so far, this is the one we want to go after
 --                if (shortestPath > length)
 --                {
 --                    -- so this path become the used path
 --                    usedPath = i
 --                    --and its length is now the shortest length to beat
 --                    shortestPath = length
 --                    target = tank.transform
 --                }
 --            }
 --        }
 --
local dummy2 = nil
 --        -- usedPath will still be -1 if the tank could not find a path to any tank, otherwise we have a target
 --        if (usedPath != -1)
 --        {
 --            -- we switched target. The last tank we were seeking got farther away than another tank, this new
 --            -- tank become our new target, and we reset the last position as this is now a new target
 --            if (target != m_CurrentTarget)
 --            {
 --                m_CurrentTarget = target
 --                m_LastTargetPosition = m_CurrentTarget.position
 --            }
 --
 --            m_CurrentTarget = target
 --            m_CurrentPath = paths[usedPath]
 --            m_CurrentCorner = 1
 --            m_IsMoving = true
 --        }
 --
 --
 --    }
 --    -- The pathfinding is now either finished or wasn't triggered this frame as it was done recently enough
 --    -- The SeekUpdate now seek and try to shot at the target it have
 --
local dummy3 = nil

 --    -- This tank have a target...
 --    if (m_CurrentTarget != null)
 --    {
 --        -- check how far our target moved since last update
 --        float targetMovement = Vector3.Distance(m_CurrentTarget.position, m_LastTargetPosition)
 --
 --        --the target didn't (or barely) moved...
 --        if (targetMovement < 0.0001f)
 --        {
 --            -- so we increment the timer. This is used later, if a target we're shooting at haven't moved in 2s, we flee
 --            m_TimeSinceLastTargetMove += Time.deltaTime
 --        }
 --        else
 --        {
 --            --the target did move since last time, so we reset the timer since last move to 0.
 --            m_TimeSinceLastTargetMove = 0
 --        }
 --
 --        -- the current position become the last position that will be used next frame to test if the target moved
 --        m_LastTargetPosition = m_CurrentTarget.position
 --
 --        -- Get a vector from this tank to its target
 --        Vector3 toTarget = m_CurrentTarget.position - transform.position
 --        -- by setting y to 0, we ensure that the vector to the target is in the flat plane of the ground
 --        toTarget.y = 0
 --
 --        float targetDistance = toTarget.magnitude
 --        -- normalize the vector to the target, setting its length to 1, which is useful for some mathematical operations.
 --        toTarget.Normalize()
 --
 --        -- the dot product between 2 normalized vector is the cosine of the angle between those vector. This is useful as it
 --        -- allow to test how aligned those vector are : 1 -> in the same direction, 0 -> 90 deg angle, -1, pointing in opposite direction.
 --        -- As we compute the dot product between our forward vector and the vector toward our target, this give use how much we are
 --        -- facing our target : if this is close to 1, we are facing straight at our target.
 --        float dotToTarget = Vector3.Dot(toTarget, transform.forward)
 --
local dummy4 = nil

 --        --if we are charging, check if the current shot can reach the target
 --        if (m_Shooting.IsCharging)
 --        {
 --            -- get the estimated point of the projectile with the current charging value
 --            Vector3 currentShotTarget = m_Shooting.GetProjectilePosition(m_Shooting.CurrentChargeRatio)
 --            -- the distance from us to that estimated point
 --            float currentShotDistance = Vector3.Distance(currentShotTarget, transform.position)
 --
 --            --if we are facing the target and our shot is charged enough to reach the target, release the shot
 --            -- note : we remove 2 from the target distance as our shot have splash damage, so we can release the
 --            -- shot earlier
 --            if (currentShotDistance >= targetDistance - 2 && dotToTarget > 0.99f)
 --            {
 --                m_IsMoving = false
 --                m_Shooting.StopCharging()
 --
 --                -- we just shot, so we set the cooldown to the time between shot (this is decremented each frame in the update function)
 --                m_ShotCooldown = m_TimeBetweenShot
 --
 --                -- We just shot, and our target haven't moved for a while. Which mean they are probably also aiming and shooting at us
 --                -- we go into fleeing mode instead of staying there as a static target
 --                if (m_TimeSinceLastTargetMove > 2.0f)
 --                {
 --                    StartFleeing()
 --                }
 --            }
 --        }
local dummy5 = nil

 --        else
 --        {
 --            -- We aren't charging yet, so check if the target is closer than our max shooting distance, which mean we can start charging the shot
 --            -- (a "smarter" solution would be to compute how early we can charge so we reach max distance already max charged)
 --            if (targetDistance < m_MaxShootingDistance)
 --            {
 --                -- This use the navmesh to check if there are any obstacle between us and the target. If this return false
 --                -- this mean there is no unobstructed path, so there *is* an obstacle, so we shouldn't start shooting yet
 --                if (!NavMesh.Raycast(transform.position, m_CurrentTarget.position, out var hit, ~0))
 --                {
 --                    -- we stop moving as we can reach our target with our shot
 --                    m_IsMoving = false
 --
 --                    -- if our cooldown is not 0 or below, we have to wait for it to be before shooting. If it is
 --                    -- below 0, we start charging
 --                    if (m_ShotCooldown <= 0.0f)
 --                    {
 --                        m_Shooting.StartCharging()
 --                    }
 --                }
 --            }
 --        }
 --    }
 --}
 --
local dummy6 = nil

 --function script.FleeUpdate()
 --{
 --    -- When fleeing the tank will go toward a random point away from its target. When we reach the last corners
 --    -- (i.e. point) of that path, we can go back to seek mode
 --    if(m_CurrentCorner >= m_CurrentPath.corners.Length)
 --        m_CurrentState = State.Seek
 --}
 --
 --function script.StartFleeing()
 --{
 --    -- To flee, we need to pick a point away from our current target
 --
 --    -- Start by getting the vector *toward* our target...
 --    var toTarget = (m_CurrentTarget.position - transform.position).normalized
 --
 --    -- then rotate that vector of a random angle between 90 and 180 degree, which will give us a random direction
 --    -- in the opposite direction
 --    toTarget = Quaternion.AngleAxis(Random.Range(90.0f, 180.0f) * Mathf.Sign(Random.Range(-1.0f, 1.0f)),
 --        Vector3.up) * toTarget
 --
 --    -- then we pick a point in that random direction at a random distance between 5 and 20 units
 --    toTarget *= Random.Range(5.0f, 20.0f)
 --
 --    -- Finally we compute a path toward that random point, which become our new current path.
 --    if (NavMesh.CalculatePath(transform.position, transform.position + toTarget, NavMesh.AllAreas,
 --            m_CurrentPath))
 --    {
 --        m_CurrentState = State.Flee
 --        m_CurrentCorner = 1
 --
 --        m_IsMoving = true
 --    }
 --}
 --
local dummy7 = nil

 ---- Contrary to Update (which is called every new frame, so called a variable amount of time per second depending
 ---- if the game is rendering fast or not), FixedUpdate is called at a given interval define in the Physic Setting
 ---- of the project. This is where all physic code should be placed.
 --function script.FixedUpdate()
 --{
 --    -- If the tank doesn't have a path currently, exit early.
 --    if(m_CurrentPath == null || m_CurrentPath.corners.Length == 0)
 --        return
 --
 --    var rb = m_Movement.Rigidbody
 --
 --    --The point we will orient toward. By default, the current corner in our path
 --    Vector3 orientTarget = m_CurrentPath.corners[Mathf.Min(m_CurrentCorner, m_CurrentPath.corners.Length - 1)]
 --
 --    --if we are not moving, we orient toward our target instead
 --    if (!m_IsMoving)
 --        orientTarget = m_CurrentTarget.position
 --
 --    Vector3 toOrientTarget = orientTarget - transform.position
 --    toOrientTarget.y = 0
 --    toOrientTarget.Normalize()
 --
 --    Vector3 forward = rb.rotation * Vector3.forward
 --
 --    float orientDot = Vector3.Dot(forward, toOrientTarget)
 --    float rotatingAngle = Vector3.SignedAngle(toOrientTarget, forward, Vector3.up)
 --
 --    --if we are moving we move in our forward direction by our max speed
 --    float moveAmount = Mathf.Clamp01(orientDot) * m_Movement.m_Speed * Time.deltaTime
 --    if (m_IsMoving && moveAmount > 0.000001f)
 --    {
 --        rb.MovePosition(rb.position + forward * moveAmount)
 --    }
 --
 --    --the actual rotation for that frame is the smallest between the max turning speed for that time frame and the
 --    --angle itself. Multiplied by the sign of the angle to ensure we rotate in the right direction
 --    rotatingAngle = Mathf.Sign(rotatingAngle) * Mathf.Min(Mathf.Abs(rotatingAngle), m_Movement.m_TurnSpeed * Time.deltaTime)
 --
 --    if(Mathf.Abs(rotatingAngle) > 0.000001f)
 --        rb.MoveRotation(rb.rotation * Quaternion.AngleAxis(-rotatingAngle, Vector3.up))
 --
 --    -- If we reached our current target, we increase our corner. We will never reach the target when the target
 --    -- is another tank as we stop before.
 --    if (Vector3.Distance(rb.position, orientTarget) < 0.5f)
 --    {
 --        m_CurrentCorner += 1
 --    }
 --}
local dummy8 = nil

 --
 ---- Utility function which will add the length of all the sections of the given path to get its effective length
 --float GetPathLength(NavMeshPath path)
 --{
 --    float dist = 0
 --    for (var i = 1 i < path.corners.Length ++i)
 --    {
 --        dist += Vector3.Distance(path.corners[i-1], path.corners[i])
 --    }
 --
 --    return dist
 --}


return script
