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
	public class Lua_UnityEngine_AudioSettings : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioSettings" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.AudioSettings.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSettings>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetHashCode();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.AudioSettings.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSettings>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.ToString();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioSettings instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioSettings instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSettings>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSettings>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioSettings Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioSettings v) => new(v);
		public Lua_UnityEngine_AudioSettings(UnityEngine.AudioSettings instance) { m_Instance = instance; }
		private UnityEngine.AudioSettings m_Instance;
		public UnityEngine.AudioSettings Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_AudioSettings_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioSettings" };

		private static readonly LuaFunction _GetDSPBufferSize = new("UnityEngine.AudioSettings.GetDSPBufferSize", (_context, _buffer, _) =>
		{
			System.Int32 bufferLength;
			System.Int32 numBuffers;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out bufferLength) &&
					    arg1.TryRead<System.Int32>(out numBuffers))
					{
						UnityEngine.AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);
						_buffer.Span[0] = arg0;
						_buffer.Span[1] = arg1;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetSpatializerPluginName = new("UnityEngine.AudioSettings.GetSpatializerPluginName", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.AudioSettings.GetSpatializerPluginName();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetSpatializerPluginName = new("UnityEngine.AudioSettings.SetSpatializerPluginName", (_context, _buffer, _) =>
		{
			System.String pluginName;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out pluginName))
					{
						UnityEngine.AudioSettings.SetSpatializerPluginName(pluginName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioSettings_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetDSPBufferSize": return _GetDSPBufferSize;
				case "GetSpatializerPluginName": return _GetSpatializerPluginName;
				case "SetSpatializerPluginName": return _SetSpatializerPluginName;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioSettings_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSettings_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSettings_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioSettings_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioSettings_static v) => new(v);
	}

}
