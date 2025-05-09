local script = {...}

-- All those are hidden in inspector as they will actually come from the TankShooting scripts
script.MaxDamage = 100                    -- The amount of damage done if the explosion is centred on a tank.
script.ExplosionForce = 1000              -- The amount of force added to a tank at the centre of the explosion.
script.ExplosionRadius = 5                -- The maximum distance away from the explosion tanks can be and are still affected.

local m_MaxLifeTime = 2  -- The time in seconds before the shell is removed.

local gameObject = nil
local transform = nil

function script.Awake()
    gameObject = script.gameObject
    transform = script.transform
end

function script.Start()
    -- If it isn't destroyed by then, destroy the shell after its lifetime.
    gameobject.Destroy(gameObject, m_MaxLifeTime)
end

function script.OnTriggerEnter(other)
    -- Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
    local colliders = physics.OverlapSphere(transform.position, script.ExplosionRadius, script.TankMask)

    -- Go through all the colliders...
    for i, collider in ipairs(colliders) do
        -- ... and find their rigidbody.
        local targetRigidbody = collider:GetComponent(rigidbody)

        -- If they don't have a rigidbody, go on to the next collider.
        if not targetRigidbody then
            goto continue
        end

        -- Add an explosion force.
        targetRigidbody:AddExplosionForce(script.ExplosionForce, transform.position, script.ExplosionRadius)

        -- Find the TankHealth script associated with the rigidbody.
        local targetHealth = targetRigidbody:GetComponent(lunytankhealth)

        -- If there is no TankHealth script attached to the gameobject, go on to the next collider.
        if not targetHealth then
            goto continue
        end

        -- Calculate the amount of damage the target should take based on it's distance from the shell.
        local damage = script.CalculateDamage(targetRigidbody.position)

        -- Deal this damage to the tank.
        targetHealth.script.TakeDamage(damage)

        ::continue::
    end

    -- Unparent the particles from the shell.
    script.ExplosionParticles.transform.parent = nil

    -- Play the particle system.
    script.ExplosionParticles:Play()

    -- Play the explosion sound effect.
    script.ExplosionAudio:Play()

    -- Once the particles have finished, destroy the gameobject they are on.
    local mainModule = script.ExplosionParticles.main
    gameobject.Destroy(script.ExplosionParticles.gameObject, mainModule.duration)

    -- Destroy the shell.
    gameobject.Destroy(gameObject)
end

function script.CalculateDamage(targetPosition)
    -- Create a vector from the shell to the target.
    local explosionToTarget = targetPosition - transform.position

    -- Calculate the distance from the shell to the target.
    local explosionDistance = explosionToTarget.magnitude

    -- Calculate the proportion of the maximum distance (the explosionRadius) the target is away.
    local relativeDistance = (script.ExplosionRadius - explosionDistance) / script.ExplosionRadius

    -- Calculate damage as this proportion of the maximum possible damage.
    local damage = relativeDistance * script.MaxDamage

    -- Make sure that the minimum damage is always 0.
    damage = mathf.Max(0, damage)

    return damage
end

return script
