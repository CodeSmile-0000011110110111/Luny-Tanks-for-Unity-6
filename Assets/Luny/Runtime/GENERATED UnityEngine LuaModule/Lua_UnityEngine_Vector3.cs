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

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector3.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector3.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector3.Normalize", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3.Scale", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var scaleUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var scale = scaleUserData.Instance;
					_this.m_Instance.Scale(scale);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Vector3.Set", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var newX = arg1.Read<System.Single>();
					var newY = arg2.Read<System.Single>();
					var newZ = arg3.Read<System.Single>();
					_this.m_Instance.Set(newX, newY, newZ);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector3.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
	}
	public sealed class Lua_UnityEngine_Vector3_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3" };

		private static readonly LuaFunction _Angle = new("UnityEngine.Vector3.Angle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var fromUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var toUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var returnValue = UnityEngine.Vector3.Angle(from, to);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _AngleBetween = new("UnityEngine.Vector3.AngleBetween", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var fromUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var toUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var returnValue = UnityEngine.Vector3.AngleBetween(from, to);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ClampMagnitude = new("UnityEngine.Vector3.ClampMagnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var maxLength = arg1.Read<System.Single>();
					var vector = vectorUserData.Instance;
					var returnValue = UnityEngine.Vector3.ClampMagnitude(vector, maxLength);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Cross = new("UnityEngine.Vector3.Cross", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3.Cross(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector3.Distance", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.Distance(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Vector3.Dot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3.Dot(lhs, rhs);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Exclude = new("UnityEngine.Vector3.Exclude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var excludeThisUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var fromThatUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var excludeThis = excludeThisUserData.Instance;
					var fromThat = fromThatUserData.Instance;
					var returnValue = UnityEngine.Vector3.Exclude(excludeThis, fromThat);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Vector3.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.Lerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Vector3.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.LerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Magnitude = new("UnityEngine.Vector3.Magnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var vector = vectorUserData.Instance;
					var returnValue = UnityEngine.Vector3.Magnitude(vector);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector3.Max", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3.Max(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector3.Min", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3.Min(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Vector3.MoveTowards", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var maxDistanceDelta = arg2.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var returnValue = UnityEngine.Vector3.MoveTowards(current, target, maxDistanceDelta);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Vector3.Normalize", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var valueUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var value = valueUserData.Instance;
					var returnValue = UnityEngine.Vector3.Normalize(value);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _OrthoNormalize = new("UnityEngine.Vector3.OrthoNormalize", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var normalUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var tangentUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var binormalUserData = arg2.Read<Lua_UnityEngine_Vector3>();
					var normal = normalUserData.Instance;
					var tangent = tangentUserData.Instance;
					var binormal = binormalUserData.Instance;
					UnityEngine.Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
					normalUserData.Instance = normal;
					tangentUserData.Instance = tangent;
					binormalUserData.Instance = binormal;
					buffer.Span[0] = arg0;
					buffer.Span[1] = arg1;
					buffer.Span[2] = arg2;
					return new ValueTask<Int32>(3);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Project = new("UnityEngine.Vector3.Project", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var onNormalUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var vector = vectorUserData.Instance;
					var onNormal = onNormalUserData.Instance;
					var returnValue = UnityEngine.Vector3.Project(vector, onNormal);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ProjectOnPlane = new("UnityEngine.Vector3.ProjectOnPlane", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var planeNormalUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var vector = vectorUserData.Instance;
					var planeNormal = planeNormalUserData.Instance;
					var returnValue = UnityEngine.Vector3.ProjectOnPlane(vector, planeNormal);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Reflect = new("UnityEngine.Vector3.Reflect", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var inDirectionUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var inNormalUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var inDirection = inDirectionUserData.Instance;
					var inNormal = inNormalUserData.Instance;
					var returnValue = UnityEngine.Vector3.Reflect(inDirection, inNormal);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RotateTowards = new("UnityEngine.Vector3.RotateTowards", (context, buffer, ct) =>
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
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var maxRadiansDelta = arg2.Read<System.Single>();
					var maxMagnitudeDelta = arg3.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var returnValue = UnityEngine.Vector3.RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3.Scale", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.Scale(a, b);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SignedAngle = new("UnityEngine.Vector3.SignedAngle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var fromUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var toUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var axisUserData = arg2.Read<Lua_UnityEngine_Vector3>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var axis = axisUserData.Instance;
					var returnValue = UnityEngine.Vector3.SignedAngle(from, to, axis);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Slerp = new("UnityEngine.Vector3.Slerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.Slerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SlerpUnclamped = new("UnityEngine.Vector3.SlerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3.SlerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SmoothDamp = new("UnityEngine.Vector3.SmoothDamp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 6:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var currentUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var targetUserData = arg1.Read<Lua_UnityEngine_Vector3>();
					var currentVelocityUserData = arg2.Read<Lua_UnityEngine_Vector3>();
					var smoothTime = arg3.Read<System.Single>();
					var maxSpeed = arg4.Read<System.Single>();
					var deltaTime = arg5.Read<System.Single>();
					var current = currentUserData.Instance;
					var target = targetUserData.Instance;
					var currentVelocity = currentVelocityUserData.Instance;
					var returnValue = UnityEngine.Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
					currentVelocityUserData.Instance = currentVelocity;
					buffer.Span[0] = new Lua_UnityEngine_Vector3(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SqrMagnitude = new("UnityEngine.Vector3.SqrMagnitude", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var vectorUserData = arg0.Read<Lua_UnityEngine_Vector3>();
					var vector = vectorUserData.Instance;
					var returnValue = UnityEngine.Vector3.SqrMagnitude(vector);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Angle": return _Angle;
				case "AngleBetween": return _AngleBetween;
				case "ClampMagnitude": return _ClampMagnitude;
				case "Cross": return _Cross;
				case "Distance": return _Distance;
				case "Dot": return _Dot;
				case "Exclude": return _Exclude;
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
