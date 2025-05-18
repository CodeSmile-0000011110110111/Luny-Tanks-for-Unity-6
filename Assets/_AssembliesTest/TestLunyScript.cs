// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using UnityEditor;
using UnityEngine;

public sealed class TestLunyScript : LunyScript
{
	protected override async void OnAwake()
	{
		var env = Luny.Lua.State.Environment;

		var script = "print('System',System)\nprint('System.IO',System.IO)\nprint('System.IO.File',System.IO.File)";
		await Luny.MainLua.DoStringAsync(script, nameof(TestLunyScript));
	}

	protected override void OnBeforeScriptAwake() {}
}
