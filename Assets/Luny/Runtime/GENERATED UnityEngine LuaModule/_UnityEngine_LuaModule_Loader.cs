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
			nsTable["Bounds"] = new Lua_UnityEngine_Bounds_static();
			nsTable["BoundsInt"] = new Lua_UnityEngine_BoundsInt_static();
			nsTable["Color"] = new Lua_UnityEngine_Color_static();
			nsTable["Color32"] = new Lua_UnityEngine_Color32_static();
			nsTable["LayerMask"] = new Lua_UnityEngine_LayerMask_static();
			nsTable["Mathf"] = new Lua_UnityEngine_Mathf_static();
			nsTable["Matrix4x4"] = new Lua_UnityEngine_Matrix4x4_static();
			nsTable["Quaternion"] = new Lua_UnityEngine_Quaternion_static();
			nsTable["Vector2"] = new Lua_UnityEngine_Vector2_static();
			nsTable["Vector2Int"] = new Lua_UnityEngine_Vector2Int_static();
			nsTable["Vector3"] = new Lua_UnityEngine_Vector3_static();
			nsTable["Vector3Int"] = new Lua_UnityEngine_Vector3Int_static();
			nsTable["Vector4"] = new Lua_UnityEngine_Vector4_static();
		}
	}

}
