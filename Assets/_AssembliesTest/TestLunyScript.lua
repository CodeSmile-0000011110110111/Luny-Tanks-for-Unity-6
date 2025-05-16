local script = {...}

function script.Start()
	print("Hello, " .. script.name .. ".lua on " .. tostring(script.gameObject))
	print("File is", System.IO.File)
	print("File.testfunc()", System.IO.File:testfunc(0.01234567890123456789))
end

return script
