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
	public class Lua_UnityEngine_AudioClip : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioClip" };

		private static readonly LuaFunction _GetData = new("UnityEngine.AudioClip.GetData", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var data = arg1.Read<System.Single>();
					var offsetSamples = arg2.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetData(data, offsetSamples);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.AudioClip.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.AudioClip.GetInstanceID", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetInstanceID();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LoadAudioData = new("UnityEngine.AudioClip.LoadAudioData", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.LoadAudioData();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetData = new("UnityEngine.AudioClip.SetData", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var data = arg1.Read<System.Single>();
					var offsetSamples = arg2.Read<System.Int32>();
					var returnValue = _this.m_Instance.SetData(data, offsetSamples);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.AudioClip.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
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

		private static readonly LuaFunction _UnloadAudioData = new("UnityEngine.AudioClip.UnloadAudioData", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioClip>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.UnloadAudioData();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioClip instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetData": return _GetData;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "LoadAudioData": return _LoadAudioData;
				case "SetData": return _SetData;
				case "ToString": return _ToString;
				case "UnloadAudioData": return _UnloadAudioData;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioClip instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioClip>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioClip>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioClip Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioClip v) => new(v);
		public Lua_UnityEngine_AudioClip(UnityEngine.AudioClip instance) { m_Instance = instance; }
		private UnityEngine.AudioClip m_Instance;
		public UnityEngine.AudioClip Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_AudioClip_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioClip" };

		private static readonly LuaFunction _Create = new("UnityEngine.AudioClip.Create", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 5:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var name = arg0.Read<System.String>();
					var lengthSamples = arg1.Read<System.Int32>();
					var channels = arg2.Read<System.Int32>();
					var frequency = arg3.Read<System.Int32>();
					var stream = arg4.Read<System.Boolean>();
					var returnValue = UnityEngine.AudioClip.Create(name, lengthSamples, channels, frequency, stream);
					buffer.Span[0] = new Lua_UnityEngine_AudioClip(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioClip_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Create": return _Create;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioClip_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioClip_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioClip_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioClip_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioClip_static v) => new(v);
	}

}
