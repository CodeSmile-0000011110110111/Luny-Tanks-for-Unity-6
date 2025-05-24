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
	public struct Lua_UnityEngine_Vector3 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector3.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 other;
			Lua_UnityEngine_Vector3 other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector3>(out other_UserData))
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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector3.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector3.Normalize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 scale;
			Lua_UnityEngine_Vector3 scale_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector3>(out scale_UserData))
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

		private static readonly LuaFunction _Set = new("UnityEngine.Vector3.Set", (_context, _buffer, _) =>
		{
			System.Single newX;
			System.Single newY;
			System.Single newZ;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<System.Single>(out newX) &&
					    arg2.TryRead<System.Single>(out newY) &&
					    arg3.TryRead<System.Single>(out newZ))
					{
						_this.m_Instance.Set(newX, newY, newZ);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector3.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "Normalize": return _Normalize;
				case "Scale": return _Scale;
				case "Set": return _Set;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3 v) => new(v);
		public Lua_UnityEngine_Vector3(UnityEngine.Vector3 instance) { m_Instance = instance; }
		private UnityEngine.Vector3 m_Instance;
		public UnityEngine.Vector3 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Vector3 Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Vector3_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3" };

		private static readonly LuaFunction _Angle = new("UnityEngine.Vector3.Angle", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 from;
			Lua_UnityEngine_Vector3 from_UserData;
			UnityEngine.Vector3 to;
			Lua_UnityEngine_Vector3 to_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out from_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out to_UserData))
					{
						from = from_UserData.Instance;
						to = to_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Angle(from, to);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClampMagnitude = new("UnityEngine.Vector3.ClampMagnitude", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 vector;
			Lua_UnityEngine_Vector3 vector_UserData;
			System.Single maxLength;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out vector_UserData) &&
					    arg1.TryRead<System.Single>(out maxLength))
					{
						vector = vector_UserData.Instance;
						var returnValue = UnityEngine.Vector3.ClampMagnitude(vector, maxLength);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Cross = new("UnityEngine.Vector3.Cross", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 lhs;
			Lua_UnityEngine_Vector3 lhs_UserData;
			UnityEngine.Vector3 rhs;
			Lua_UnityEngine_Vector3 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Cross(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector3.Distance", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Distance(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Vector3.Dot", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 lhs;
			Lua_UnityEngine_Vector3 lhs_UserData;
			UnityEngine.Vector3 rhs;
			Lua_UnityEngine_Vector3 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Dot(lhs, rhs);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Vector3.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Lerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Vector3.LerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.LerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Magnitude = new("UnityEngine.Vector3.Magnitude", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 vector;
			Lua_UnityEngine_Vector3 vector_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out vector_UserData))
					{
						vector = vector_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Magnitude(vector);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector3.Max", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 lhs;
			Lua_UnityEngine_Vector3 lhs_UserData;
			UnityEngine.Vector3 rhs;
			Lua_UnityEngine_Vector3 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Max(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector3.Min", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 lhs;
			Lua_UnityEngine_Vector3 lhs_UserData;
			UnityEngine.Vector3 rhs;
			Lua_UnityEngine_Vector3 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Min(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Vector3.MoveTowards", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 current;
			Lua_UnityEngine_Vector3 current_UserData;
			UnityEngine.Vector3 target;
			Lua_UnityEngine_Vector3 target_UserData;
			System.Single maxDistanceDelta;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out target_UserData) &&
					    arg2.TryRead<System.Single>(out maxDistanceDelta))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						var returnValue = UnityEngine.Vector3.MoveTowards(current, target, maxDistanceDelta);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector3.Normalize", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 value;
			Lua_UnityEngine_Vector3 value_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out value_UserData))
					{
						value = value_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Normalize(value);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OrthoNormalize = new("UnityEngine.Vector3.OrthoNormalize", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 normal;
			Lua_UnityEngine_Vector3 normal_UserData;
			UnityEngine.Vector3 tangent;
			Lua_UnityEngine_Vector3 tangent_UserData;
			UnityEngine.Vector3 binormal;
			Lua_UnityEngine_Vector3 binormal_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out normal_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out tangent_UserData))
					{
						normal = normal_UserData.Instance;
						tangent = tangent_UserData.Instance;
						UnityEngine.Vector3.OrthoNormalize(ref normal, ref tangent);
						normal_UserData.Instance = normal;
						tangent_UserData.Instance = tangent;
						_buffer.Span[0] = arg0;
						_buffer.Span[1] = arg1;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out normal_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out tangent_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3>(out binormal_UserData))
					{
						normal = normal_UserData.Instance;
						tangent = tangent_UserData.Instance;
						binormal = binormal_UserData.Instance;
						UnityEngine.Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
						normal_UserData.Instance = normal;
						tangent_UserData.Instance = tangent;
						binormal_UserData.Instance = binormal;
						_buffer.Span[0] = arg0;
						_buffer.Span[1] = arg1;
						_buffer.Span[2] = arg2;
						return new ValueTask<Int32>(3);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Project = new("UnityEngine.Vector3.Project", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 vector;
			Lua_UnityEngine_Vector3 vector_UserData;
			UnityEngine.Vector3 onNormal;
			Lua_UnityEngine_Vector3 onNormal_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out vector_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out onNormal_UserData))
					{
						vector = vector_UserData.Instance;
						onNormal = onNormal_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Project(vector, onNormal);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ProjectOnPlane = new("UnityEngine.Vector3.ProjectOnPlane", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 vector;
			Lua_UnityEngine_Vector3 vector_UserData;
			UnityEngine.Vector3 planeNormal;
			Lua_UnityEngine_Vector3 planeNormal_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out vector_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out planeNormal_UserData))
					{
						vector = vector_UserData.Instance;
						planeNormal = planeNormal_UserData.Instance;
						var returnValue = UnityEngine.Vector3.ProjectOnPlane(vector, planeNormal);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Reflect = new("UnityEngine.Vector3.Reflect", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 inDirection;
			Lua_UnityEngine_Vector3 inDirection_UserData;
			UnityEngine.Vector3 inNormal;
			Lua_UnityEngine_Vector3 inNormal_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out inDirection_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out inNormal_UserData))
					{
						inDirection = inDirection_UserData.Instance;
						inNormal = inNormal_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Reflect(inDirection, inNormal);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RotateTowards = new("UnityEngine.Vector3.RotateTowards", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 current;
			Lua_UnityEngine_Vector3 current_UserData;
			UnityEngine.Vector3 target;
			Lua_UnityEngine_Vector3 target_UserData;
			System.Single maxRadiansDelta;
			System.Single maxMagnitudeDelta;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 4:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out target_UserData) &&
					    arg2.TryRead<System.Single>(out maxRadiansDelta) &&
					    arg3.TryRead<System.Single>(out maxMagnitudeDelta))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						var returnValue = UnityEngine.Vector3.RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Scale(a, b);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SignedAngle = new("UnityEngine.Vector3.SignedAngle", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 from;
			Lua_UnityEngine_Vector3 from_UserData;
			UnityEngine.Vector3 to;
			Lua_UnityEngine_Vector3 to_UserData;
			UnityEngine.Vector3 axis;
			Lua_UnityEngine_Vector3 axis_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out from_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out to_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3>(out axis_UserData))
					{
						from = from_UserData.Instance;
						to = to_UserData.Instance;
						axis = axis_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SignedAngle(from, to, axis);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Slerp = new("UnityEngine.Vector3.Slerp", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.Slerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SlerpUnclamped = new("UnityEngine.Vector3.SlerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 a;
			Lua_UnityEngine_Vector3 a_UserData;
			UnityEngine.Vector3 b;
			Lua_UnityEngine_Vector3 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SlerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SmoothDamp = new("UnityEngine.Vector3.SmoothDamp", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 current;
			Lua_UnityEngine_Vector3 current_UserData;
			UnityEngine.Vector3 target;
			Lua_UnityEngine_Vector3 target_UserData;
			UnityEngine.Vector3 currentVelocity;
			Lua_UnityEngine_Vector3 currentVelocity_UserData;
			System.Single smoothTime;
			System.Single maxSpeed;
			System.Single deltaTime;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;

			switch (argCount)
			{
				case 5:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out target_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3>(out currentVelocity_UserData) &&
					    arg3.TryRead<System.Single>(out smoothTime) &&
					    arg4.TryRead<System.Single>(out maxSpeed))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						currentVelocity = currentVelocity_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);
						currentVelocity_UserData.Instance = currentVelocity;
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						_buffer.Span[1] = arg2;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out target_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3>(out currentVelocity_UserData) &&
					    arg3.TryRead<System.Single>(out smoothTime))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						currentVelocity = currentVelocity_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime);
						currentVelocity_UserData.Instance = currentVelocity;
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						_buffer.Span[1] = arg2;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 6:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector3>(out target_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Vector3>(out currentVelocity_UserData) &&
					    arg3.TryRead<System.Single>(out smoothTime) &&
					    arg4.TryRead<System.Single>(out maxSpeed) &&
					    arg5.TryRead<System.Single>(out deltaTime))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						currentVelocity = currentVelocity_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
						currentVelocity_UserData.Instance = currentVelocity;
						_buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
						_buffer.Span[1] = arg2;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector3.SqrMagnitude", (_context, _buffer, _) =>
		{
			UnityEngine.Vector3 vector;
			Lua_UnityEngine_Vector3 vector_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector3>(out vector_UserData))
					{
						vector = vector_UserData.Instance;
						var returnValue = UnityEngine.Vector3.SqrMagnitude(vector);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Angle": return _Angle;
				case "ClampMagnitude": return _ClampMagnitude;
				case "Cross": return _Cross;
				case "Distance": return _Distance;
				case "Dot": return _Dot;
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				case "Magnitude": return _Magnitude;
				case "Max": return _Max;
				case "Min": return _Min;
				case "MoveTowards": return _MoveTowards;
				case "Normalize": return _Normalize;
				case "OrthoNormalize": return _OrthoNormalize;
				case "Project": return _Project;
				case "ProjectOnPlane": return _ProjectOnPlane;
				case "Reflect": return _Reflect;
				case "RotateTowards": return _RotateTowards;
				case "Scale": return _Scale;
				case "SignedAngle": return _SignedAngle;
				case "Slerp": return _Slerp;
				case "SlerpUnclamped": return _SlerpUnclamped;
				case "SmoothDamp": return _SmoothDamp;
				case "SqrMagnitude": return _SqrMagnitude;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3_static v) => new(v);
	}

}
