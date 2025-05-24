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
	public class Lua_UnityEngine_AnimationCurve : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AnimationCurve" };

		private static readonly LuaFunction _AddKey = new("UnityEngine.AnimationCurve.AddKey", (_context, _buffer, _) =>
		{
			System.Single time;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Single>(out time) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = _this.m_Instance.AddKey(time, value);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClearKeys = new("UnityEngine.AnimationCurve.ClearKeys", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearKeys();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CopyFrom = new("UnityEngine.AnimationCurve.CopyFrom", (_context, _buffer, _) =>
		{
			UnityEngine.AnimationCurve other;
			Lua_UnityEngine_AnimationCurve other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_AnimationCurve>(out other_UserData))
					{
						other = other_UserData.Instance;
						_this.m_Instance.CopyFrom(other);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Equals = new("UnityEngine.AnimationCurve.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.AnimationCurve other;
			Lua_UnityEngine_AnimationCurve other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_AnimationCurve>(out other_UserData))
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

		private static readonly LuaFunction _Evaluate = new("UnityEngine.AnimationCurve.Evaluate", (_context, _buffer, _) =>
		{
			System.Single time;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out time))
					{
						var returnValue = _this.m_Instance.Evaluate(time);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.AnimationCurve.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

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

		private static readonly LuaFunction _RemoveKey = new("UnityEngine.AnimationCurve.RemoveKey", (_context, _buffer, _) =>
		{
			System.Int32 index;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out index))
					{
						_this.m_Instance.RemoveKey(index);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SmoothTangents = new("UnityEngine.AnimationCurve.SmoothTangents", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Single weight;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out index) &&
					    arg2.TryRead<System.Single>(out weight))
					{
						_this.m_Instance.SmoothTangents(index, weight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.AnimationCurve.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AnimationCurve>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_AnimationCurve instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "AddKey": return _AddKey;
				case "ClearKeys": return _ClearKeys;
				case "CopyFrom": return _CopyFrom;
				case "Equals": return _Equals;
				case "Evaluate": return _Evaluate;
				case "GetHashCode": return _GetHashCode;
				case "RemoveKey": return _RemoveKey;
				case "SmoothTangents": return _SmoothTangents;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AnimationCurve instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AnimationCurve>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AnimationCurve>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AnimationCurve Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AnimationCurve v) => new(v);
		public Lua_UnityEngine_AnimationCurve(UnityEngine.AnimationCurve instance) { m_Instance = instance; }
		private UnityEngine.AnimationCurve m_Instance;
		public UnityEngine.AnimationCurve Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_AnimationCurve_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AnimationCurve" };

		private static readonly LuaFunction _Constant = new("UnityEngine.AnimationCurve.Constant", (_context, _buffer, _) =>
		{
			System.Single timeStart;
			System.Single timeEnd;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<System.Single>(out timeStart) &&
					    arg1.TryRead<System.Single>(out timeEnd) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = UnityEngine.AnimationCurve.Constant(timeStart, timeEnd, value);
						_buffer.Span[0] = new Lua_UnityEngine_AnimationCurve(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _EaseInOut = new("UnityEngine.AnimationCurve.EaseInOut", (_context, _buffer, _) =>
		{
			System.Single timeStart;
			System.Single valueStart;
			System.Single timeEnd;
			System.Single valueEnd;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 4:
				{
					if (arg0.TryRead<System.Single>(out timeStart) &&
					    arg1.TryRead<System.Single>(out valueStart) &&
					    arg2.TryRead<System.Single>(out timeEnd) &&
					    arg3.TryRead<System.Single>(out valueEnd))
					{
						var returnValue = UnityEngine.AnimationCurve.EaseInOut(timeStart, valueStart, timeEnd, valueEnd);
						_buffer.Span[0] = new Lua_UnityEngine_AnimationCurve(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Linear = new("UnityEngine.AnimationCurve.Linear", (_context, _buffer, _) =>
		{
			System.Single timeStart;
			System.Single valueStart;
			System.Single timeEnd;
			System.Single valueEnd;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 4:
				{
					if (arg0.TryRead<System.Single>(out timeStart) &&
					    arg1.TryRead<System.Single>(out valueStart) &&
					    arg2.TryRead<System.Single>(out timeEnd) &&
					    arg3.TryRead<System.Single>(out valueEnd))
					{
						var returnValue = UnityEngine.AnimationCurve.Linear(timeStart, valueStart, timeEnd, valueEnd);
						_buffer.Span[0] = new Lua_UnityEngine_AnimationCurve(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AnimationCurve_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Constant": return _Constant;
				case "EaseInOut": return _EaseInOut;
				case "Linear": return _Linear;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AnimationCurve_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AnimationCurve_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AnimationCurve_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AnimationCurve_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AnimationCurve_static v) => new(v);
	}

}
