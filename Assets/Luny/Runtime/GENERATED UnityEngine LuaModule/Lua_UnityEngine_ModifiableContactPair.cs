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
	public struct Lua_UnityEngine_ModifiableContactPair : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ModifiableContactPair" };

		private static readonly LuaFunction _GetBounciness = new("UnityEngine.ModifiableContactPair.GetBounciness", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetBounciness(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetDynamicFriction = new("UnityEngine.ModifiableContactPair.GetDynamicFriction", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetDynamicFriction(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetFaceIndex = new("UnityEngine.ModifiableContactPair.GetFaceIndex", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetFaceIndex(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ModifiableContactPair.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

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

		private static readonly LuaFunction _GetMaxImpulse = new("UnityEngine.ModifiableContactPair.GetMaxImpulse", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetMaxImpulse(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetSeparation = new("UnityEngine.ModifiableContactPair.GetSeparation", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetSeparation(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetStaticFriction = new("UnityEngine.ModifiableContactPair.GetStaticFriction", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						var returnValue = _this.m_Instance.GetStaticFriction(i);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IgnoreContact = new("UnityEngine.ModifiableContactPair.IgnoreContact", (_context, _buffer, _) =>
		{
			System.Int32 i;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out i))
					{
						_this.m_Instance.IgnoreContact(i);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetBounciness = new("UnityEngine.ModifiableContactPair.SetBounciness", (_context, _buffer, _) =>
		{
			System.Int32 i;
			System.Single bounciness;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out i) &&
					    arg2.TryRead<System.Single>(out bounciness))
					{
						_this.m_Instance.SetBounciness(i, bounciness);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetDynamicFriction = new("UnityEngine.ModifiableContactPair.SetDynamicFriction", (_context, _buffer, _) =>
		{
			System.Int32 i;
			System.Single dynamicFriction;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out i) &&
					    arg2.TryRead<System.Single>(out dynamicFriction))
					{
						_this.m_Instance.SetDynamicFriction(i, dynamicFriction);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetMaxImpulse = new("UnityEngine.ModifiableContactPair.SetMaxImpulse", (_context, _buffer, _) =>
		{
			System.Int32 i;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out i) &&
					    arg2.TryRead<System.Single>(out value))
					{
						_this.m_Instance.SetMaxImpulse(i, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetSeparation = new("UnityEngine.ModifiableContactPair.SetSeparation", (_context, _buffer, _) =>
		{
			System.Int32 i;
			System.Single separation;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out i) &&
					    arg2.TryRead<System.Single>(out separation))
					{
						_this.m_Instance.SetSeparation(i, separation);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetStaticFriction = new("UnityEngine.ModifiableContactPair.SetStaticFriction", (_context, _buffer, _) =>
		{
			System.Int32 i;
			System.Single staticFriction;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out i) &&
					    arg2.TryRead<System.Single>(out staticFriction))
					{
						_this.m_Instance.SetStaticFriction(i, staticFriction);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ModifiableContactPair.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ModifiableContactPair>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_ModifiableContactPair instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetBounciness": return _GetBounciness;
				case "GetDynamicFriction": return _GetDynamicFriction;
				case "GetFaceIndex": return _GetFaceIndex;
				case "GetHashCode": return _GetHashCode;
				case "GetMaxImpulse": return _GetMaxImpulse;
				case "GetSeparation": return _GetSeparation;
				case "GetStaticFriction": return _GetStaticFriction;
				case "IgnoreContact": return _IgnoreContact;
				case "SetBounciness": return _SetBounciness;
				case "SetDynamicFriction": return _SetDynamicFriction;
				case "SetMaxImpulse": return _SetMaxImpulse;
				case "SetSeparation": return _SetSeparation;
				case "SetStaticFriction": return _SetStaticFriction;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ModifiableContactPair instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ModifiableContactPair>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ModifiableContactPair>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ModifiableContactPair Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ModifiableContactPair v) => new(v);
		public Lua_UnityEngine_ModifiableContactPair(UnityEngine.ModifiableContactPair instance) { m_Instance = instance; }
		private UnityEngine.ModifiableContactPair m_Instance;
		public UnityEngine.ModifiableContactPair Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.ModifiableContactPair Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_ModifiableContactPair_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ModifiableContactPair" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_ModifiableContactPair_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ModifiableContactPair_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ModifiableContactPair_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ModifiableContactPair_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ModifiableContactPair_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ModifiableContactPair_static v) => new(v);
	}

}
