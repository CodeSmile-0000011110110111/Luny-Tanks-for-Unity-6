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
	public struct Lua_UnityEngine_Vector4 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector4" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector4.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 other;
			Lua_UnityEngine_Vector4 other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector4>(out other_UserData))
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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector4.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector4.Normalize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector4.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 scale;
			Lua_UnityEngine_Vector4 scale_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Vector4>(out scale_UserData))
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

		private static readonly LuaFunction _Set = new("UnityEngine.Vector4.Set", (_context, _buffer, _) =>
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
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

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

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector4.SqrMagnitude", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.SqrMagnitude();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector4.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector4 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "Normalize": return _Normalize;
				case "Scale": return _Scale;
				case "Set": return _Set;
				case "SqrMagnitude": return _SqrMagnitude;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector4 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector4 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector4 v) => new(v);
		public Lua_UnityEngine_Vector4(UnityEngine.Vector4 instance) { m_Instance = instance; }
		private UnityEngine.Vector4 m_Instance;
		public UnityEngine.Vector4 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Vector4 Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Vector4_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector4" };

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector4.Distance", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Distance(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Vector4.Dot", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Dot(a, b);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Vector4.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Lerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Vector4.LerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.LerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Magnitude = new("UnityEngine.Vector4.Magnitude", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData))
					{
						a = a_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Magnitude(a);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector4.Max", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 lhs;
			Lua_UnityEngine_Vector4 lhs_UserData;
			UnityEngine.Vector4 rhs;
			Lua_UnityEngine_Vector4 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Max(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector4.Min", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 lhs;
			Lua_UnityEngine_Vector4 lhs_UserData;
			UnityEngine.Vector4 rhs;
			Lua_UnityEngine_Vector4 rhs_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out lhs_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out rhs_UserData))
					{
						lhs = lhs_UserData.Instance;
						rhs = rhs_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Min(lhs, rhs);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Vector4.MoveTowards", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 current;
			Lua_UnityEngine_Vector4 current_UserData;
			UnityEngine.Vector4 target;
			Lua_UnityEngine_Vector4 target_UserData;
			System.Single maxDistanceDelta;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out current_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out target_UserData) &&
					    arg2.TryRead<System.Single>(out maxDistanceDelta))
					{
						current = current_UserData.Instance;
						target = target_UserData.Instance;
						var returnValue = UnityEngine.Vector4.MoveTowards(current, target, maxDistanceDelta);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector4.Normalize", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData))
					{
						a = a_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Normalize(a);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Project = new("UnityEngine.Vector4.Project", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Project(a, b);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector4.Scale", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;
			UnityEngine.Vector4 b;
			Lua_UnityEngine_Vector4 b_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Vector4>(out b_UserData))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Vector4.Scale(a, b);
						_buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector4.SqrMagnitude", (_context, _buffer, _) =>
		{
			UnityEngine.Vector4 a;
			Lua_UnityEngine_Vector4 a_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Vector4>(out a_UserData))
					{
						a = a_UserData.Instance;
						var returnValue = UnityEngine.Vector4.SqrMagnitude(a);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector4_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Distance": return _Distance;
				case "Dot": return _Dot;
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				case "Magnitude": return _Magnitude;
				case "Max": return _Max;
				case "Min": return _Min;
				case "MoveTowards": return _MoveTowards;
				case "Normalize": return _Normalize;
				case "Project": return _Project;
				case "Scale": return _Scale;
				case "SqrMagnitude": return _SqrMagnitude;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector4_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector4_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector4_static v) => new(v);
	}

}
