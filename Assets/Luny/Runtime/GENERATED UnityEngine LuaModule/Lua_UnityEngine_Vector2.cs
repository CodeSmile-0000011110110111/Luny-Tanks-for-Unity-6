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
	public struct Lua_UnityEngine_Vector2 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector2" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector2.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector2.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector2.Normalize", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector2.Scale", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var scaleUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var scale = scaleUserData.Instance;
					_this.m_Instance.Scale(scale);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Vector2.Set", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var newX = arg1.Read<System.Single>();
					var newY = arg2.Read<System.Single>();
					_this.m_Instance.Set(newX, newY);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector2.SqrMagnitude", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector2.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector2>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector2 instance, String key, LuaFunctionExecutionContext context)
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

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector2 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector2>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector2>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector2 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector2 v) => new(v);
		public Lua_UnityEngine_Vector2(UnityEngine.Vector2 instance) { m_Instance = instance; }
		private UnityEngine.Vector2 m_Instance;
		public UnityEngine.Vector2 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Vector2 Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Vector2_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector2" };

		private static readonly LuaFunction _Angle = new("UnityEngine.Vector2.Angle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var fromUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var toUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var returnValue = UnityEngine.Vector2.Angle(from, to);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ClampMagnitude = new("UnityEngine.Vector2.ClampMagnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var maxLength = arg1.Read<System.Single>();
					var vector = vectorUserData.Instance;
					var returnValue = UnityEngine.Vector2.ClampMagnitude(vector, maxLength);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector2.Distance", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector2.Distance(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Vector2.Dot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector2.Dot(lhs, rhs);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Vector2.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector2.Lerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Vector2.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector2.LerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector2.Max", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector2.Max(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector2.Min", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector2.Min(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Vector2.MoveTowards", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var maxDistanceDelta = arg2.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var returnValue = UnityEngine.Vector2.MoveTowards(current, target, maxDistanceDelta);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Perpendicular = new("UnityEngine.Vector2.Perpendicular", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var inDirectionUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var inDirection = inDirectionUserData.Instance;
					var returnValue = UnityEngine.Vector2.Perpendicular(inDirection);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Reflect = new("UnityEngine.Vector2.Reflect", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var inDirectionUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var inNormalUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var inDirection = inDirectionUserData.Instance;
					var inNormal = inNormalUserData.Instance;
					var returnValue = UnityEngine.Vector2.Reflect(inDirection, inNormal);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector2.Scale", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector2.Scale(a, b);
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SignedAngle = new("UnityEngine.Vector2.SignedAngle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var fromUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var toUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var returnValue = UnityEngine.Vector2.SignedAngle(from, to);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SmoothDamp = new("UnityEngine.Vector2.SmoothDamp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var currentVelocityUserData = arg2.Read<Lua_UnityEngine_Vector2>();
					var smoothTime = arg3.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var currentVelocity = currentVelocityUserData.Instance;
					var returnValue = UnityEngine.Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime);
					currentVelocityUserData.Instance = currentVelocity;
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				case 5:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var currentVelocityUserData = arg2.Read<Lua_UnityEngine_Vector2>();
					var smoothTime = arg3.Read<System.Single>();
					var maxSpeed = arg4.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var currentVelocity = currentVelocityUserData.Instance;
					var returnValue = UnityEngine.Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);
					currentVelocityUserData.Instance = currentVelocity;
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				case 6:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector2>();
					var currentVelocityUserData = arg2.Read<Lua_UnityEngine_Vector2>();
					var smoothTime = arg3.Read<System.Single>();
					var maxSpeed = arg4.Read<System.Single>();
					var deltaTime = arg5.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var currentVelocity = currentVelocityUserData.Instance;
					var returnValue = UnityEngine.Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
					currentVelocityUserData.Instance = currentVelocity;
					buffer.Span[0] = new Lua_UnityEngine_Vector2(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector2.SqrMagnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector2>();
					var a = aUserData.Instance;
					var returnValue = UnityEngine.Vector2.SqrMagnitude(a);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector2_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Angle": return _Angle;
				case "ClampMagnitude": return _ClampMagnitude;
				case "Distance": return _Distance;
				case "Dot": return _Dot;
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				case "Max": return _Max;
				case "Min": return _Min;
				case "MoveTowards": return _MoveTowards;
				case "Perpendicular": return _Perpendicular;
				case "Reflect": return _Reflect;
				case "Scale": return _Scale;
				case "SignedAngle": return _SignedAngle;
				case "SmoothDamp": return _SmoothDamp;
				case "SqrMagnitude": return _SqrMagnitude;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector2_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector2_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector2_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector2_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector2_static v) => new(v);
	}

}
