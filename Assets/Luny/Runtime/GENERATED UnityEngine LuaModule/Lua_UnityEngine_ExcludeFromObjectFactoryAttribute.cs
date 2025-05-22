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
	public class Lua_UnityEngine_ExcludeFromObjectFactoryAttribute : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ExcludeFromObjectFactoryAttribute" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ExcludeFromObjectFactoryAttribute.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute>();
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

		private static readonly LuaFunction _IsDefaultAttribute = new("UnityEngine.ExcludeFromObjectFactoryAttribute.IsDefaultAttribute", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.IsDefaultAttribute();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ExcludeFromObjectFactoryAttribute.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ToString();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "IsDefaultAttribute": return _IsDefaultAttribute;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ExcludeFromObjectFactoryAttribute Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute v) => new(v);
		public Lua_UnityEngine_ExcludeFromObjectFactoryAttribute(UnityEngine.ExcludeFromObjectFactoryAttribute instance) { m_Instance = instance; }
		private UnityEngine.ExcludeFromObjectFactoryAttribute m_Instance;
		public UnityEngine.ExcludeFromObjectFactoryAttribute Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ExcludeFromObjectFactoryAttribute" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ExcludeFromObjectFactoryAttribute_static v) => new(v);
	}

}
