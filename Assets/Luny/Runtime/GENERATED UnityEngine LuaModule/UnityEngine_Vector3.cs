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
	public struct UnityEngine_Vector3 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3" };

		internal static LuaValue TryGetValue(UnityEngine_Vector3 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(UnityEngine_Vector3 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<UnityEngine_Vector3>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<UnityEngine_Vector3>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("UnityEngine_Vector3 Metatable not assignable");
		}

		public static implicit operator LuaValue(UnityEngine_Vector3 v) => new(v);
		public UnityEngine_Vector3(UnityEngine.Vector3 instance) { m_Instance = instance; }
		private UnityEngine.Vector3 m_Instance;
		public UnityEngine.Vector3 Value => m_Instance;
	}
	public sealed class UnityEngine_Vector3_static : ILuaUserData
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
					var from = arg0.Read<UnityEngine.Vector3>();
					var to = arg1.Read<UnityEngine.Vector3>();
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
					var from = arg0.Read<UnityEngine.Vector3>();
					var to = arg1.Read<UnityEngine.Vector3>();
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
					var vector = arg0.Read<UnityEngine.Vector3>();
					var maxLength = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.ClampMagnitude(vector, maxLength);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var lhs = arg0.Read<UnityEngine.Vector3>();
					var rhs = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Cross(lhs, rhs);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
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
					var lhs = arg0.Read<UnityEngine.Vector3>();
					var rhs = arg1.Read<UnityEngine.Vector3>();
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
					var excludeThis = arg0.Read<UnityEngine.Vector3>();
					var fromThat = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Exclude(excludeThis, fromThat);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.Lerp(a, b, t);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.LerpUnclamped(a, b, t);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var vector = arg0.Read<UnityEngine.Vector3>();
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
					var lhs = arg0.Read<UnityEngine.Vector3>();
					var rhs = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Max(lhs, rhs);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var lhs = arg0.Read<UnityEngine.Vector3>();
					var rhs = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Min(lhs, rhs);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var current = arg0.Read<UnityEngine.Vector3>();
					var target = arg1.Read<UnityEngine.Vector3>();
					var maxDistanceDelta = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.MoveTowards(current, target, maxDistanceDelta);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var value = arg0.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Normalize(value);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
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
					var vector = arg0.Read<UnityEngine.Vector3>();
					var onNormal = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Project(vector, onNormal);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var vector = arg0.Read<UnityEngine.Vector3>();
					var planeNormal = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.ProjectOnPlane(vector, planeNormal);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var inDirection = arg0.Read<UnityEngine.Vector3>();
					var inNormal = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Reflect(inDirection, inNormal);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var current = arg0.Read<UnityEngine.Vector3>();
					var target = arg1.Read<UnityEngine.Vector3>();
					var maxRadiansDelta = arg2.Read<System.Single>();
					var maxMagnitudeDelta = arg3.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.RotateTowards(current, target, maxRadiansDelta, maxMagnitudeDelta);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.Scale(a, b);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var from = arg0.Read<UnityEngine.Vector3>();
					var to = arg1.Read<UnityEngine.Vector3>();
					var axis = arg2.Read<UnityEngine.Vector3>();
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.Slerp(a, b, t);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
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
					var a = arg0.Read<UnityEngine.Vector3>();
					var b = arg1.Read<UnityEngine.Vector3>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Vector3.SlerpUnclamped(a, b, t);
					buffer.Span[0] = new UnityEngine_Vector3(returnValue);
					return new ValueTask<Int32>(1);
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
					var vector = arg0.Read<UnityEngine.Vector3>();
					var returnValue = UnityEngine.Vector3.SqrMagnitude(vector);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(UnityEngine_Vector3_static instance, String key, LuaFunctionExecutionContext context)
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
				case "Project": return _Project;
				case "ProjectOnPlane": return _ProjectOnPlane;
				case "Reflect": return _Reflect;
				case "RotateTowards": return _RotateTowards;
				case "Scale": return _Scale;
				case "SignedAngle": return _SignedAngle;
				case "Slerp": return _Slerp;
				case "SlerpUnclamped": return _SlerpUnclamped;
				case "SqrMagnitude": return _SqrMagnitude;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(UnityEngine_Vector3_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<UnityEngine_Vector3_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<UnityEngine_Vector3_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("UnityEngine_Vector3_static Metatable not assignable");
		}

		public static implicit operator LuaValue(UnityEngine_Vector3_static v) => new(v);
	}

}
