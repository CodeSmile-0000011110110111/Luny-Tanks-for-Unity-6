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
	public class Lua_UnityEngine_ISerializationCallbackReceiver : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ISerializationCallbackReceiver" };

		private static readonly LuaFunction _OnAfterDeserialize = new("UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ISerializationCallbackReceiver>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OnAfterDeserialize();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OnBeforeSerialize = new("UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ISerializationCallbackReceiver>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OnBeforeSerialize();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_ISerializationCallbackReceiver instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "OnAfterDeserialize": return _OnAfterDeserialize;
				case "OnBeforeSerialize": return _OnBeforeSerialize;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ISerializationCallbackReceiver instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ISerializationCallbackReceiver>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ISerializationCallbackReceiver>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ISerializationCallbackReceiver Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ISerializationCallbackReceiver v) => new(v);
		public Lua_UnityEngine_ISerializationCallbackReceiver(UnityEngine.ISerializationCallbackReceiver instance) { m_Instance = instance; }
		private UnityEngine.ISerializationCallbackReceiver m_Instance;
		public UnityEngine.ISerializationCallbackReceiver Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_ISerializationCallbackReceiver_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ISerializationCallbackReceiver" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_ISerializationCallbackReceiver_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ISerializationCallbackReceiver_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ISerializationCallbackReceiver_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ISerializationCallbackReceiver_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ISerializationCallbackReceiver_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ISerializationCallbackReceiver_static v) => new(v);
	}

}
