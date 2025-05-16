// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------
using CodeSmile.Luny;
using Lua;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace CodeSmile.Luny.DefaultContext
{
	[Serializable] [Preserve]
	public sealed class System_IO_LuaModuleLoader : LuaModuleLoader
	{

		public override void Load(LuaTable env)
		{
			base.Load(env);
			var ns = GetOrCreateNamespaceTable(env, new[] { "System", "IO" });
			ns["File"] = new System_IO_File_static();
		}
	}
}
