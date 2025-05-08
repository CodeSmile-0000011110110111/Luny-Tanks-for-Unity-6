local script = {...}

local m_FireButton = nil                -- The input axis that is used for launching shells.
local m_CurrentLaunchForce = 0         -- The force that will be given to the shell when the fire button is released.
local m_ChargeSpeed = 0                -- How fast the launch force increases, based on the max charge time.
local m_Fired = false                       -- Whether or not the shell has been launched with this button press.
local m_HasSpecialShell = false             -- has the tank a shell that makes extra damage?
local m_SpecialShellMultiplier = 0     -- The amount that the special shell will multiply the damage.
local m_FireAction = nil             -- The Input Action for shooting, retrieve from TankInputUser
local m_BaseMinLaunchForce = 0         -- The initial value of m_MinLaunchForce
local m_ShotCooldownTimer = 0          -- The timer counting down before a shot is allowed again
local m_InputUser = nil           -- The Input User component for that tanks. Contains the Input Actions.

function script.GetCurrentChargeRatio()
    return (m_CurrentLaunchForce - m_MinLaunchForce) / (m_MaxLaunchForce - m_MinLaunchForce) --The charging amount between 0-1
end

script.IsCharging = false           -- Are we currently charging the shot
script.IsComputerControlled = false

local gameObject = nil

function script.Awake()
    gameObject = script.gameObject

    m_InputUser = gameObject:GetComponent(lunytankinputuser)
    if not m_InputUser then
        m_InputUser = gameObject:AddComponent(lunytankinputuser)
    end
end

function script.OnEnable()
    -- When the tank is turned on, reset the launch force, the UI and the power ups
    m_CurrentLaunchForce = script.MinLaunchForce
    m_BaseMinLaunchForce = script.MinLaunchForce
    script.AimSlider.value = m_BaseMinLaunchForce
    script.AimSlider.minValue = script.MinLaunchForce
    script.AimSlider.maxValue = script.MaxLaunchForce

    m_HasSpecialShell = false
    m_SpecialShellMultiplier = 1.0
end

function script.Start()
    -- The fire axis is based on the player number.
    m_FireButton = "Fire"
    m_FireAction = m_InputUser.ActionAsset:FindAction(m_FireButton)
    m_FireAction:Enable()

    -- The rate that the launch force charges up is the range of possible forces by the max charge time.
    m_ChargeSpeed = (script.MaxLaunchForce - script.MinLaunchForce) / script.MaxChargeTime
end

function script.Update()
    -- Computer and Human control Tank use 2 different update functions
    if script.IsComputerControlled then
        script.ComputerUpdate()
    else
        script.HumanUpdate()
    end
end

--/ <summary>
--/ Used by AI to start charging
--/ </summary>
function script.StartCharging() -- public
    script.IsCharging = true
    -- ... reset the fired flag and reset the launch force.
    m_Fired = false
    m_CurrentLaunchForce = script.MinLaunchForce

    -- Change the clip to the charging clip and start it playing.
    script.ShootingAudio.clip = script.ChargingClip
    script.ShootingAudio:Play()
end

function script.StopCharging() -- public
    if script.IsCharging then
        script.Fire()
        script.IsCharging = false
    end
end

function script.ComputerUpdate()
    -- The slider should have a default value of the minimum launch force.
    script.AimSlider.value = m_BaseMinLaunchForce

    -- If the shell hasn't yet been launched...
    if not m_Fired then
        -- If the max force has been exceeded...
        if m_CurrentLaunchForce >= script.MaxLaunchForce then
            print("C A")
            -- ... use the max force and launch the shell.
            m_CurrentLaunchForce = script.MaxLaunchForce
            script.Fire()
        -- Otherwise, if the fire button is being held...
        elseif script.IsCharging then
            print("C B")
            -- Increment the launch force and update the slider.
            m_CurrentLaunchForce = m_CurrentLaunchForce + m_ChargeSpeed * time.deltaTime

            script.AimSlider.value = m_CurrentLaunchForce
        -- Otherwise, if the fire button is released...
        elseif m_FireAction:WasReleasedThisFrame() then
            print("C C")
            -- ... launch the shell.
            script.Fire()
            script.IsCharging = false
        end
    end
end

