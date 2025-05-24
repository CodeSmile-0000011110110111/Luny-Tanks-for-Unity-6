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
	public class Lua_UnityEngine_CustomRenderTexture : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "CustomRenderTexture" };

		private static readonly LuaFunction _ApplyDynamicScale = new("UnityEngine.CustomRenderTexture.ApplyDynamicScale", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ApplyDynamicScale();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClearUpdateZones = new("UnityEngine.CustomRenderTexture.ClearUpdateZones", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearUpdateZones();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Create = new("UnityEngine.CustomRenderTexture.Create", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.Create();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DiscardContents = new("UnityEngine.CustomRenderTexture.DiscardContents", (_context, _buffer, _) =>
		{
			System.Boolean discardColor;
			System.Boolean discardDepth;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.DiscardContents();
						return new ValueTask<Int32>(0);
				}
				case 2:
				{
					if (arg1.TryRead<System.Boolean>(out discardColor) &&
					    arg2.TryRead<System.Boolean>(out discardDepth))
					{
						_this.m_Instance.DiscardContents(discardColor, discardDepth);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _EnsureDoubleBufferConsistency = new("UnityEngine.CustomRenderTexture.EnsureDoubleBufferConsistency", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.EnsureDoubleBufferConsistency();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GenerateMips = new("UnityEngine.CustomRenderTexture.GenerateMips", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.GenerateMips();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.CustomRenderTexture.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.CustomRenderTexture.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

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

		private static readonly LuaFunction _IncrementUpdateCount = new("UnityEngine.CustomRenderTexture.IncrementUpdateCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.IncrementUpdateCount();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Initialize = new("UnityEngine.CustomRenderTexture.Initialize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Initialize();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsCreated = new("UnityEngine.CustomRenderTexture.IsCreated", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.IsCreated();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Release = new("UnityEngine.CustomRenderTexture.Release", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

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

		private static readonly LuaFunction _ResolveAntiAliasedSurface = new("UnityEngine.CustomRenderTexture.ResolveAntiAliasedSurface", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResolveAntiAliasedSurface();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGlobalShaderProperty = new("UnityEngine.CustomRenderTexture.SetGlobalShaderProperty", (_context, _buffer, _) =>
		{
			System.String propertyName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out propertyName))
					{
						_this.m_Instance.SetGlobalShaderProperty(propertyName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.CustomRenderTexture.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

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

		private static readonly LuaFunction _Update = new("UnityEngine.CustomRenderTexture.Update", (_context, _buffer, _) =>
		{
			System.Int32 count;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_CustomRenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Update();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out count))
					{
						_this.m_Instance.Update(count);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_CustomRenderTexture instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ApplyDynamicScale": return _ApplyDynamicScale;
				case "ClearUpdateZones": return _ClearUpdateZones;
				case "Create": return _Create;
				case "DiscardContents": return _DiscardContents;
				case "EnsureDoubleBufferConsistency": return _EnsureDoubleBufferConsistency;
				case "GenerateMips": return _GenerateMips;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "IncrementUpdateCount": return _IncrementUpdateCount;
				case "Initialize": return _Initialize;
				case "IsCreated": return _IsCreated;
				case "Release": return _Release;
				case "ResolveAntiAliasedSurface": return _ResolveAntiAliasedSurface;
				case "SetGlobalShaderProperty": return _SetGlobalShaderProperty;
				case "ToString": return _ToString;
				case "Update": return _Update;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_CustomRenderTexture instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_CustomRenderTexture>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_CustomRenderTexture>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_CustomRenderTexture Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_CustomRenderTexture v) => new(v);
		public Lua_UnityEngine_CustomRenderTexture(UnityEngine.CustomRenderTexture instance) { m_Instance = instance; }
		private UnityEngine.CustomRenderTexture m_Instance;
		public UnityEngine.CustomRenderTexture Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_CustomRenderTexture_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "CustomRenderTexture" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_CustomRenderTexture_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_CustomRenderTexture_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_CustomRenderTexture_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_CustomRenderTexture_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_CustomRenderTexture_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_CustomRenderTexture_static v) => new(v);
	}

}
