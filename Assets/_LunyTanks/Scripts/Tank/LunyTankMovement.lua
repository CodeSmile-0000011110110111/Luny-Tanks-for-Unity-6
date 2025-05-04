local script = {...}

local m_Rigidbody = nil
local m_InputUser = nil

function script.Awake()
    m_Rigidbody = script.gameObject:GetComponent(rigidbody)

    print("Awake LunyTankMovement")
    m_InputUser = script.gameObject:GetComponent(lunytankinputuser)
    print("Awake LunyTankMovement inputUser", m_InputUser)
    if not m_InputUser then
        m_InputUser = script.gameObject:AddComponent(lunytankinputuser)
        print("Awake LunyTankMovement inputUser after add", m_InputUser)
    end
end

return script
