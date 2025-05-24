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
	public struct Lua_UnityEngine_Hash128 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Hash128" };

		private static readonly LuaFunction _Append = new("UnityEngine.Hash128.Append", (_context, _buffer, _) =>
		{
			System.Single val;
			System.String data;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Hash128>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out val))
					{
						_this.m_Instance.Append(val);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out data))
					{
						_this.m_Instance.Append(data);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CompareTo = new("UnityEngine.Hash128.CompareTo", (_context, _buffer, _) =>
		{
			UnityEngine.Hash128 rhs;
			Lua_UnityEngine_Hash128 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Hash128>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Hash128>(out rhs_UserData))
					{
						rhs = rhs_UserData.Instance;
						var returnValue = _this.m_Instance.CompareTo(rhs);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Equals = new("UnityEngine.Hash128.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Hash128 obj;
			Lua_UnityEngine_Hash128 obj_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Hash128>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Hash128>(out obj_UserData))
					{
						obj = obj_UserData.Instance;
						var returnValue = _this.m_Instance.Equals(obj);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Hash128.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Hash128>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.Hash128.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Hash128>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Hash128 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Append": return _Append;
				case "CompareTo": return _CompareTo;
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Hash128 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Hash128>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Hash128>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Hash128 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Hash128 v) => new(v);
		public Lua_UnityEngine_Hash128(UnityEngine.Hash128 instance) { m_Instance = instance; }
		private UnityEngine.Hash128 m_Instance;
		public UnityEngine.Hash128 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Hash128 Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Hash128_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Hash128" };

		private static readonly LuaFunction _Compute = new("UnityEngine.Hash128.Compute", (_context, _buffer, _) =>
		{
			System.Single val;
			System.String data;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.Single>(out val))
					{
						var returnValue = UnityEngine.Hash128.Compute(val);
						_buffer.Span[0] = new Lua_UnityEngine_Hash128(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg0.TryRead<System.String>(out data))
					{
						var returnValue = UnityEngine.Hash128.Compute(data);
						_buffer.Span[0] = new Lua_UnityEngine_Hash128(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Parse = new("UnityEngine.Hash128.Parse", (_context, _buffer, _) =>
		{
			System.String hashString;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out hashString))
					{
						var returnValue = UnityEngine.Hash128.Parse(hashString);
						_buffer.Span[0] = new Lua_UnityEngine_Hash128(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Hash128_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Compute": return _Compute;
				case "Parse": return _Parse;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Hash128_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Hash128_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Hash128_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Hash128_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Hash128_static v) => new(v);
	}

}
