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
	public struct Lua_UnityEngine_RenderingLayerMask : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RenderingLayerMask" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.RenderingLayerMask.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderingLayerMask>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.RenderingLayerMask.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderingLayerMask>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_RenderingLayerMask instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RenderingLayerMask instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderingLayerMask>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderingLayerMask>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RenderingLayerMask Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RenderingLayerMask v) => new(v);
		public Lua_UnityEngine_RenderingLayerMask(UnityEngine.RenderingLayerMask instance) { m_Instance = instance; }
		private UnityEngine.RenderingLayerMask m_Instance;
		public UnityEngine.RenderingLayerMask Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.RenderingLayerMask Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_RenderingLayerMask_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RenderingLayerMask" };

		private static readonly LuaFunction _GetDefinedRenderingLayerCount = new("UnityEngine.RenderingLayerMask.GetDefinedRenderingLayerCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.RenderingLayerMask.GetDefinedRenderingLayerCount();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetDefinedRenderingLayersCombinedMaskValue = new("UnityEngine.RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValue", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValue();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetLastDefinedRenderingLayerIndex = new("UnityEngine.RenderingLayerMask.GetLastDefinedRenderingLayerIndex", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.RenderingLayerMask.GetLastDefinedRenderingLayerIndex();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetRenderingLayerCount = new("UnityEngine.RenderingLayerMask.GetRenderingLayerCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.RenderingLayerMask.GetRenderingLayerCount();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _NameToRenderingLayer = new("UnityEngine.RenderingLayerMask.NameToRenderingLayer", (_context, _buffer, _) =>
		{
			System.String layerName;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out layerName))
					{
						var returnValue = UnityEngine.RenderingLayerMask.NameToRenderingLayer(layerName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RenderingLayerToName = new("UnityEngine.RenderingLayerMask.RenderingLayerToName", (_context, _buffer, _) =>
		{
			System.Int32 layer;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.Int32>(out layer))
					{
						var returnValue = UnityEngine.RenderingLayerMask.RenderingLayerToName(layer);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_RenderingLayerMask_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetDefinedRenderingLayerCount": return _GetDefinedRenderingLayerCount;
				case "GetDefinedRenderingLayersCombinedMaskValue": return _GetDefinedRenderingLayersCombinedMaskValue;
				case "GetLastDefinedRenderingLayerIndex": return _GetLastDefinedRenderingLayerIndex;
				case "GetRenderingLayerCount": return _GetRenderingLayerCount;
				case "NameToRenderingLayer": return _NameToRenderingLayer;
				case "RenderingLayerToName": return _RenderingLayerToName;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RenderingLayerMask_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderingLayerMask_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderingLayerMask_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RenderingLayerMask_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RenderingLayerMask_static v) => new(v);
	}

}
