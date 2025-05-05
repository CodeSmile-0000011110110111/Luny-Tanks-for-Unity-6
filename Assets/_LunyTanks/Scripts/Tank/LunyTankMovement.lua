local script = {...}

local m_Rigidbody = nil
local m_InputUser = nil

function script.Awake()
    m_Rigidbody = script.gameObject:GetComponent(rigidbody)

    m_InputUser = script.gameObject:GetComponent(lunytankinputuser)
    if not m_InputUser then
        m_InputUser = script.gameObject:AddComponent(lunytankinputuser)
    end
end

return script
