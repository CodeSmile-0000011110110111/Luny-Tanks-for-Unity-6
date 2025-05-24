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
	public struct Lua_UnityEngine_ContactFilter2D : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ContactFilter2D" };

		private static readonly LuaFunction _ClearDepth = new("UnityEngine.ContactFilter2D.ClearDepth", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearDepth();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClearLayerMask = new("UnityEngine.ContactFilter2D.ClearLayerMask", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearLayerMask();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClearNormalAngle = new("UnityEngine.ContactFilter2D.ClearNormalAngle", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearNormalAngle();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ContactFilter2D.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

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

		private static readonly LuaFunction _IsFilteringNormalAngle = new("UnityEngine.ContactFilter2D.IsFilteringNormalAngle", (_context, _buffer, _) =>
		{
			System.Single angle;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out angle))
					{
						var returnValue = _this.m_Instance.IsFilteringNormalAngle(angle);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _NoFilter = new("UnityEngine.ContactFilter2D.NoFilter", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.NoFilter();
						_buffer.Span[0] = new Lua_UnityEngine_ContactFilter2D(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetDepth = new("UnityEngine.ContactFilter2D.SetDepth", (_context, _buffer, _) =>
		{
			System.Single minDepth;
			System.Single maxDepth;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Single>(out minDepth) &&
					    arg2.TryRead<System.Single>(out maxDepth))
					{
						_this.m_Instance.SetDepth(minDepth, maxDepth);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetNormalAngle = new("UnityEngine.ContactFilter2D.SetNormalAngle", (_context, _buffer, _) =>
		{
			System.Single minNormalAngle;
			System.Single maxNormalAngle;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Single>(out minNormalAngle) &&
					    arg2.TryRead<System.Single>(out maxNormalAngle))
					{
						_this.m_Instance.SetNormalAngle(minNormalAngle, maxNormalAngle);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ContactFilter2D.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ContactFilter2D>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_ContactFilter2D instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ClearDepth": return _ClearDepth;
				case "ClearLayerMask": return _ClearLayerMask;
				case "ClearNormalAngle": return _ClearNormalAngle;
				case "GetHashCode": return _GetHashCode;
				case "IsFilteringNormalAngle": return _IsFilteringNormalAngle;
				case "NoFilter": return _NoFilter;
				case "SetDepth": return _SetDepth;
				case "SetNormalAngle": return _SetNormalAngle;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ContactFilter2D instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ContactFilter2D>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ContactFilter2D>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ContactFilter2D Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ContactFilter2D v) => new(v);
		public Lua_UnityEngine_ContactFilter2D(UnityEngine.ContactFilter2D instance) { m_Instance = instance; }
		private UnityEngine.ContactFilter2D m_Instance;
		public UnityEngine.ContactFilter2D Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.ContactFilter2D Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_ContactFilter2D_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ContactFilter2D" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_ContactFilter2D_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ContactFilter2D_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ContactFilter2D_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ContactFilter2D_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ContactFilter2D_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ContactFilter2D_static v) => new(v);
	}

}
