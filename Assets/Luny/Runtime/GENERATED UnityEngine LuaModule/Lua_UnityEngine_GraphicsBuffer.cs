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
	public class Lua_UnityEngine_GraphicsBuffer : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "GraphicsBuffer" };

		private static readonly LuaFunction _Dispose = new("UnityEngine.GraphicsBuffer.Dispose", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Dispose();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.GraphicsBuffer.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

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

		private static readonly LuaFunction _IsValid = new("UnityEngine.GraphicsBuffer.IsValid", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.IsValid();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Release = new("UnityEngine.GraphicsBuffer.Release", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Release();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetCounterValue = new("UnityEngine.GraphicsBuffer.SetCounterValue", (_context, _buffer, _) =>
		{
			System.UInt32 counterValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.UInt32>(out counterValue))
					{
						_this.m_Instance.SetCounterValue(counterValue);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.GraphicsBuffer.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GraphicsBuffer>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_GraphicsBuffer instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Dispose": return _Dispose;
				case "GetHashCode": return _GetHashCode;
				case "IsValid": return _IsValid;
				case "Release": return _Release;
				case "SetCounterValue": return _SetCounterValue;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_GraphicsBuffer instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GraphicsBuffer>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GraphicsBuffer>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_GraphicsBuffer Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_GraphicsBuffer v) => new(v);
		public Lua_UnityEngine_GraphicsBuffer(UnityEngine.GraphicsBuffer instance) { m_Instance = instance; }
		private UnityEngine.GraphicsBuffer m_Instance;
		public UnityEngine.GraphicsBuffer Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_GraphicsBuffer_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "GraphicsBuffer" };

		private static readonly LuaFunction _CopyCount = new("UnityEngine.GraphicsBuffer.CopyCount", (_context, _buffer, _) =>
		{
			UnityEngine.GraphicsBuffer src;
			Lua_UnityEngine_GraphicsBuffer src_UserData;
			UnityEngine.GraphicsBuffer dst;
			Lua_UnityEngine_GraphicsBuffer dst_UserData;
			System.Int32 dstOffsetBytes;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<Lua_UnityEngine_GraphicsBuffer>(out src_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_GraphicsBuffer>(out dst_UserData) &&
					    arg2.TryRead<System.Int32>(out dstOffsetBytes))
					{
						src = src_UserData.Instance;
						dst = dst_UserData.Instance;
						UnityEngine.GraphicsBuffer.CopyCount(src, dst, dstOffsetBytes);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_GraphicsBuffer_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "CopyCount": return _CopyCount;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_GraphicsBuffer_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GraphicsBuffer_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GraphicsBuffer_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_GraphicsBuffer_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_GraphicsBuffer_static v) => new(v);
	}

}
