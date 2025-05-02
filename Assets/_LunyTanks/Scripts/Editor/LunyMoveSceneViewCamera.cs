using CodeSmile.Luny;
using UnityEngine;

public sealed class LunyMoveSceneViewCamera : LunyScript
{
	// Awake cannot be overridden, use OnAwake instead. The script has not been loaded at this point!
	protected override void OnAwake()
	{
	}

	// Script was run and returned a LuaTable. Script's Awake() function has not been called yet.
	// You may want to get/set initial script variables before script's Awake():
	protected override void OnBeforeScriptAwake()
	{
		// Variables are set to the script table (commonly named 'script'): 'print(script.ImportantMessage)'
		SetString("ImportantMessage", "Testing One-Two-Three ..");

		// If you need the value of 'script.OhWowThatsCoolBool' assigned by the Lua script:
		var datBool = GetBool("OhWowThatsCoolBool");
	}
}
