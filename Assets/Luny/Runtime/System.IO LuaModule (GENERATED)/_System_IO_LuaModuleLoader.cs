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
	public sealed class _System_IO_LuaModuleLoader : LuaModuleLoader
	{

		public override void Load(LuaTable env)
		{
			base.Load(env);
			var namespaces = new[] { "System", "IO" };
			var nsTable = GetOrCreateNamespaceTable(env, namespaces);
			nsTable["Directory"] = new System_IO_Directory_static();
			nsTable["File"] = new System_IO_File_static();
			nsTable["Path"] = new System_IO_Path_static();
		}
	}
}
