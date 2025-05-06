local script = {...}

local m_MovementAxisName = nil          -- The name of the input axis for moving forward and back.
local m_TurnAxisName = nil              -- The name of the input axis for turning.
local m_Rigidbody = nil              -- Reference used to move the tank.
local m_MovementInputValue = nil         -- The current value of the movement input.
local m_TurnInputValue = 0             -- The current value of the turn input.
local m_OriginalPitch = 0              -- The pitch of the audio source at the start of the scene.
local m_ParticleSystems = nil       -- References to all the particles systems used by the Tanks

local m_MoveAction = nil             -- The InputAction used to move, retrieved from TankInputUser
local m_TurnAction = nil             -- The InputAction used to shot, retrieved from TankInputUser

local m_RequestedDirection = nil       -- In Direct Control mode, store the direction the user *wants* to go toward

local m_InputUser = nil

local gameObject = nil
local transform = nil

function script.Awake()
    gameObject = script.gameObject
    transform = script.transform

    m_Rigidbody = gameObject:GetComponent(rigidbody)

    m_InputUser = gameObject:GetComponent(lunytankinputuser)
    if not m_InputUser then
        m_InputUser = gameObject:AddComponent(lunytankinputuser)
    end

    -- prefer to use Lua script rather than C# component which remains accessible: m_InputUser.component
    m_InputUser = m_InputUser.script
end

function script.OnEnable()
    -- Computer controlled tank are kinematic
    m_Rigidbody.isKinematic = false

    -- Also reset the input values.
    m_MovementInputValue = 0
    m_TurnInputValue = 0

    -- We grab all the Particle systems child of that Tank to be able to Stop/Play them on Deactivate/Activate
    -- It is needed because we move the Tank when spawning it, and if the Particle System is playing while we do that
    -- it "think" it move from (0,0,0) to the spawn point, creating a huge trail of smoke
    m_ParticleSystems = gameObject:GetComponentsInChildren(particlesystem)
    for _, particleSystem in ipairs(m_ParticleSystems) do
        particleSystem:Play()
    end
end

function script.OnDisable()
    -- When the tank is turned off, set it to kinematic so it stops moving.
    m_Rigidbody.isKinematic = true

    -- Stop all particle system so it "reset" it's position to the actual one instead of thinking we moved when spawning
    for _, particleSystem in ipairs(m_ParticleSystems) do
        particleSystem:Stop()
    end
end

function script.Start()
    -- If this is computer controlled...
    if m_IsComputerControlled then
        -- but it doesn't have an AI component...
        local ai = gameObject:GetComponent(lunytankai)
        if not ai then
            -- we add it, to ensure this will control the tank.
            -- This is only useful when user test tank in empty scene, otherwise the TankManager ensure
            -- computer controlled tank are setup properly
            gameObject:AddComponent(lunytankai)
        end
    end

    -- If no control index was set, this mean this is a scene without a GameManager and that tank was manually
    -- added to an empty scene, so we used the manually set Player Number in the Inspector as the ControlIndex,
    -- so Player 1 will be ControlIndex 1 -> KeyboardLeft and Player 2 -> KeyboardRight
    if ControlIndex == -1 and not m_IsComputerControlled then
        ControlIndex = m_PlayerNumber
    end

    local mobileControl = gameobject.FindAnyObjectByType(lunymobileuicontrol)

    -- By default, ControlIndex 1 is matched to KeyboardLeft. But if there is a mobile UI control component in the scene
    -- and it is active (so we either are on mobile or it was force activated to test by the user) then we instead
    -- match ControlIndex 1 to the virtual Gamepad on screen.
    if mobileControl and ControlIndex == 1 then
        m_InputUser.SetNewInputUser(InputUser.PerformPairingWithDevice(mobileControl.Device))
        m_InputUser.ActivateScheme("Gamepad")
    else
        -- otherwise if no mobile ui control is active, ControlIndex is KeyboardLeft scheme and ControlIndex 2 is KeyboardRight
        m_InputUser.ActivateScheme(script.ControlIndex == 1 and "KeyboardLeft" or "KeyboardRight")
    end

    -- The axes names are based on player number.
    m_MovementAxisName = "Vertical"
    m_TurnAxisName = "Horizontal"

    -- Get the action input from the TankInputUser component which will have taken care of copying them and
    -- binding them to the right device and control scheme
    m_MoveAction = m_InputUser.ActionAsset:FindAction(m_MovementAxisName)
    m_TurnAction = m_InputUser.ActionAsset:FindAction(m_TurnAxisName)

    -- actions need to be enabled before they can react to input
    m_MoveAction.Enable()
    m_TurnAction.Enable()

    -- Store the original pitch of the audio source.
    m_OriginalPitch = m_MovementAudio.pitch
