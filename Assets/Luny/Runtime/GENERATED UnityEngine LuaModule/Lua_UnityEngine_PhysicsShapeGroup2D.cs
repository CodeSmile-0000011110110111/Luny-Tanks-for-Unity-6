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
	public class Lua_UnityEngine_PhysicsShapeGroup2D : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "PhysicsShapeGroup2D" };

		private static readonly LuaFunction _Add = new("UnityEngine.PhysicsShapeGroup2D.Add", (_context, _buffer, _) =>
		{
			UnityEngine.PhysicsShapeGroup2D physicsShapeGroup;
			Lua_UnityEngine_PhysicsShapeGroup2D physicsShapeGroup_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_PhysicsShapeGroup2D>(out physicsShapeGroup_UserData))
					{
						physicsShapeGroup = physicsShapeGroup_UserData.Instance;
						_this.m_Instance.Add(physicsShapeGroup);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Clear = new("UnityEngine.PhysicsShapeGroup2D.Clear", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Clear();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DeleteShape = new("UnityEngine.PhysicsShapeGroup2D.DeleteShape", (_context, _buffer, _) =>
		{
			System.Int32 shapeIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out shapeIndex))
					{
						_this.m_Instance.DeleteShape(shapeIndex);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.PhysicsShapeGroup2D.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

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

		private static readonly LuaFunction _SetShapeRadius = new("UnityEngine.PhysicsShapeGroup2D.SetShapeRadius", (_context, _buffer, _) =>
		{
			System.Int32 shapeIndex;
			System.Single radius;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out shapeIndex) &&
					    arg2.TryRead<System.Single>(out radius))
					{
						_this.m_Instance.SetShapeRadius(shapeIndex, radius);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.PhysicsShapeGroup2D.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_PhysicsShapeGroup2D>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_PhysicsShapeGroup2D instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Add": return _Add;
				case "Clear": return _Clear;
				case "DeleteShape": return _DeleteShape;
				case "GetHashCode": return _GetHashCode;
				case "SetShapeRadius": return _SetShapeRadius;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_PhysicsShapeGroup2D instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_PhysicsShapeGroup2D>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_PhysicsShapeGroup2D>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_PhysicsShapeGroup2D Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_PhysicsShapeGroup2D v) => new(v);
		public Lua_UnityEngine_PhysicsShapeGroup2D(UnityEngine.PhysicsShapeGroup2D instance) { m_Instance = instance; }
		private UnityEngine.PhysicsShapeGroup2D m_Instance;
		public UnityEngine.PhysicsShapeGroup2D Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_PhysicsShapeGroup2D_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "PhysicsShapeGroup2D" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_PhysicsShapeGroup2D_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_PhysicsShapeGroup2D_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_PhysicsShapeGroup2D_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_PhysicsShapeGroup2D_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_PhysicsShapeGroup2D_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_PhysicsShapeGroup2D_static v) => new(v);
	}

}
