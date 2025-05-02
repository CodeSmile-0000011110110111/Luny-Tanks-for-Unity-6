-- 'script' can be renamed, but it must be a table
-- the three dots (...) represent variable arguments passed in (reserved for future use)
local script = {...}
-- you are free to add custom variables to script, these are read/writeable in C#
script.OhWowThatsCoolBool = true

-- any Unity event can be a Lua function defined in the 'script' table
function script.Start()
	print("Hello, " .. script.name .. ".lua on " .. tostring(script.gameObject))
end

-- scripts must return a table containing zero or more Unity event functions
return script
