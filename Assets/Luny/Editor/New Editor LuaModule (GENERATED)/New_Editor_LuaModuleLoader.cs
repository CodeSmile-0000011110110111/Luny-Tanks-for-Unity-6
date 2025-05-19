// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------
using CodeSmile.Luny;
using Lua;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace CodeSmileEditor.Luny.DefaultContext
{
	[Serializable] [Preserve]
	public sealed class New_Editor_LuaModuleLoader : LuaModuleLoader
	{

		public override void Load(LuaTable env)
		{
			base.Load(env);
			var ns = GetOrCreateNamespaceTable(env, new[] { "System" });
		}
	}
}
