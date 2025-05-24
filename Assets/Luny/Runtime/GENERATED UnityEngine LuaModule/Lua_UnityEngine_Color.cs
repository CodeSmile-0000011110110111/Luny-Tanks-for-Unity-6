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

		private static readonly LuaFunction _Equals = new("UnityEngine.Color.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Color other;
			Lua_UnityEngine_Color other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Color>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Color>(out other_UserData))
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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Color.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Color>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.Color.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Color>();

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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Color_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Color" };

		private static readonly LuaFunction _HSVToRGB = new("UnityEngine.Color.HSVToRGB", (_context, _buffer, _) =>
		{
			System.Single H;
			System.Single S;
			System.Single V;
			System.Boolean hdr;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<System.Single>(out H) &&
					    arg1.TryRead<System.Single>(out S) &&
					    arg2.TryRead<System.Single>(out V))
					{
						var returnValue = UnityEngine.Color.HSVToRGB(H, S, V);
						_buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg0.TryRead<System.Single>(out H) &&
					    arg1.TryRead<System.Single>(out S) &&
					    arg2.TryRead<System.Single>(out V) &&
					    arg3.TryRead<System.Boolean>(out hdr))
					{
						var returnValue = UnityEngine.Color.HSVToRGB(H, S, V, hdr);
						_buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Color.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Color a;
			Lua_UnityEngine_Color a_UserData;
			UnityEngine.Color b;
			Lua_UnityEngine_Color b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Color>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Color>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Color.Lerp(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _LerpUnclamped = new("UnityEngine.Color.LerpUnclamped", (_context, _buffer, _) =>
		{
			UnityEngine.Color a;
			Lua_UnityEngine_Color a_UserData;
			UnityEngine.Color b;
			Lua_UnityEngine_Color b_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_Color>(out a_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Color>(out b_UserData) &&
					    arg2.TryRead<System.Single>(out t))
					{
						a = a_UserData.Instance;
						b = b_UserData.Instance;
						var returnValue = UnityEngine.Color.LerpUnclamped(a, b, t);
						_buffer.Span[0] = new Lua_UnityEngine_Color(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RGBToHSV = new("UnityEngine.Color.RGBToHSV", (_context, _buffer, _) =>
		{
			UnityEngine.Color rgbColor;
			Lua_UnityEngine_Color rgbColor_UserData;
			System.Single H;
			System.Single S;
			System.Single V;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 4:
				{
					if (arg0.TryRead<Lua_UnityEngine_Color>(out rgbColor_UserData) &&
					    arg1.TryRead<System.Single>(out H) &&
					    arg2.TryRead<System.Single>(out S) &&
					    arg3.TryRead<System.Single>(out V))
					{
						rgbColor = rgbColor_UserData.Instance;
						UnityEngine.Color.RGBToHSV(rgbColor, out H, out S, out V);
						_buffer.Span[0] = arg1;
						_buffer.Span[1] = arg2;
						_buffer.Span[2] = arg3;
						return new ValueTask<Int32>(3);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Color_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
