// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using CodeSmile.Luny.DefaultContext;
using Lua;
using System;
using UnityEditor;
using UnityEngine;

public sealed class TestLunyScript : LunyScript
{
	protected override async void OnAwake()
	{
		var env = Luny.Lua.State.Environment;

		// env["System"] = new LuaTable();
		// env["System"].AsTable()["IO"] = new LuaTable();
		// env["System"].AsTable()["IO"].Read<LuaTable>()["File"] = new LuaTable();

		//BindType(env, FileIO_static.TypeFullName, new FileIO_static());


		var script = "print(System)\nprint(System.IO)\n";
		await Luny.MainLua.DoStringAsync(script, "test");
	}

	private static void BindType(LuaTable env, String[] typeFullName, LuaValue instance)
	{
		LuaTable current = env;
		var namespaceCount = typeFullName.Length - 1;
		for (int i = 0; i < namespaceCount; i++)
		{
			var name = typeFullName[i];
			if (current[name].TryRead(out LuaTable next) == false)
			{
				next = new LuaTable();
				current[name] = next;
			}

			current = next;
		}
		current[typeFullName[namespaceCount]] = instance;
	}

	protected override void OnBeforeScriptAwake() {}
}