function script.HumanUpdate()
    -- if there is a cooldown timer, decrement it
    if m_ShotCooldownTimer > 0.0 then
        m_ShotCooldownTimer = m_ShotCooldownTimer - time.deltaTime
    end

    -- The slider should have a default value of the minimum launch force.
    script.AimSlider.value = m_BaseMinLaunchForce

    -- If the max force has been exceeded and the shell hasn't yet been launched...
    if m_CurrentLaunchForce >= script.MaxLaunchForce and not m_Fired then
        print("HumanUpdate A")
        -- ... use the max force and launch the shell.
        m_CurrentLaunchForce = script.MaxLaunchForce
        script.Fire()
    -- Otherwise, if the fire button has just started being pressed...
    elseif m_ShotCooldownTimer <= 0 and m_FireAction:WasPressedThisFrame() then
        print("HumanUpdate B")
        -- ... reset the fired flag and reset the launch force.
        m_Fired = false
        m_CurrentLaunchForce = script.MinLaunchForce

        -- Change the clip to the charging clip and start it playing.
        script.ShootingAudio.clip = script.ChargingClip
        script.ShootingAudio:Play()
    -- Otherwise, if the fire button is being held and the shell hasn\'t been launched yet...
    elseif m_FireAction:IsPressed() and not m_Fired then
        print("HumanUpdate C")
        -- Increment the launch force and update the slider.
        m_CurrentLaunchForce = m_CurrentLaunchForce + m_ChargeSpeed * time.deltaTime

        script.AimSlider.value = m_CurrentLaunchForce
    -- Otherwise, if the fire button is released and the shell hasn\'t been launched yet...
    elseif m_FireAction:WasReleasedThisFrame() and not m_Fired then
        print("HumanUpdate D")
        -- ... launch the shell.
        script.Fire()
    end
end

function script.Fire()
    print("Fire")
    -- Set the fired flag so only Fire is only called once.
    m_Fired = true

    -- Create an instance of the shell and store a reference to it\'s rigidbody.
    print("FIXME: instantiate 'as Rigidbody'")
    local shellPos = script.FireTransform.position
    local shellRot = script.FireTransform.rotation
    local shellInstance = gameobject.Instantiate(script.Shell, shellPos, shellRot)
    print("shellInstance", shellInstance)

    -- Set the shell\'s velocity to the launch force in the fire position\'s forward direction.
    shellInstance.linearVelocity = m_CurrentLaunchForce * script.FireTransform.forward

    local explosionData = shellInstance:GetComponent(lunyshellexplosion).script
    explosionData.ExplosionForce = script.ExplosionForce
    explosionData.ExplosionRadius = script.ExplosionRadius
    explosionData.MaxDamage = script.MaxDamage

    -- Increase the damage if extra damage PowerUp is active
    if m_HasSpecialShell then
        explosionData.MaxDamage = explosionData.MaxDamage * m_SpecialShellMultiplier
        -- Reset the default values after increasing the damage of the fired shell
        m_HasSpecialShell = false
        m_SpecialShellMultiplier = 1

        local powerUpDetector = gameObject:GetComponent(lunypowerupdetector)
        if powerUpDetector then
            powerUpDetector.script.HasActivePowerUp = false
        end

        local powerUpHUD = gameObject:GetComponentInChildren(lunypoweruphud)
        if powerUpHUD then
            powerUpHUD.script.DisableActiveHUD()
        end
    end

    -- Change the clip to the firing clip and play it.
    script.ShootingAudio.clip = script.FireClip
    script.ShootingAudio:Play()

    -- Reset the launch force.  This is a precaution in case of missing button events.
    m_CurrentLaunchForce = script.MinLaunchForce

    m_ShotCooldownTimer = script.ShotCooldown
end

function script.EquipSpecialShell(damageMultiplier) -- public
    m_HasSpecialShell = true
    m_SpecialShellMultiplier = damageMultiplier
end

--/ <summary>
--/ Return the estimated position the projectile will have with the charging level (between 0 & 1)
--/ </summary>
--/ <param name="chargingLevel">The fire charging level between 0 - 1</param>
--/ <returns>The position at which the projectile will be (ignore obstacle)</returns>
function script.GetProjectilePosition(chargingLevel) -- public
    local chargeLevel = mathf.Lerp(script.MinLaunchForce, script.MaxLaunchForce, chargingLevel)
    local velocity = chargeLevel * script.FireTransform.forward

    local a = 0.5 * physics.gravity.y
    local b = velocity.y
    local c = script.FireTransform.position.y

    local sqrtContent = b * b - 4 * a * c
    --no solution
    if sqrtContent <= 0 then
        return script.FireTransform.position
    end

    local answer1 = ((-b) + mathf.Sqrt(sqrtContent)) / (2 * a)
    local answer2 = ((-b) - mathf.Sqrt(sqrtContent)) / (2 * a)
    local answer = answer1 > 0 and answer1 or answer2

    local position = script.FireTransform.position + vector3.New(velocity.x, 0, velocity.z) * answer
    position.y = 0

    return position
end

return script
