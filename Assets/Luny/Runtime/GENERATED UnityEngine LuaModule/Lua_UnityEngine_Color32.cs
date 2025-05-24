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
	public struct Lua_UnityEngine_Color32 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Color32" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Color32.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Color32 other;
			Lua_UnityEngine_Color32 other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Color32>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Color32>(out other_UserData))
					{
						other = other_UserData.Instance;
						var returnValue = _this.m_Instance.Equals(other);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Color32.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Color32>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.Color32.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Color32>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.ToString();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				case 1:
				{
					if (arg1.TryRead<System.String>(out format))
					{
						var returnValue = _this.m_Instance.ToString(format);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Color32 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Color32 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color32>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color32>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Color32 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Color32 v) => new(v);
		public Lua_UnityEngine_Color32(UnityEngine.Color32 instance) { m_Instance = instance; }
		private UnityEngine.Color32 m_Instance;
		public UnityEngine.Color32 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Color32 Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Color32_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Color32" };

		private static readonly LuaFunction _Lerp = new("UnityEngine.Color32.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Color32 a;
			Lua_UnityEngine_Color32 a_UserData;
			UnityEngine.Color32 b;
			Lua_UnityEngine_Color32 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Color32>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Color32>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Color32.Lerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Color32(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Color32.LerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Color32 a;
			Lua_UnityEngine_Color32 a_UserData;
			UnityEngine.Color32 b;
			Lua_UnityEngine_Color32 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Color32>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Color32>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Color32.LerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Color32(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Color32_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Color32_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color32_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color32_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Color32_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Color32_static v) => new(v);
	}

}
