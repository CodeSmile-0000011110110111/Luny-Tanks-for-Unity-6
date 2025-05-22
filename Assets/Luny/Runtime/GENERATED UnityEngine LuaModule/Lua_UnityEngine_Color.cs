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
	public struct Lua_UnityEngine_Color : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Color" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Color.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Color>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Color>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Color.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Color>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.Color.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Color>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Color instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Color instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Color Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Color v) => new(v);
		public Lua_UnityEngine_Color(UnityEngine.Color instance) { m_Instance = instance; }
		private UnityEngine.Color m_Instance;
		public UnityEngine.Color Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Color Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Color_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Color" };

		private static readonly LuaFunction _HSVToRGB = new("UnityEngine.Color.HSVToRGB", (context, buffer, ct) =>
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
					var H = arg0.Read<System.Single>();
					var S = arg1.Read<System.Single>();
					var V = arg2.Read<System.Single>();
					var hdr = arg3.Read<System.Boolean>();
					var returnValue = UnityEngine.Color.HSVToRGB(H, S, V, hdr);
					buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Color.Lerp", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Color>();
					var bUserData = arg1.Read<Lua_UnityEngine_Color>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Color.Lerp(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Color.LerpUnclamped", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var aUserData = arg0.Read<Lua_UnityEngine_Color>();
					var bUserData = arg1.Read<Lua_UnityEngine_Color>();
					var t = arg2.Read<System.Single>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Color.LerpUnclamped(a, b, t);
					buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RGBToHSV = new("UnityEngine.Color.RGBToHSV", (context, buffer, ct) =>
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
					var rgbColorUserData = arg0.Read<Lua_UnityEngine_Color>();
					var H = arg1.Read<System.Single>();
					var S = arg2.Read<System.Single>();
					var V = arg3.Read<System.Single>();
					var rgbColor = rgbColorUserData.Instance;
					UnityEngine.Color.RGBToHSV(rgbColor, out H, out S, out V);
					buffer.Span[0] = arg1;
					buffer.Span[1] = arg2;
					buffer.Span[2] = arg3;
					return new ValueTask<Int32>(3);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Color_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "HSVToRGB": return _HSVToRGB;
				case "Lerp": return _Lerp;
				case "LerpUnclamped": return _LerpUnclamped;
				case "RGBToHSV": return _RGBToHSV;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Color_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Color_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Color_static v) => new(v);
	}

}
