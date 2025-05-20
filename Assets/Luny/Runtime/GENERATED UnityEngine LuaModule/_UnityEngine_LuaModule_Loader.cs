// --------------------------------------------------------------
// GENERATED FILE ----> DO NOT EDIT <---- CHANGES WILL BE LOST !!
// --------------------------------------------------------------
using CodeSmile.Luny;
using Lua;
using Lua.Runtime;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

namespace CodeSmile.Luny.DefaultContext
{
	[Serializable]
	public sealed class _UnityEngine_LuaModule_Loader : LuaModuleLoader
	{

		public override void Load(LuaTable env)
		{
			base.Load(env);
			var namespaces = new[] { "UnityEngine" };
			var nsTable = GetOrCreateNamespaceTable(env, namespaces);
			nsTable["Vector3"] = new Lua_UnityEngine_Vector3_static();
		}
	}

}
