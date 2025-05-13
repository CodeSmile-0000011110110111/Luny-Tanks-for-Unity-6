using CodeSmile.Luny;
using Lua;
using UnityEditor;
using UnityEngine;

namespace ThatGame
{
	[System.Serializable] public sealed class _Luny_UnityEngine_CoreModule_Loader : LuaModuleLoader
	{
		public override void Load(LuaState luaState) => base.Load(luaState);
	}
}
