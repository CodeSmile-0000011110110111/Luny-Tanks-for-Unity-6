using CodeSmile.Luny;
using Lua;
using UnityEditor;
using UnityEngine;

namespace LunyEditorContext
{
	[System.Serializable]
	public sealed class _UnityEditor_CoreModule_Loader : LuaModuleLoader
	{
		public override void Load(LuaState luaState) => base.Load(luaState);
	}
}
