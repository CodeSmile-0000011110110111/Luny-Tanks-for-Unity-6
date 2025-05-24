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
	public class Lua_UnityEngine_TerrainData : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "TerrainData" };

		private static readonly LuaFunction _ComputeDetailCoverage = new("UnityEngine.TerrainData.ComputeDetailCoverage", (_context, _buffer, _) =>
		{
			System.Int32 detailPrototypeIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out detailPrototypeIndex))
					{
						var returnValue = _this.m_Instance.ComputeDetailCoverage(detailPrototypeIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.TerrainData.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

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

		private static readonly LuaFunction _GetHeight = new("UnityEngine.TerrainData.GetHeight", (_context, _buffer, _) =>
		{
			System.Int32 x;
			System.Int32 y;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out x) &&
					    arg2.TryRead<System.Int32>(out y))
					{
						var returnValue = _this.m_Instance.GetHeight(x, y);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.TerrainData.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

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

		private static readonly LuaFunction _GetInterpolatedHeight = new("UnityEngine.TerrainData.GetInterpolatedHeight", (_context, _buffer, _) =>
		{
			System.Single x;
			System.Single y;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Single>(out x) &&
					    arg2.TryRead<System.Single>(out y))
					{
						var returnValue = _this.m_Instance.GetInterpolatedHeight(x, y);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetSteepness = new("UnityEngine.TerrainData.GetSteepness", (_context, _buffer, _) =>
		{
			System.Single x;
			System.Single y;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Single>(out x) &&
					    arg2.TryRead<System.Single>(out y))
					{
						var returnValue = _this.m_Instance.GetSteepness(x, y);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsHole = new("UnityEngine.TerrainData.IsHole", (_context, _buffer, _) =>
		{
			System.Int32 x;
			System.Int32 y;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out x) &&
					    arg2.TryRead<System.Int32>(out y))
					{
						var returnValue = _this.m_Instance.IsHole(x, y);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RefreshPrototypes = new("UnityEngine.TerrainData.RefreshPrototypes", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RefreshPrototypes();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RemoveDetailPrototype = new("UnityEngine.TerrainData.RemoveDetailPrototype", (_context, _buffer, _) =>
		{
			System.Int32 index;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out index))
					{
						_this.m_Instance.RemoveDetailPrototype(index);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetBaseMapDirty = new("UnityEngine.TerrainData.SetBaseMapDirty", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SetBaseMapDirty();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetDetailResolution = new("UnityEngine.TerrainData.SetDetailResolution", (_context, _buffer, _) =>
		{
			System.Int32 detailResolution;
			System.Int32 resolutionPerPatch;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out detailResolution) &&
					    arg2.TryRead<System.Int32>(out resolutionPerPatch))
					{
						_this.m_Instance.SetDetailResolution(detailResolution, resolutionPerPatch);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SyncHeightmap = new("UnityEngine.TerrainData.SyncHeightmap", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SyncHeightmap();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SyncTexture = new("UnityEngine.TerrainData.SyncTexture", (_context, _buffer, _) =>
		{
			System.String textureName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out textureName))
					{
						_this.m_Instance.SyncTexture(textureName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.TerrainData.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TerrainData>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_TerrainData instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ComputeDetailCoverage": return _ComputeDetailCoverage;
				case "GetHashCode": return _GetHashCode;
				case "GetHeight": return _GetHeight;
				case "GetInstanceID": return _GetInstanceID;
				case "GetInterpolatedHeight": return _GetInterpolatedHeight;
				case "GetSteepness": return _GetSteepness;
				case "IsHole": return _IsHole;
				case "RefreshPrototypes": return _RefreshPrototypes;
				case "RemoveDetailPrototype": return _RemoveDetailPrototype;
				case "SetBaseMapDirty": return _SetBaseMapDirty;
				case "SetDetailResolution": return _SetDetailResolution;
				case "SyncHeightmap": return _SyncHeightmap;
				case "SyncTexture": return _SyncTexture;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_TerrainData instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TerrainData>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TerrainData>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_TerrainData Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_TerrainData v) => new(v);
		public Lua_UnityEngine_TerrainData(UnityEngine.TerrainData instance) { m_Instance = instance; }
		private UnityEngine.TerrainData m_Instance;
		public UnityEngine.TerrainData Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_TerrainData_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "TerrainData" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_TerrainData_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_TerrainData_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TerrainData_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TerrainData_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_TerrainData_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_TerrainData_static v) => new(v);
	}

}
