local script = {...}

local m_ExplosionAudio = nil        -- The audio source to play when the tank explodes.
local m_ExplosionParticles = nil    -- The particle system the will play when the tank is destroyed.
local m_CurrentHealth = 0           -- How much health the tank currently has.
local m_Dead = false                -- Has the tank been reduced beyond zero health yet?
local m_ShieldValue = 0             -- Percentage of reduced damage when the tank has a shield.
local m_IsInvincible = false        -- Is the tank invincible in this moment?
local m_HasShield                   -- Has the tank picked up a shield power up?

-- property accessors
function script.GetHasShield()
    return m_HasShield
end

function script.Awake()
    -- Instantiate the explosion prefab and get a reference to the particle system on it.
    m_ExplosionParticles = gameobject.Instantiate(script.ExplosionPrefab):GetComponent(particlesystem)

    -- Get a reference to the audio source on the instantiated prefab.
    m_ExplosionAudio = m_ExplosionParticles:GetComponent(audiosource)

    -- Disable the prefab so it can be activated when it's required.
    m_ExplosionParticles.gameObject:SetActive(false)

    -- Set the slider max value to the max health the tank can have
    script.Slider.maxValue = script.StartingHealth
end

function script.OnDestroy()
    if m_ExplosionParticles then
        gameobject.Destroy(m_ExplosionParticles.gameObject)
    end
end

function script.OnEnable()
    -- When the tank is enabled, reset the tank's health and whether or not it's dead.
    m_CurrentHealth = script.StartingHealth
    m_Dead = false
    m_HasShield = false
    m_ShieldValue = 0
    m_IsInvincible = false

    -- Update the health slider's value and color.
    script.SetHealthUI()
end

function script.TakeDamage(amount)
    -- Check if the tank is not invincible
    if not m_IsInvincible then
        -- Reduce current health by the amount of damage done.
        m_CurrentHealth = m_CurrentHealth - amount * (1 - m_ShieldValue)

        -- Change the UI elements appropriately.
        script.SetHealthUI()

        -- If the current health is at or below zero and it has not yet been registered, call OnDeath.
        if m_CurrentHealth <= 0 and not m_Dead then
            script.OnDeath()
        end
    end
end

function script.IncreaseHealth(amount)
    -- Check if adding the amount would keep the health within the maximum limit
    if (m_CurrentHealth + amount <= script.StartingHealth) then
        -- If the new health value is within the limit, add the amount
        m_CurrentHealth = m_CurrentHealth + amount
    else
        -- If the new health exceeds the starting health, set it at the maximum
        m_CurrentHealth = script.StartingHealth
    end

    -- Change the UI elements appropriately.
    script.SetHealthUI()
end

function script.ToggleShield(shieldAmount)
    -- Inverts the value of has shield.
    m_HasShield = not m_HasShield

    -- Establish the amount of damage that will be reduced by the shield
    if m_HasShield then
        m_ShieldValue = shieldAmount
    else
        m_ShieldValue = 0
    end
end

function script.ToggleInvincibility()
    m_IsInvincible = not m_IsInvincible
end

function script.SetHealthUI()
    -- Set the slider's value appropriately.
    script.Slider.value = m_CurrentHealth

    -- Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
    local zeroColor = script.ZeroHealthColor
    local fullColor = script.FullHealthColor
    local health = m_CurrentHealth / script.StartingHealth
    script.FillImage.color = color.Lerp(zeroColor, fullColor, health)
end

function script.OnDeath()
    -- Set the flag so that this function is only called once.
    m_Dead = true

    -- Move the instantiated explosion prefab to the tank's position and turn it on.
    m_ExplosionParticles.transform.position = script.transform.position
    m_ExplosionParticles.gameObject:SetActive(true)

    -- Play the particle system of the tank exploding.
    m_ExplosionParticles:Play()

    -- Play the tank explosion sound effect.
    m_ExplosionAudio:Play()

    -- Turn the tank off.
    script.gameObject:SetActive(false)
end

return script
