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
	public sealed class true_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "FrameTimingManager" };

		private static readonly LuaFunction _CaptureFrameTimings = new("UnityEngine.FrameTimingManager.CaptureFrameTimings", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.FrameTimingManager.CaptureFrameTimings();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetCpuTimerFrequency = new("UnityEngine.FrameTimingManager.GetCpuTimerFrequency", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = UnityEngine.FrameTimingManager.GetCpuTimerFrequency();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetGpuTimerFrequency = new("UnityEngine.FrameTimingManager.GetGpuTimerFrequency", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = UnityEngine.FrameTimingManager.GetGpuTimerFrequency();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetVSyncsPerSecond = new("UnityEngine.FrameTimingManager.GetVSyncsPerSecond", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = UnityEngine.FrameTimingManager.GetVSyncsPerSecond();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsFeatureEnabled = new("UnityEngine.FrameTimingManager.IsFeatureEnabled", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = UnityEngine.FrameTimingManager.IsFeatureEnabled();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(true_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "CaptureFrameTimings": return _CaptureFrameTimings;
				case "GetCpuTimerFrequency": return _GetCpuTimerFrequency;
				case "GetGpuTimerFrequency": return _GetGpuTimerFrequency;
				case "GetVSyncsPerSecond": return _GetVSyncsPerSecond;
				case "IsFeatureEnabled": return _IsFeatureEnabled;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(true_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<true_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<true_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("true_static Metatable not assignable");
		}

		public static implicit operator LuaValue(true_static v) => new(v);
	}

}
