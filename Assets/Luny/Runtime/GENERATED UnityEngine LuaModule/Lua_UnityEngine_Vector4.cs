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

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector4.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector4.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetHashCode();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector4.Normalize", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.Normalize();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector4.Scale", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var scaleUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var scale = scaleUserData.Instance;
					_this.m_Instance.Scale(scale);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Vector4.Set", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var newX = arg1.Read<System.Single>();
					var newY = arg2.Read<System.Single>();
					var newZ = arg3.Read<System.Single>();
					var newW = arg4.Read<System.Single>();
					_this.m_Instance.Set(newX, newY, newZ, newW);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector4.SqrMagnitude", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.SqrMagnitude();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector4.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ToString();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var format = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.ToString(format);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
	}
	public sealed class Lua_UnityEngine_Vector4_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector4" };

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector4.Distance", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.Distance(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Vector4.Dot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.Dot(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Vector4.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.Lerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Vector4.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.LerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Magnitude = new("UnityEngine.Vector4.Magnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var returnValue = UnityEngine.Vector4.Magnitude(a);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector4.Max", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector4.Max(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector4.Min", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector4.Min(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Vector4.MoveTowards", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var maxDistanceDelta = arg2.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var returnValue = UnityEngine.Vector4.MoveTowards(current, target, maxDistanceDelta);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector4.Normalize", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var returnValue = UnityEngine.Vector4.Normalize(a);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Project = new("UnityEngine.Vector4.Project", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.Project(a, b);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector4.Scale", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector4.Scale(a, b);
					buffer.Span[0] = new Lua_UnityEngine_Vector4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector4.SqrMagnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector4>();
					var a = aUserData.Instance;
					var returnValue = UnityEngine.Vector4.SqrMagnitude(a);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector4_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
