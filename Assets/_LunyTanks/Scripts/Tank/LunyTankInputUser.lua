-- Contains the Input System Input User that is linked to a Tank. This take care of copying the default input actions
-- from the Project Settings and link them to the given Input User. This is necessary as otherwise the project wide
-- input actions would keep getting overriden by whoever bind to them last.
local script = {...}

script.InputUser = nil      -- The InputUser for this tank
script.ActionAsset = nil    -- The local Input Action Asset copy only binded to the right device

function script.Awake()
    -- Clone the Action Map so the actions can be paired with a specific device (otherwise the default actions
    -- would be claimed by one device then ben unavailable for any other player)
    m_LocalActionAsset = inputactionasset.FromJson(inputsystem.actions:ToJson())

    -- By default, pair to the keyboard, as this is the default input method. This allow this to work even without
    -- a menu to assign any other input mode.
    script.SetNewInputUser(inputuser.PerformPairingWithDevice(keyboard.current))
end

-- Activate the given control scheme on the Input User
function script.ActivateScheme(name)
    m_InputUser:ActivateControlScheme(name)
end

-- Replace the input user contained in this component by the given one
function script.SetNewInputUser(user)
    if not user.valid then
        return
    end

    m_InputUser = user
    m_InputUser:AssociateActionsWithUser(m_LocalActionAsset)

    -- If this user have an associated controlScheme (e.g. in this project KeyboardRight or KeyboardLeft) we
    -- re-activate this scheme on the input user. This is necessary as we changed the associated actions in the above
    -- line, so those new action haven't had their control scheme set, and this will set it.
    if m_InputUser.controlScheme.HasValue then
        m_InputUser:ActivateControlScheme(m_InputUser.controlScheme.Value)
    end
end
        
return script
