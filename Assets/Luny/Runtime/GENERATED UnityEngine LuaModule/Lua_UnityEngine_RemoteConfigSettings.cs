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
	public class Lua_UnityEngine_RemoteConfigSettings : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RemoteConfigSettings" };

		private static readonly LuaFunction _Dispose = new("UnityEngine.RemoteConfigSettings.Dispose", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Dispose();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ForceUpdate = new("UnityEngine.RemoteConfigSettings.ForceUpdate", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ForceUpdate();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBool = new("UnityEngine.RemoteConfigSettings.GetBool", (_context, _buffer, _) =>
		{
			System.String key;
			System.Boolean defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.GetBool(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out key) &&
					    arg2.TryRead<System.Boolean>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetBool(key, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetCount = new("UnityEngine.RemoteConfigSettings.GetCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetCount();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetFloat = new("UnityEngine.RemoteConfigSettings.GetFloat", (_context, _buffer, _) =>
		{
			System.String key;
			System.Single defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.GetFloat(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out key) &&
					    arg2.TryRead<System.Single>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetFloat(key, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.RemoteConfigSettings.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

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

		private static readonly LuaFunction _GetInt = new("UnityEngine.RemoteConfigSettings.GetInt", (_context, _buffer, _) =>
		{
			System.String key;
			System.Int32 defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.GetInt(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out key) &&
					    arg2.TryRead<System.Int32>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetInt(key, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetLong = new("UnityEngine.RemoteConfigSettings.GetLong", (_context, _buffer, _) =>
		{
			System.String key;
			System.Int64 defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.GetLong(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out key) &&
					    arg2.TryRead<System.Int64>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetLong(key, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetString = new("UnityEngine.RemoteConfigSettings.GetString", (_context, _buffer, _) =>
		{
			System.String key;
			System.String defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.GetString(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out key) &&
					    arg2.TryRead<System.String>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetString(key, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasKey = new("UnityEngine.RemoteConfigSettings.HasKey", (_context, _buffer, _) =>
		{
			System.String key;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out key))
					{
						var returnValue = _this.m_Instance.HasKey(key);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.RemoteConfigSettings.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

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

		private static readonly LuaFunction _WasLastUpdatedFromServer = new("UnityEngine.RemoteConfigSettings.WasLastUpdatedFromServer", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RemoteConfigSettings>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.WasLastUpdatedFromServer();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_RemoteConfigSettings instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Dispose": return _Dispose;
				case "ForceUpdate": return _ForceUpdate;
				case "GetBool": return _GetBool;
				case "GetCount": return _GetCount;
				case "GetFloat": return _GetFloat;
				case "GetHashCode": return _GetHashCode;
				case "GetInt": return _GetInt;
				case "GetLong": return _GetLong;
				case "GetString": return _GetString;
				case "HasKey": return _HasKey;
				case "ToString": return _ToString;
				case "WasLastUpdatedFromServer": return _WasLastUpdatedFromServer;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RemoteConfigSettings instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RemoteConfigSettings>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RemoteConfigSettings>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RemoteConfigSettings Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RemoteConfigSettings v) => new(v);
		public Lua_UnityEngine_RemoteConfigSettings(UnityEngine.RemoteConfigSettings instance) { m_Instance = instance; }
		private UnityEngine.RemoteConfigSettings m_Instance;
		public UnityEngine.RemoteConfigSettings Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_RemoteConfigSettings_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RemoteConfigSettings" };

		private static readonly LuaFunction _AddSessionTag = new("UnityEngine.RemoteConfigSettings.AddSessionTag", (_context, _buffer, _) =>
		{
			System.String tag;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out tag))
					{
						UnityEngine.RemoteConfigSettings.AddSessionTag(tag);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendDeviceInfoInConfigRequest = new("UnityEngine.RemoteConfigSettings.SendDeviceInfoInConfigRequest", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.RemoteConfigSettings.SendDeviceInfoInConfigRequest();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_RemoteConfigSettings_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "AddSessionTag": return _AddSessionTag;
				case "SendDeviceInfoInConfigRequest": return _SendDeviceInfoInConfigRequest;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RemoteConfigSettings_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RemoteConfigSettings_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RemoteConfigSettings_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RemoteConfigSettings_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RemoteConfigSettings_static v) => new(v);
	}

}
