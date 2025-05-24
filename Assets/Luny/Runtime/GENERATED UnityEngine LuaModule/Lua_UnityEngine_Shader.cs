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
	public class Lua_UnityEngine_Shader : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Shader" };

		private static readonly LuaFunction _FindPropertyIndex = new("UnityEngine.Shader.FindPropertyIndex", (_context, _buffer, _) =>
		{
			System.String propertyName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out propertyName))
					{
						var returnValue = _this.m_Instance.FindPropertyIndex(propertyName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _FindTextureStack = new("UnityEngine.Shader.FindTextureStack", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;
			System.String stackName;
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex) &&
					    arg2.TryRead<System.String>(out stackName) &&
					    arg3.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.FindTextureStack(propertyIndex, out stackName, out layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						_buffer.Span[1] = arg2;
						_buffer.Span[2] = arg3;
						return new ValueTask<Int32>(3);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetDependency = new("UnityEngine.Shader.GetDependency", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetDependency(name);
						_buffer.Span[0] = new Lua_UnityEngine_Shader(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Shader.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Shader.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetInstanceID();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPassCountInSubshader = new("UnityEngine.Shader.GetPassCountInSubshader", (_context, _buffer, _) =>
		{
			System.Int32 subshaderIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out subshaderIndex))
					{
						var returnValue = _this.m_Instance.GetPassCountInSubshader(subshaderIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyCount = new("UnityEngine.Shader.GetPropertyCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetPropertyCount();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyDefaultFloatValue = new("UnityEngine.Shader.GetPropertyDefaultFloatValue", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyDefaultFloatValue(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyDefaultIntValue = new("UnityEngine.Shader.GetPropertyDefaultIntValue", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyDefaultIntValue(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyDescription = new("UnityEngine.Shader.GetPropertyDescription", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyDescription(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyName = new("UnityEngine.Shader.GetPropertyName", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyName(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyNameId = new("UnityEngine.Shader.GetPropertyNameId", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyNameId(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetPropertyTextureDefaultName = new("UnityEngine.Shader.GetPropertyTextureDefaultName", (_context, _buffer, _) =>
		{
			System.Int32 propertyIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out propertyIndex))
					{
						var returnValue = _this.m_Instance.GetPropertyTextureDefaultName(propertyIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Shader.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Shader>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Shader instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "FindPropertyIndex": return _FindPropertyIndex;
				case "FindTextureStack": return _FindTextureStack;
				case "GetDependency": return _GetDependency;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "GetPassCountInSubshader": return _GetPassCountInSubshader;
				case "GetPropertyCount": return _GetPropertyCount;
				case "GetPropertyDefaultFloatValue": return _GetPropertyDefaultFloatValue;
				case "GetPropertyDefaultIntValue": return _GetPropertyDefaultIntValue;
				case "GetPropertyDescription": return _GetPropertyDescription;
				case "GetPropertyName": return _GetPropertyName;
				case "GetPropertyNameId": return _GetPropertyNameId;
				case "GetPropertyTextureDefaultName": return _GetPropertyTextureDefaultName;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Shader instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Shader>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Shader>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Shader Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Shader v) => new(v);
		public Lua_UnityEngine_Shader(UnityEngine.Shader instance) { m_Instance = instance; }
		private UnityEngine.Shader m_Instance;
		public UnityEngine.Shader Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Shader_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Shader" };

		private static readonly LuaFunction _DisableKeyword = new("UnityEngine.Shader.DisableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out keyword))
					{
						UnityEngine.Shader.DisableKeyword(keyword);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _EnableKeyword = new("UnityEngine.Shader.EnableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out keyword))
					{
						UnityEngine.Shader.EnableKeyword(keyword);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Find = new("UnityEngine.Shader.Find", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Shader.Find(name);
						_buffer.Span[0] = new Lua_UnityEngine_Shader(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetGlobalFloat = new("UnityEngine.Shader.GetGlobalFloat", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Shader.GetGlobalFloat(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg0.TryRead<System.Int32>(out nameID))
					{
						var returnValue = UnityEngine.Shader.GetGlobalFloat(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetGlobalInt = new("UnityEngine.Shader.GetGlobalInt", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Shader.GetGlobalInt(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg0.TryRead<System.Int32>(out nameID))
					{
						var returnValue = UnityEngine.Shader.GetGlobalInt(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetGlobalInteger = new("UnityEngine.Shader.GetGlobalInteger", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Shader.GetGlobalInteger(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg0.TryRead<System.Int32>(out nameID))
					{
						var returnValue = UnityEngine.Shader.GetGlobalInteger(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsKeywordEnabled = new("UnityEngine.Shader.IsKeywordEnabled", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out keyword))
					{
						var returnValue = UnityEngine.Shader.IsKeywordEnabled(keyword);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _PropertyToID = new("UnityEngine.Shader.PropertyToID", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Shader.PropertyToID(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGlobalFloat = new("UnityEngine.Shader.SetGlobalFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Single value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out nameID) &&
					    arg1.TryRead<System.Single>(out value))
					{
						UnityEngine.Shader.SetGlobalFloat(nameID, value);
						return new ValueTask<Int32>(0);
					}
					if (arg0.TryRead<System.String>(out name) &&
					    arg1.TryRead<System.Single>(out value))
					{
						UnityEngine.Shader.SetGlobalFloat(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGlobalInt = new("UnityEngine.Shader.SetGlobalInt", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 value;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.String>(out name) &&
					    arg1.TryRead<System.Int32>(out value))
					{
						UnityEngine.Shader.SetGlobalInt(name, value);
						return new ValueTask<Int32>(0);
					}
					if (arg0.TryRead<System.Int32>(out nameID) &&
					    arg1.TryRead<System.Int32>(out value))
					{
						UnityEngine.Shader.SetGlobalInt(nameID, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGlobalInteger = new("UnityEngine.Shader.SetGlobalInteger", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out nameID) &&
					    arg1.TryRead<System.Int32>(out value))
					{
						UnityEngine.Shader.SetGlobalInteger(nameID, value);
						return new ValueTask<Int32>(0);
					}
					if (arg0.TryRead<System.String>(out name) &&
					    arg1.TryRead<System.Int32>(out value))
					{
						UnityEngine.Shader.SetGlobalInteger(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _WarmupAllShaders = new("UnityEngine.Shader.WarmupAllShaders", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.Shader.WarmupAllShaders();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Shader_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "DisableKeyword": return _DisableKeyword;
				case "EnableKeyword": return _EnableKeyword;
				case "Find": return _Find;
				case "GetGlobalFloat": return _GetGlobalFloat;
				case "GetGlobalInt": return _GetGlobalInt;
				case "GetGlobalInteger": return _GetGlobalInteger;
				case "IsKeywordEnabled": return _IsKeywordEnabled;
				case "PropertyToID": return _PropertyToID;
				case "SetGlobalFloat": return _SetGlobalFloat;
				case "SetGlobalInt": return _SetGlobalInt;
				case "SetGlobalInteger": return _SetGlobalInteger;
				case "WarmupAllShaders": return _WarmupAllShaders;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Shader_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Shader_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Shader_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Shader_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Shader_static v) => new(v);
	}

}
