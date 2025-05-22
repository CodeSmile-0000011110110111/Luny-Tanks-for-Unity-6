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

		private static readonly LuaFunction _Equals = new("UnityEngine.Quaternion.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Quaternion.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
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

		private static readonly LuaFunction _Normalize = new("UnityEngine.Quaternion.Normalize", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
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

		private static readonly LuaFunction _Set = new("UnityEngine.Quaternion.Set", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
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

		private static readonly LuaFunction _SetEulerAngles = new("UnityEngine.Quaternion.SetEulerAngles", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var x = arg1.Read<System.Single>();
					var y = arg2.Read<System.Single>();
					var z = arg3.Read<System.Single>();
					_this.m_Instance.SetEulerAngles(x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetEulerRotation = new("UnityEngine.Quaternion.SetEulerRotation", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var x = arg1.Read<System.Single>();
					var y = arg2.Read<System.Single>();
					var z = arg3.Read<System.Single>();
					_this.m_Instance.SetEulerRotation(x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Quaternion.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Quaternion>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ToString();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
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
				case "SetEulerAngles": return _SetEulerAngles;
				case "SetEulerRotation": return _SetEulerRotation;
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
	}
	public sealed class Lua_UnityEngine_Quaternion_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Quaternion" };

		private static readonly LuaFunction _Angle = new("UnityEngine.Quaternion.Angle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Angle(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Dot = new("UnityEngine.Quaternion.Dot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Dot(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Euler = new("UnityEngine.Quaternion.Euler", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var z = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Quaternion.Euler(x, y, z);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _EulerAngles = new("UnityEngine.Quaternion.EulerAngles", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var z = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Quaternion.EulerAngles(x, y, z);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _EulerRotation = new("UnityEngine.Quaternion.EulerRotation", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var z = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Quaternion.EulerRotation(x, y, z);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Inverse = new("UnityEngine.Quaternion.Inverse", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var rotationUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var rotation = rotationUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Inverse(rotation);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Quaternion.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Lerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Quaternion.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.LerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Normalize = new("UnityEngine.Quaternion.Normalize", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var qUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var q = qUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Normalize(q);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RotateTowards = new("UnityEngine.Quaternion.RotateTowards", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var fromUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var toUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var maxDegreesDelta = arg2.Read<System.Single>();
					var from = fromUserData.Instance;
					var to = toUserData.Instance;
					var returnValue = UnityEngine.Quaternion.RotateTowards(from, to, maxDegreesDelta);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Slerp = new("UnityEngine.Quaternion.Slerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.Slerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SlerpUnclamped = new("UnityEngine.Quaternion.SlerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Quaternion>();
					var bUserData = arg1.Read<Lua_UnityEngine_Quaternion>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Quaternion.SlerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Quaternion(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Quaternion_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Angle": return _Angle;
				case "Dot": return _Dot;
				case "Euler": return _Euler;
				case "EulerAngles": return _EulerAngles;
				case "EulerRotation": return _EulerRotation;
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Quaternion_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
