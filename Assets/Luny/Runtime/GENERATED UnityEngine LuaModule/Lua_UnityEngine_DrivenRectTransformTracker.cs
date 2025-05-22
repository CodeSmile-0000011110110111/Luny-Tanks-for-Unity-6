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
	public struct Lua_UnityEngine_DrivenRectTransformTracker : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "DrivenRectTransformTracker" };

		private static readonly LuaFunction _Clear = new("UnityEngine.DrivenRectTransformTracker.Clear", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_DrivenRectTransformTracker>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.Clear();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.DrivenRectTransformTracker.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_DrivenRectTransformTracker>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.DrivenRectTransformTracker.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_DrivenRectTransformTracker>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_DrivenRectTransformTracker instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Clear": return _Clear;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_DrivenRectTransformTracker instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_DrivenRectTransformTracker>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_DrivenRectTransformTracker>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_DrivenRectTransformTracker Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_DrivenRectTransformTracker v) => new(v);
		public Lua_UnityEngine_DrivenRectTransformTracker(UnityEngine.DrivenRectTransformTracker instance) { m_Instance = instance; }
		private UnityEngine.DrivenRectTransformTracker m_Instance;
		public UnityEngine.DrivenRectTransformTracker Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.DrivenRectTransformTracker Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_DrivenRectTransformTracker_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "DrivenRectTransformTracker" };

		private static readonly LuaFunction _StartRecordingUndo = new("UnityEngine.DrivenRectTransformTracker.StartRecordingUndo", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.DrivenRectTransformTracker.StartRecordingUndo();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _StopRecordingUndo = new("UnityEngine.DrivenRectTransformTracker.StopRecordingUndo", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.DrivenRectTransformTracker.StopRecordingUndo();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_DrivenRectTransformTracker_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "StartRecordingUndo": return _StartRecordingUndo;
				case "StopRecordingUndo": return _StopRecordingUndo;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_DrivenRectTransformTracker_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_DrivenRectTransformTracker_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_DrivenRectTransformTracker_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_DrivenRectTransformTracker_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_DrivenRectTransformTracker_static v) => new(v);
	}

}
