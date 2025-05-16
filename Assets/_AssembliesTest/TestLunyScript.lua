local script = {...}

function script.Start()
	print("Hello, " .. script.name .. ".lua on " .. tostring(script.gameObject))
end

return script
