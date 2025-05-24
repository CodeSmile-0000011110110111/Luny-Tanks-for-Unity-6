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
	public class Lua_UnityEngine_Material : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Material" };

		private static readonly LuaFunction _ApplyPropertyOverride = new("UnityEngine.Material.ApplyPropertyOverride", (_context, _buffer, _) =>
		{
			UnityEngine.Material destination;
			Lua_UnityEngine_Material destination_UserData;
			System.Int32 nameID;
			System.Boolean recordUndo = true;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<Lua_UnityEngine_Material>(out destination_UserData) &&
					    arg2.TryRead<System.Int32>(out nameID) &&
					    arg3.TryRead<System.Boolean>(out recordUndo))
					{
						destination = destination_UserData.Instance;
						_this.m_Instance.ApplyPropertyOverride(destination, nameID, recordUndo);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<Lua_UnityEngine_Material>(out destination_UserData) &&
					    arg2.TryRead<System.String>(out name) &&
					    arg3.TryRead<System.Boolean>(out recordUndo))
					{
						destination = destination_UserData.Instance;
						_this.m_Instance.ApplyPropertyOverride(destination, name, recordUndo);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ComputeCRC = new("UnityEngine.Material.ComputeCRC", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.ComputeCRC();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CopyMatchingPropertiesFromMaterial = new("UnityEngine.Material.CopyMatchingPropertiesFromMaterial", (_context, _buffer, _) =>
		{
			UnityEngine.Material mat;
			Lua_UnityEngine_Material mat_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Material>(out mat_UserData))
					{
						mat = mat_UserData.Instance;
						_this.m_Instance.CopyMatchingPropertiesFromMaterial(mat);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CopyPropertiesFromMaterial = new("UnityEngine.Material.CopyPropertiesFromMaterial", (_context, _buffer, _) =>
		{
			UnityEngine.Material mat;
			Lua_UnityEngine_Material mat_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Material>(out mat_UserData))
					{
						mat = mat_UserData.Instance;
						_this.m_Instance.CopyPropertiesFromMaterial(mat);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DisableKeyword = new("UnityEngine.Material.DisableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out keyword))
					{
						_this.m_Instance.DisableKeyword(keyword);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _EnableKeyword = new("UnityEngine.Material.EnableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out keyword))
					{
						_this.m_Instance.EnableKeyword(keyword);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _FindPass = new("UnityEngine.Material.FindPass", (_context, _buffer, _) =>
		{
			System.String passName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out passName))
					{
						var returnValue = _this.m_Instance.FindPass(passName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetFloat = new("UnityEngine.Material.GetFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Material.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Material.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _GetInt = new("UnityEngine.Material.GetInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _GetInteger = new("UnityEngine.Material.GetInteger", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _GetPassName = new("UnityEngine.Material.GetPassName", (_context, _buffer, _) =>
		{
			System.Int32 pass;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out pass))
					{
						var returnValue = _this.m_Instance.GetPassName(pass);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetShaderPassEnabled = new("UnityEngine.Material.GetShaderPassEnabled", (_context, _buffer, _) =>
		{
			System.String passName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out passName))
					{
						var returnValue = _this.m_Instance.GetShaderPassEnabled(passName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetTag = new("UnityEngine.Material.GetTag", (_context, _buffer, _) =>
		{
			System.String tag;
			System.Boolean searchFallbacks;
			System.String defaultValue;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out tag) &&
					    arg2.TryRead<System.Boolean>(out searchFallbacks))
					{
						var returnValue = _this.m_Instance.GetTag(tag, searchFallbacks);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.String>(out tag) &&
					    arg2.TryRead<System.Boolean>(out searchFallbacks) &&
					    arg3.TryRead<System.String>(out defaultValue))
					{
						var returnValue = _this.m_Instance.GetTag(tag, searchFallbacks, defaultValue);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasBuffer = new("UnityEngine.Material.HasBuffer", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _HasColor = new("UnityEngine.Material.HasColor", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _HasConstantBuffer = new("UnityEngine.Material.HasConstantBuffer", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _HasFloat = new("UnityEngine.Material.HasFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _HasInt = new("UnityEngine.Material.HasInt", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasInt(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasInt(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasInteger = new("UnityEngine.Material.HasInteger", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _HasMatrix = new("UnityEngine.Material.HasMatrix", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasMatrix(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasMatrix(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasProperty = new("UnityEngine.Material.HasProperty", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasProperty(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasProperty(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasTexture = new("UnityEngine.Material.HasTexture", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.HasTexture(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasTexture(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasVector = new("UnityEngine.Material.HasVector", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _IsChildOf = new("UnityEngine.Material.IsChildOf", (_context, _buffer, _) =>
		{
			UnityEngine.Material ancestor;
			Lua_UnityEngine_Material ancestor_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Material>(out ancestor_UserData))
					{
						ancestor = ancestor_UserData.Instance;
						var returnValue = _this.m_Instance.IsChildOf(ancestor);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsKeywordEnabled = new("UnityEngine.Material.IsKeywordEnabled", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out keyword))
					{
						var returnValue = _this.m_Instance.IsKeywordEnabled(keyword);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsPropertyLocked = new("UnityEngine.Material.IsPropertyLocked", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.IsPropertyLocked(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.IsPropertyLocked(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsPropertyLockedByAncestor = new("UnityEngine.Material.IsPropertyLockedByAncestor", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.IsPropertyLockedByAncestor(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.IsPropertyLockedByAncestor(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsPropertyOverriden = new("UnityEngine.Material.IsPropertyOverriden", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.IsPropertyOverriden(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						var returnValue = _this.m_Instance.IsPropertyOverriden(nameID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Lerp = new("UnityEngine.Material.Lerp", (_context, _buffer, _) =>
		{
			UnityEngine.Material start;
			Lua_UnityEngine_Material start_UserData;
			UnityEngine.Material end;
			Lua_UnityEngine_Material end_UserData;
			System.Single t;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<Lua_UnityEngine_Material>(out start_UserData) &&
					    arg2.TryRead<Lua_UnityEngine_Material>(out end_UserData) &&
					    arg3.TryRead<System.Single>(out t))
					{
						start = start_UserData.Instance;
						end = end_UserData.Instance;
						_this.m_Instance.Lerp(start, end, t);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RevertAllPropertyOverrides = new("UnityEngine.Material.RevertAllPropertyOverrides", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RevertAllPropertyOverrides();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RevertPropertyOverride = new("UnityEngine.Material.RevertPropertyOverride", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						_this.m_Instance.RevertPropertyOverride(name);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out nameID))
					{
						_this.m_Instance.RevertPropertyOverride(nameID);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.Material.SetFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Single value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _SetInt = new("UnityEngine.Material.SetInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _SetInteger = new("UnityEngine.Material.SetInteger", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		private static readonly LuaFunction _SetOverrideTag = new("UnityEngine.Material.SetOverrideTag", (_context, _buffer, _) =>
		{
			System.String tag;
			System.String val;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out tag) &&
					    arg2.TryRead<System.String>(out val))
					{
						_this.m_Instance.SetOverrideTag(tag, val);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetPass = new("UnityEngine.Material.SetPass", (_context, _buffer, _) =>
		{
			System.Int32 pass;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out pass))
					{
						var returnValue = _this.m_Instance.SetPass(pass);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetPropertyLock = new("UnityEngine.Material.SetPropertyLock", (_context, _buffer, _) =>
		{
			System.String name;
			System.Boolean value;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Boolean>(out value))
					{
						_this.m_Instance.SetPropertyLock(name, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Boolean>(out value))
					{
						_this.m_Instance.SetPropertyLock(nameID, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetShaderPassEnabled = new("UnityEngine.Material.SetShaderPassEnabled", (_context, _buffer, _) =>
		{
			System.String passName;
			System.Boolean enabled;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Material>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out passName) &&
					    arg2.TryRead<System.Boolean>(out enabled))
					{
						_this.m_Instance.SetShaderPassEnabled(passName, enabled);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Material.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Material>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Material instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ApplyPropertyOverride": return _ApplyPropertyOverride;
				case "ComputeCRC": return _ComputeCRC;
				case "CopyMatchingPropertiesFromMaterial": return _CopyMatchingPropertiesFromMaterial;
				case "CopyPropertiesFromMaterial": return _CopyPropertiesFromMaterial;
				case "DisableKeyword": return _DisableKeyword;
				case "EnableKeyword": return _EnableKeyword;
				case "FindPass": return _FindPass;
				case "GetFloat": return _GetFloat;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "GetInt": return _GetInt;
				case "GetInteger": return _GetInteger;
				case "GetPassName": return _GetPassName;
				case "GetShaderPassEnabled": return _GetShaderPassEnabled;
				case "GetTag": return _GetTag;
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
				case "IsChildOf": return _IsChildOf;
				case "IsKeywordEnabled": return _IsKeywordEnabled;
				case "IsPropertyLocked": return _IsPropertyLocked;
				case "IsPropertyLockedByAncestor": return _IsPropertyLockedByAncestor;
				case "IsPropertyOverriden": return _IsPropertyOverriden;
				case "Lerp": return _Lerp;
				case "RevertAllPropertyOverrides": return _RevertAllPropertyOverrides;
				case "RevertPropertyOverride": return _RevertPropertyOverride;
				case "SetFloat": return _SetFloat;
				case "SetInt": return _SetInt;
				case "SetInteger": return _SetInteger;
				case "SetOverrideTag": return _SetOverrideTag;
				case "SetPass": return _SetPass;
				case "SetPropertyLock": return _SetPropertyLock;
				case "SetShaderPassEnabled": return _SetShaderPassEnabled;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Material instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Material>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Material>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Material Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Material v) => new(v);
		public Lua_UnityEngine_Material(UnityEngine.Material instance) { m_Instance = instance; }
		private UnityEngine.Material m_Instance;
		public UnityEngine.Material Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Material_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Material" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_Material_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Material_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Material_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Material_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Material_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Material_static v) => new(v);
	}

}
