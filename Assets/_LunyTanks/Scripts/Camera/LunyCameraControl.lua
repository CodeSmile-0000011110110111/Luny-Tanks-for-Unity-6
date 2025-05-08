local script = {...}
script.Targets = {}                       -- All the targets the camera needs to encompass.

local m_Camera = nil                        -- Used for referencing the camera.
local m_ZoomSpeed = 0                     -- Reference speed for the smooth damping of the orthographic size.
local m_MoveVelocity = vector3.New()                 -- Reference velocity for the smooth damping of the position.
local m_DesiredPosition = vector3.New()              -- The position the camera is moving towards.
local m_AimToRig = vector3.New()                     -- The offset to apply to the position so the child camera aim at the desired point

local gameObject = nil
local transform = nil

function script.Awake()
    gameObject = script.gameObject
    transform = script.transform

    m_Camera = gameObject:GetComponentInChildren(camera)

    -- plane in which the camera rig is in
    local p = plane.New(vector3.up, transform.position)
    local r = ray.New(m_Camera.transform.position, m_Camera.transform.forward)
    local didHit, d = p:Raycast(r)

    -- This is where the camera aim on the rig plane
    local aimTArget = r:GetPoint(d)

    -- User can set the camera in random position and rotation as a child of this object, so it won't aim at the
    -- center of this, meaning placing this object at the desired position won't make the camera aim at that desired position.
    -- This offset correct that so the camera actually aim at the desired position
    m_AimToRig = transform.position - aimTArget
end

function script.FixedUpdate()
    -- Move the camera towards a desired position.
    script.Move()

    -- Change the size of the camera based.
    script.Zoom()
end

function script.Move()
    -- Find the average position of the targets.
    script.FindAveragePosition()

    -- Smoothly transition to that position.
    local targetPos = m_DesiredPosition + m_AimToRig
    transform.position = vector3.SmoothDamp(transform.position, targetPos, m_MoveVelocity, script.DampTime)
end

function script.FindAveragePosition()
    local averagePos = vector3.New()
    local numTargets = 0

    -- Go through all the targets and add their positions together.
    for _, target in ipairs(script.Targets) do
        -- If the target isn't active, go on to the next one.
        if not target.gameObject.activeSelf then
            goto continue
        end

        -- Add to the average and increment the number of targets in the average.
        averagePos = averagePos + target.position
        numTargets = numTargets + 1

        ::continue::
    end

    -- If there are targets divide the sum of the positions by the number of them to find the average.
    if numTargets > 0 then
        averagePos = averagePos / numTargets
    end

    -- Keep the same y value.
    averagePos.y = transform.position.y

    m_DesiredPosition = averagePos
end

function script.Zoom()
    -- Find the required size based on the desired position and smoothly transition to that size.
    local requiredSize = script.FindRequiredSize()
    m_Camera.orthographicSize = mathf.SmoothDamp(m_Camera.orthographicSize, requiredSize, m_ZoomSpeed, script.DampTime)
end

function script.FindRequiredSize()
    -- Find the position the camera rig is moving towards in its local space.
    local desiredLocalPos = m_Camera.transform:InverseTransformPoint(m_DesiredPosition)

    -- Start the camera's size calculation at zero.
    local size = 0

    -- Go through all the targets...
    for _, target in ipairs(script.Targets) do
        -- ... and if they aren't active continue on to the next target.
        if not target.gameObject.activeSelf then
            goto continue
        end

        -- Otherwise, find the position of the target in the camera's local space.
        local targetLocalPos = m_Camera.transform:InverseTransformPoint(target.position)

        -- Find the position of the target from the desired position of the camera's local space.
        local desiredPosToTarget = targetLocalPos - desiredLocalPos

        -- Choose the largest out of the current size and the distance of the tank 'up' or 'down' from the camera.
        size = mathf.Max(size, mathf.Abs(desiredPosToTarget.y))

        -- Choose the largest out of the current size and the calculated size based on the tank being to the left or right of the camera.
        size = mathf.Max(size, mathf.Abs(desiredPosToTarget.x) / m_Camera.aspect)

        ::continue::
    end

    -- Add the edge buffer to the size.
    size = size + script.ScreenEdgeBuffer

    -- Make sure the camera's size isn't below the minimum.
    size = mathf.Max(size, script.MinSize)

    return size
end

function script.SetStartPositionAndSize()
    -- Find the desired position.
    script.FindAveragePosition()

    -- Set the camera's position to the desired position without damping.
    transform.position = m_DesiredPosition

    -- Find and set the required size of the camera.
    m_Camera.orthographicSize = script.FindRequiredSize()
end

return script
