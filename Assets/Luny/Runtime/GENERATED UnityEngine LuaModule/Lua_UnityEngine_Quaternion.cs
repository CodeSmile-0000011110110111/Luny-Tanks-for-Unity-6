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
	public struct Lua_UnityEngine_Quaternion : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Quaternion" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Quaternion.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion other;
			Lua_UnityEngine_Quaternion other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Quaternion>(out other_UserData))
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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Quaternion.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();

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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Quaternion.Normalize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Normalize();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Quaternion.Set", (_context, _buffer, _) =>
		{
			System.Single newX;
			System.Single newY;
			System.Single newZ;
			System.Single newW;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();

			switch (argCount)
			{
				case 4:
				{
					if (arg1.TryRead<System.Single>(out newX) &&
					    arg2.TryRead<System.Single>(out newY) &&
					    arg3.TryRead<System.Single>(out newZ) &&
					    arg4.TryRead<System.Single>(out newW))
					{
						_this.m_Instance.Set(newX, newY, newZ, newW);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Quaternion.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Quaternion instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "Normalize": return _Normalize;
				case "Set": return _Set;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Quaternion instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Quaternion Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Quaternion v) => new(v);
		public Lua_UnityEngine_Quaternion(UnityEngine.Quaternion instance) { m_Instance = instance; }
		private UnityEngine.Quaternion m_Instance;
		public UnityEngine.Quaternion Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Quaternion Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Quaternion_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Quaternion" };

		private static readonly LuaFunction _Angle = new("UnityEngine.Quaternion.Angle", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Angle(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Quaternion.Dot", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Dot(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Euler = new("UnityEngine.Quaternion.Euler", (_context, _buffer, _) =>
		{
			System.Single x;
			System.Single y;
			System.Single z;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<System.Single>(out x) &&
					    arg1.TryRead<System.Single>(out y) &&
					    arg2.TryRead<System.Single>(out z))
					{
						var returnValue = UnityEngine.Quaternion.Euler(x, y, z);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Inverse = new("UnityEngine.Quaternion.Inverse", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion rotation;
			Lua_UnityEngine_Quaternion rotation_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out rotation_UserData))
					{
						rotation = rotation_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Inverse(rotation);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Quaternion.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Lerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Quaternion.LerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.LerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Quaternion.Normalize", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion q;
			Lua_UnityEngine_Quaternion q_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out q_UserData))
					{
						q = q_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Normalize(q);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RotateTowards = new("UnityEngine.Quaternion.RotateTowards", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion from;
			Lua_UnityEngine_Quaternion from_UserData;
			UnityEngine.Quaternion to;
			Lua_UnityEngine_Quaternion to_UserData;
			System.Single maxDegreesDelta;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out from_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out to_UserData) &&
					    arg2.TryRead<System.Single>(out maxDegreesDelta))
					{
						from = from_UserData.Instance;
						to = to_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.RotateTowards(from, to, maxDegreesDelta);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Slerp = new("UnityEngine.Quaternion.Slerp", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.Slerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SlerpUnclamped = new("UnityEngine.Quaternion.SlerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Quaternion a;
			Lua_UnityEngine_Quaternion a_UserData;
			UnityEngine.Quaternion b;
			Lua_UnityEngine_Quaternion b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Quaternion>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Quaternion>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Quaternion.SlerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Quaternion_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Angle": return _Angle;
				case "Dot": return _Dot;
				case "Euler": return _Euler;
				case "Inverse": return _Inverse;
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				case "Normalize": return _Normalize;
				case "RotateTowards": return _RotateTowards;
				case "Slerp": return _Slerp;
				case "SlerpUnclamped": return _SlerpUnclamped;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Quaternion_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Quaternion_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Quaternion_static v) => new(v);
	}

}