end

function script.Update()
    -- Computer controlled tank will be moved by the TankAI component, so only read input for player controlled tanks
    if not m_IsComputerControlled then
        m_MovementInputValue = m_MoveAction:ReadFloat(float)
        m_TurnInputValue = m_TurnAction:ReadFloat(float)
    end

    script.EngineAudio()
end

function script.EngineAudio()
    -- If there is no input (the tank is stationary)...
    if mathf.Abs(m_MovementInputValue) < 0.1 and mathf.Abs(m_TurnInputValue) < 0.1 then
        -- ... and if the audio source is currently playing the driving clip...
        if m_MovementAudio.clip == m_EngineDriving then
            -- ... change the clip to idling and play it.
            m_MovementAudio.clip = m_EngineIdling
            m_MovementAudio.pitch = random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange)
            m_MovementAudio.Play()
        end
    else
        -- Otherwise if the tank is moving and if the idling clip is currently playing...
        if m_MovementAudio.clip == m_EngineIdling then
            -- ... change the clip to driving and play.
            m_MovementAudio.clip = m_EngineDriving
            m_MovementAudio.pitch = random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange)
            m_MovementAudio.Play()
        end
    end
end

function script.FixedUpdate()
    -- If this is using a gamepad or have direct control enabled, this used a different movement method : instead of
    -- "up" behind moving forward for the tank, it instead takes the gamepad move direction as the desired forward for the tank
    -- and will compute the speed and rotation needed to move the tank toward that direction.
    if m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" or  m_IsDirectControl then
        local camForward = camera.main.transform.forward
        camForward.y = 0
        camForward.Normalize()
        local camRight = vector3.Cross(vector3.up, camForward)

        --this creates a vector based on camera look (e.g. pressing up mean we want to go up in the direction of the
        --camera, not forward in the direction of the tank)
        m_RequestedDirection = (camForward * m_MovementInputValue + camRight * m_TurnInputValue)
    end

    -- Adjust the rigidbodies position and orientation in FixedUpdate.
    script.Move()
    script.Turn()
end

function script.Move()
    local speedInput = 0

    -- In direct control mode, the speed will depend on how far from the desired direction we are
    if m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" or m_IsDirectControl then
        speedInput = m_RequestedDirection.magnitude
        --if we are direct control, the speed of the move is based angle between current direction and the wanted
        --direction. If under 90, full speed, then speed reduced between 90 and 180
        speedInput = speedInput * (1 - mathf.Clamp01((vector3.Angle(m_RequestedDirection, transform.forward) - 90) / 90))
    else
        -- in normal "tank control" the speed value is how much we press "up/forward"
        speedInput = m_MovementInputValue
    end

    -- Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
    local movement = transform.forward * speedInput * m_Speed * time.deltaTime

    -- Apply this movement to the rigidbody's position.
    m_Rigidbody.MovePosition(m_Rigidbody.position + movement)
end

function script.Turn()
    local turnRotation = nil

    -- If in direct control...
    if m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" or m_IsDirectControl then
        -- Compute the rotation needed to reach the desired direction
        local angleTowardTarget = vector3.SignedAngle(m_RequestedDirection, transform.forward, transform.up)
        local rotatingAngle = mathf.Sign(angleTowardTarget) * mathf.Min(mathf.Abs(angleTowardTarget), m_TurnSpeed * time.deltaTime)
        turnRotation = quaternion.AngleAxis(-rotatingAngle, vector3.up)
    else
        local turn = m_TurnInputValue * m_TurnSpeed * time.deltaTime

        -- Make this into a rotation in the y axis.
        turnRotation = quaternion.Euler(0, turn, 0)
    end

    -- Apply this rotation to the rigidbody's rotation.
    m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation)
end

return script
