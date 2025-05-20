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
	public struct Lua_UnityEngine_BoundsInt : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "BoundsInt" };

		private static readonly LuaFunction _ClampToBounds = new("UnityEngine.BoundsInt.ClampToBounds", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_BoundsInt>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var boundsUserData = arg1.Read<Lua_UnityEngine_BoundsInt>();
					var bounds = boundsUserData.Instance;
					_this.m_Instance.ClampToBounds(bounds);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Equals = new("UnityEngine.BoundsInt.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_BoundsInt>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_BoundsInt>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.BoundsInt.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_BoundsInt>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetHashCode();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.BoundsInt.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_BoundsInt>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ToString();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var format = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.ToString(format);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_BoundsInt instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ClampToBounds": return _ClampToBounds;
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_BoundsInt instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_BoundsInt>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_BoundsInt>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_BoundsInt Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_BoundsInt v) => new(v);
		public Lua_UnityEngine_BoundsInt(UnityEngine.BoundsInt instance) { m_Instance = instance; }
		private UnityEngine.BoundsInt m_Instance;
		public UnityEngine.BoundsInt Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.BoundsInt Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_BoundsInt_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "BoundsInt" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_BoundsInt_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_BoundsInt_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_BoundsInt_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_BoundsInt_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_BoundsInt_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_BoundsInt_static v) => new(v);
	}

}
