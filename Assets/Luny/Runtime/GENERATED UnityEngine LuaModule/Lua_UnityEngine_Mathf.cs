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
	public struct Lua_UnityEngine_Mathf : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Mathf" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Mathf.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mathf>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.Mathf.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mathf>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Mathf instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Mathf instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mathf>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mathf>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Mathf Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Mathf v) => new(v);
		public Lua_UnityEngine_Mathf(UnityEngine.Mathf instance) { m_Instance = instance; }
		private UnityEngine.Mathf m_Instance;
		public UnityEngine.Mathf Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Mathf Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Mathf_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Mathf" };

		private static readonly LuaFunction _Abs = new("UnityEngine.Mathf.Abs", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Abs(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Acos = new("UnityEngine.Mathf.Acos", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Acos(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Approximately = new("UnityEngine.Mathf.Approximately", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Approximately(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Asin = new("UnityEngine.Mathf.Asin", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Asin(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Atan = new("UnityEngine.Mathf.Atan", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Atan(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Atan2 = new("UnityEngine.Mathf.Atan2", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var y = arg0.Read<System.Single>();
					var x = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Atan2(y, x);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Ceil = new("UnityEngine.Mathf.Ceil", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Ceil(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _CeilToInt = new("UnityEngine.Mathf.CeilToInt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.CeilToInt(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Clamp = new("UnityEngine.Mathf.Clamp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var value = arg0.Read<System.Single>();
					var min = arg1.Read<System.Single>();
					var max = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Clamp(value, min, max);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Clamp01 = new("UnityEngine.Mathf.Clamp01", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Clamp01(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ClosestPowerOfTwo = new("UnityEngine.Mathf.ClosestPowerOfTwo", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Int32>();
					var returnValue = UnityEngine.Mathf.ClosestPowerOfTwo(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Cos = new("UnityEngine.Mathf.Cos", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Cos(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _DeltaAngle = new("UnityEngine.Mathf.DeltaAngle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var current = arg0.Read<System.Single>();
					var target = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.DeltaAngle(current, target);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Exp = new("UnityEngine.Mathf.Exp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var power = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Exp(power);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _FloatToHalf = new("UnityEngine.Mathf.FloatToHalf", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var val = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.FloatToHalf(val);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Floor = new("UnityEngine.Mathf.Floor", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Floor(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _FloorToInt = new("UnityEngine.Mathf.FloorToInt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.FloorToInt(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Gamma = new("UnityEngine.Mathf.Gamma", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var value = arg0.Read<System.Single>();
					var absmax = arg1.Read<System.Single>();
					var gamma = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Gamma(value, absmax, gamma);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GammaToLinearSpace = new("UnityEngine.Mathf.GammaToLinearSpace", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.GammaToLinearSpace(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _HalfToFloat = new("UnityEngine.Mathf.HalfToFloat", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var val = arg0.Read<System.UInt16>();
					var returnValue = UnityEngine.Mathf.HalfToFloat(val);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _InverseLerp = new("UnityEngine.Mathf.InverseLerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var value = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.InverseLerp(a, b, value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsPowerOfTwo = new("UnityEngine.Mathf.IsPowerOfTwo", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Int32>();
					var returnValue = UnityEngine.Mathf.IsPowerOfTwo(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Mathf.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Lerp(a, b, t);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpAngle = new("UnityEngine.Mathf.LerpAngle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.LerpAngle(a, b, t);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Mathf.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.LerpUnclamped(a, b, t);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LinearToGammaSpace = new("UnityEngine.Mathf.LinearToGammaSpace", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.LinearToGammaSpace(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Log = new("UnityEngine.Mathf.Log", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var f = arg0.Read<System.Single>();
					var p = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Log(f, p);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Log10 = new("UnityEngine.Mathf.Log10", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Log10(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Mathf.Max", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var values = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Max(values);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Mathf.Min", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var a = arg0.Read<System.Single>();
					var b = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Min(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MoveTowards = new("UnityEngine.Mathf.MoveTowards", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var current = arg0.Read<System.Single>();
					var target = arg1.Read<System.Single>();
					var maxDelta = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.MoveTowards(current, target, maxDelta);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MoveTowardsAngle = new("UnityEngine.Mathf.MoveTowardsAngle", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var current = arg0.Read<System.Single>();
					var target = arg1.Read<System.Single>();
					var maxDelta = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.MoveTowardsAngle(current, target, maxDelta);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _NextPowerOfTwo = new("UnityEngine.Mathf.NextPowerOfTwo", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var value = arg0.Read<System.Int32>();
					var returnValue = UnityEngine.Mathf.NextPowerOfTwo(value);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PerlinNoise = new("UnityEngine.Mathf.PerlinNoise", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.PerlinNoise(x, y);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PerlinNoise1D = new("UnityEngine.Mathf.PerlinNoise1D", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var x = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.PerlinNoise1D(x);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PingPong = new("UnityEngine.Mathf.PingPong", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var t = arg0.Read<System.Single>();
					var length = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.PingPong(t, length);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Pow = new("UnityEngine.Mathf.Pow", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var f = arg0.Read<System.Single>();
					var p = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Pow(f, p);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Repeat = new("UnityEngine.Mathf.Repeat", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var t = arg0.Read<System.Single>();
					var length = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Repeat(t, length);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Round = new("UnityEngine.Mathf.Round", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Round(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RoundToInt = new("UnityEngine.Mathf.RoundToInt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.RoundToInt(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Sign = new("UnityEngine.Mathf.Sign", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Sign(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Sin = new("UnityEngine.Mathf.Sin", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Sin(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SmoothDamp = new("UnityEngine.Mathf.SmoothDamp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 5:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var current = arg0.Read<System.Single>();
					var target = arg1.Read<System.Single>();
					var currentVelocity = arg2.Read<System.Single>();
					var smoothTime = arg3.Read<System.Single>();
					var maxSpeed = arg4.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);
					buffer.Span[0] = new LuaValue(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SmoothDampAngle = new("UnityEngine.Mathf.SmoothDampAngle", (context, buffer, ct) =>
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
					var current = arg0.Read<System.Single>();
					var target = arg1.Read<System.Single>();
					var currentVelocity = arg2.Read<System.Single>();
					var smoothTime = arg3.Read<System.Single>();
					var maxSpeed = arg4.Read<System.Single>();
					var deltaTime = arg5.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
					buffer.Span[0] = new LuaValue(returnValue);
					buffer.Span[1] = arg2;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SmoothStep = new("UnityEngine.Mathf.SmoothStep", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var from = arg0.Read<System.Single>();
					var to = arg1.Read<System.Single>();
					var t = arg2.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.SmoothStep(from, to, t);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Sqrt = new("UnityEngine.Mathf.Sqrt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Sqrt(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Tan = new("UnityEngine.Mathf.Tan", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var f = arg0.Read<System.Single>();
					var returnValue = UnityEngine.Mathf.Tan(f);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Mathf_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Abs": return _Abs;
				case "Acos": return _Acos;
				case "Approximately": return _Approximately;
				case "Asin": return _Asin;
				case "Atan": return _Atan;
				case "Atan2": return _Atan2;
				case "Ceil": return _Ceil;
				case "CeilToInt": return _CeilToInt;
				case "Clamp": return _Clamp;
				case "Clamp01": return _Clamp01;
				case "ClosestPowerOfTwo": return _ClosestPowerOfTwo;
				case "Cos": return _Cos;
				case "DeltaAngle": return _DeltaAngle;
				case "Exp": return _Exp;
				case "FloatToHalf": return _FloatToHalf;
				case "Floor": return _Floor;
				case "FloorToInt": return _FloorToInt;
				case "Gamma": return _Gamma;
				case "GammaToLinearSpace": return _GammaToLinearSpace;
				case "HalfToFloat": return _HalfToFloat;
				case "InverseLerp": return _InverseLerp;
				case "IsPowerOfTwo": return _IsPowerOfTwo;
				case "Lerp": return _Lerp;
				case "LerpAngle": return _LerpAngle;
				case "LerpUnclamped": return _LerpUnclamped;
				case "LinearToGammaSpace": return _LinearToGammaSpace;
				case "Log": return _Log;
				case "Log10": return _Log10;
				case "Max": return _Max;
				case "Min": return _Min;
				case "MoveTowards": return _MoveTowards;
				case "MoveTowardsAngle": return _MoveTowardsAngle;
				case "NextPowerOfTwo": return _NextPowerOfTwo;
				case "PerlinNoise": return _PerlinNoise;
				case "PerlinNoise1D": return _PerlinNoise1D;
				case "PingPong": return _PingPong;
				case "Pow": return _Pow;
				case "Repeat": return _Repeat;
				case "Round": return _Round;
				case "RoundToInt": return _RoundToInt;
				case "Sign": return _Sign;
				case "Sin": return _Sin;
				case "SmoothDamp": return _SmoothDamp;
				case "SmoothDampAngle": return _SmoothDampAngle;
				case "SmoothStep": return _SmoothStep;
				case "Sqrt": return _Sqrt;
				case "Tan": return _Tan;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Mathf_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mathf_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mathf_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Mathf_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Mathf_static v) => new(v);
	}

}
