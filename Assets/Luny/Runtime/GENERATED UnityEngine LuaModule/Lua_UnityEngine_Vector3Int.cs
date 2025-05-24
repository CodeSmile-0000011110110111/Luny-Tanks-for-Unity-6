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
	public struct Lua_UnityEngine_Vector3Int : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3Int" };

		private static readonly LuaFunction _Clamp = new("UnityEngine.Vector3Int.Clamp", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int min;
			Lua_UnityEngine_Vector3Int min_UserData;
			UnityEngine.Vector3Int max;
			Lua_UnityEngine_Vector3Int max_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector3Int>(out min_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3Int>(out max_UserData))
					{
						min = min_UserData.Instance;
						max = max_UserData.Instance;
						_this.m_Instance.Clamp(min, max);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector3Int.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int other;
			Lua_UnityEngine_Vector3Int other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector3Int>(out other_UserData))
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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector3Int.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3Int.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int scale;
			Lua_UnityEngine_Vector3Int scale_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector3Int>(out scale_UserData))
					{
						scale = scale_UserData.Instance;
						_this.m_Instance.Scale(scale);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Vector3Int.Set", (_context, _buffer, _) =>
		{
			System.Int32 x;
			System.Int32 y;
			System.Int32 z;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out x) &&
					    arg2.TryRead<System.Int32>(out y) &&
					    arg3.TryRead<System.Int32>(out z))
					{
						_this.m_Instance.Set(x, y, z);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector3Int.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3Int instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Clamp": return _Clamp;
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "Scale": return _Scale;
				case "Set": return _Set;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3Int instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3Int Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3Int v) => new(v);
		public Lua_UnityEngine_Vector3Int(UnityEngine.Vector3Int instance) { m_Instance = instance; }
		private UnityEngine.Vector3Int m_Instance;
		public UnityEngine.Vector3Int Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Vector3Int Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Vector3Int_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3Int" };

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector3Int.Distance", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int a;
			Lua_UnityEngine_Vector3Int a_UserData;
			UnityEngine.Vector3Int b;
			Lua_UnityEngine_Vector3Int b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3Int>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3Int>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3Int.Distance(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector3Int.Max", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int lhs;
			Lua_UnityEngine_Vector3Int lhs_UserData;
			UnityEngine.Vector3Int rhs;
			Lua_UnityEngine_Vector3Int rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3Int>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3Int>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3Int.Max(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector3Int.Min", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int lhs;
			Lua_UnityEngine_Vector3Int lhs_UserData;
			UnityEngine.Vector3Int rhs;
			Lua_UnityEngine_Vector3Int rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3Int>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3Int>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3Int.Min(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3Int.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3Int a;
			Lua_UnityEngine_Vector3Int a_UserData;
			UnityEngine.Vector3Int b;
			Lua_UnityEngine_Vector3Int b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3Int>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3Int>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3Int.Scale(a, b);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3Int_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Distance": return _Distance;
				case "Max": return _Max;
				case "Min": return _Min;
				case "Scale": return _Scale;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3Int_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3Int_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3Int_static v) => new(v);
	}

}
