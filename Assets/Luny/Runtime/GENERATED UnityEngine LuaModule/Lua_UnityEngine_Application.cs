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
	public class Lua_UnityEngine_Application : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Application" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Application.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Application>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.Application.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Application>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Application instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Application instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Application>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Application>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Application Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Application v) => new(v);
		public Lua_UnityEngine_Application(UnityEngine.Application instance) { m_Instance = instance; }
		private UnityEngine.Application m_Instance;
		public UnityEngine.Application Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Application_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Application" };

		private static readonly LuaFunction _CanStreamedLevelBeLoaded = new("UnityEngine.Application.CanStreamedLevelBeLoaded", (_context, _buffer, _) =>
		{
			System.String levelName;
			System.Int32 levelIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out levelName))
					{
						var returnValue = UnityEngine.Application.CanStreamedLevelBeLoaded(levelName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg0.TryRead<System.Int32>(out levelIndex))
					{
						var returnValue = UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasProLicense = new("UnityEngine.Application.HasProLicense", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.Application.HasProLicense();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OpenURL = new("UnityEngine.Application.OpenURL", (_context, _buffer, _) =>
		{
			System.String url;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out url))
					{
						UnityEngine.Application.OpenURL(url);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Quit = new("UnityEngine.Application.Quit", (_context, _buffer, _) =>
		{
			System.Int32 exitCode;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.Application.Quit();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg0.TryRead<System.Int32>(out exitCode))
					{
						UnityEngine.Application.Quit(exitCode);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Unload = new("UnityEngine.Application.Unload", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.Application.Unload();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Application_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "CanStreamedLevelBeLoaded": return _CanStreamedLevelBeLoaded;
				case "HasProLicense": return _HasProLicense;
				case "OpenURL": return _OpenURL;
				case "Quit": return _Quit;
				case "Unload": return _Unload;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Application_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Application_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Application_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Application_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Application_static v) => new(v);
	}

}
