-- This is used to quickly find the GameObject it is added to by using FindObjectOfType.
-- Used by the GameManager to find the text used to display game informations

local script = {...}

-- renamed to clarify that this gets the component, not the component's text!
function script.GetTextComponent()
    return script.gameObject:GetComponent(textmeshprougui)
end

return script
