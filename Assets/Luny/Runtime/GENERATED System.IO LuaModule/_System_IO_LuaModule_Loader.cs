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
	public sealed class _System_IO_LuaModule_Loader : LuaModuleLoader
	{

		public override void Load(LuaTable env)
		{
			base.Load(env);
			var namespaces = new[] { "System", "IO" };
			var nsTable = GetOrCreateNamespaceTable(env, namespaces);
		}
	}

}
