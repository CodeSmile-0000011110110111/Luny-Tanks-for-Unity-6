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
	public class Lua_UnityEngine_MaterialPropertyBlock : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "MaterialPropertyBlock" };

		private static readonly LuaFunction _Clear = new("UnityEngine.MaterialPropertyBlock.Clear", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

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

		private static readonly LuaFunction _GetFloat = new("UnityEngine.MaterialPropertyBlock.GetFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.GetFloat(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetFloat(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.MaterialPropertyBlock.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

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

		private static readonly LuaFunction _GetInt = new("UnityEngine.MaterialPropertyBlock.GetInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.GetInt(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetInt(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetInteger = new("UnityEngine.MaterialPropertyBlock.GetInteger", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.GetInteger(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetInteger(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasBuffer = new("UnityEngine.MaterialPropertyBlock.HasBuffer", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasBuffer(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasBuffer(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasColor = new("UnityEngine.MaterialPropertyBlock.HasColor", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasColor(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasColor(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasConstantBuffer = new("UnityEngine.MaterialPropertyBlock.HasConstantBuffer", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasConstantBuffer(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasConstantBuffer(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasFloat = new("UnityEngine.MaterialPropertyBlock.HasFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasFloat(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasFloat(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasInt = new("UnityEngine.MaterialPropertyBlock.HasInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasInt(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasInt(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasInteger = new("UnityEngine.MaterialPropertyBlock.HasInteger", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasInteger(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasInteger(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasMatrix = new("UnityEngine.MaterialPropertyBlock.HasMatrix", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasMatrix(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasMatrix(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasProperty = new("UnityEngine.MaterialPropertyBlock.HasProperty", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasProperty(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasProperty(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasTexture = new("UnityEngine.MaterialPropertyBlock.HasTexture", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasTexture(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasTexture(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasVector = new("UnityEngine.MaterialPropertyBlock.HasVector", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasVector(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasVector(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.MaterialPropertyBlock.SetFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Single value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Single>(out value))
					{
						_this.m_Instance.SetFloat(nameID, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Single>(out value))
					{
						_this.m_Instance.SetFloat(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetInt = new("UnityEngine.MaterialPropertyBlock.SetInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInt(nameID, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInt(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetInteger = new("UnityEngine.MaterialPropertyBlock.SetInteger", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInteger(nameID, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInteger(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.MaterialPropertyBlock.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_MaterialPropertyBlock>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_MaterialPropertyBlock instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Clear": return _Clear;
				case "GetFloat": return _GetFloat;
				case "GetHashCode": return _GetHashCode;
				case "GetInt": return _GetInt;
				case "GetInteger": return _GetInteger;
				case "HasBuffer": return _HasBuffer;
				case "HasColor": return _HasColor;
				case "HasConstantBuffer": return _HasConstantBuffer;
				case "HasFloat": return _HasFloat;
				case "HasInt": return _HasInt;
				case "HasInteger": return _HasInteger;
				case "HasMatrix": return _HasMatrix;
				case "HasProperty": return _HasProperty;
				case "HasTexture": return _HasTexture;
				case "HasVector": return _HasVector;
				case "SetFloat": return _SetFloat;
				case "SetInt": return _SetInt;
				case "SetInteger": return _SetInteger;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_MaterialPropertyBlock instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_MaterialPropertyBlock>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_MaterialPropertyBlock>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_MaterialPropertyBlock Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_MaterialPropertyBlock v) => new(v);
		public Lua_UnityEngine_MaterialPropertyBlock(UnityEngine.MaterialPropertyBlock instance) { m_Instance = instance; }
		private UnityEngine.MaterialPropertyBlock m_Instance;
		public UnityEngine.MaterialPropertyBlock Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_MaterialPropertyBlock_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "MaterialPropertyBlock" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_MaterialPropertyBlock_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_MaterialPropertyBlock_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_MaterialPropertyBlock_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_MaterialPropertyBlock_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_MaterialPropertyBlock_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_MaterialPropertyBlock_static v) => new(v);
	}

}
