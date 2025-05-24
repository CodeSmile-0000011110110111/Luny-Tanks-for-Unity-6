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
	public class Lua_UnityEngine_RenderTexture : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RenderTexture" };

		private static readonly LuaFunction _ApplyDynamicScale = new("UnityEngine.RenderTexture.ApplyDynamicScale", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _Create = new("UnityEngine.RenderTexture.Create", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _DiscardContents = new("UnityEngine.RenderTexture.DiscardContents", (_context, _buffer, _) =>
		{
			System.Boolean discardColor;
			System.Boolean discardDepth;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _GenerateMips = new("UnityEngine.RenderTexture.GenerateMips", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.RenderTexture.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.RenderTexture.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _IncrementUpdateCount = new("UnityEngine.RenderTexture.IncrementUpdateCount", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _IsCreated = new("UnityEngine.RenderTexture.IsCreated", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _Release = new("UnityEngine.RenderTexture.Release", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _ResolveAntiAliasedSurface = new("UnityEngine.RenderTexture.ResolveAntiAliasedSurface", (_context, _buffer, _) =>
		{
			UnityEngine.RenderTexture target;
			Lua_UnityEngine_RenderTexture target_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResolveAntiAliasedSurface();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_RenderTexture>(out target_UserData))
					{
						target = target_UserData.Instance;
						_this.m_Instance.ResolveAntiAliasedSurface(target);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGlobalShaderProperty = new("UnityEngine.RenderTexture.SetGlobalShaderProperty", (_context, _buffer, _) =>
		{
			System.String propertyName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.RenderTexture.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_RenderTexture>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_RenderTexture instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ApplyDynamicScale": return _ApplyDynamicScale;
				case "Create": return _Create;
				case "DiscardContents": return _DiscardContents;
				case "GenerateMips": return _GenerateMips;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "IncrementUpdateCount": return _IncrementUpdateCount;
				case "IsCreated": return _IsCreated;
				case "Release": return _Release;
				case "ResolveAntiAliasedSurface": return _ResolveAntiAliasedSurface;
				case "SetGlobalShaderProperty": return _SetGlobalShaderProperty;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RenderTexture instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderTexture>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderTexture>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RenderTexture Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RenderTexture v) => new(v);
		public Lua_UnityEngine_RenderTexture(UnityEngine.RenderTexture instance) { m_Instance = instance; }
		private UnityEngine.RenderTexture m_Instance;
		public UnityEngine.RenderTexture Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_RenderTexture_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "RenderTexture" };

		private static readonly LuaFunction _GetTemporary = new("UnityEngine.RenderTexture.GetTemporary", (_context, _buffer, _) =>
		{
			System.Int32 width;
			System.Int32 height;
			System.Int32 depthBuffer;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out width) &&
					    arg1.TryRead<System.Int32>(out height))
					{
						var returnValue = UnityEngine.RenderTexture.GetTemporary(width, height);
						_buffer.Span[0] = new Lua_UnityEngine_RenderTexture(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg0.TryRead<System.Int32>(out width) &&
					    arg1.TryRead<System.Int32>(out height) &&
					    arg2.TryRead<System.Int32>(out depthBuffer))
					{
						var returnValue = UnityEngine.RenderTexture.GetTemporary(width, height, depthBuffer);
						_buffer.Span[0] = new Lua_UnityEngine_RenderTexture(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ReleaseTemporary = new("UnityEngine.RenderTexture.ReleaseTemporary", (_context, _buffer, _) =>
		{
			UnityEngine.RenderTexture temp;
			Lua_UnityEngine_RenderTexture temp_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_RenderTexture>(out temp_UserData))
					{
						temp = temp_UserData.Instance;
						UnityEngine.RenderTexture.ReleaseTemporary(temp);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SupportsStencil = new("UnityEngine.RenderTexture.SupportsStencil", (_context, _buffer, _) =>
		{
			UnityEngine.RenderTexture rt;
			Lua_UnityEngine_RenderTexture rt_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_RenderTexture>(out rt_UserData))
					{
						rt = rt_UserData.Instance;
						var returnValue = UnityEngine.RenderTexture.SupportsStencil(rt);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_RenderTexture_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetTemporary": return _GetTemporary;
				case "ReleaseTemporary": return _ReleaseTemporary;
				case "SupportsStencil": return _SupportsStencil;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_RenderTexture_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderTexture_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_RenderTexture_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_RenderTexture_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_RenderTexture_static v) => new(v);
	}

}
