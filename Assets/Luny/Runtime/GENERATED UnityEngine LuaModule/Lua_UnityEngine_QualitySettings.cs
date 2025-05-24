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
	public class Lua_UnityEngine_QualitySettings : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "QualitySettings" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.QualitySettings.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_QualitySettings>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.QualitySettings.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_QualitySettings>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.QualitySettings.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_QualitySettings>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_QualitySettings instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_QualitySettings instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_QualitySettings>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_QualitySettings>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_QualitySettings Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_QualitySettings v) => new(v);
		public Lua_UnityEngine_QualitySettings(UnityEngine.QualitySettings instance) { m_Instance = instance; }
		private UnityEngine.QualitySettings m_Instance;
		public UnityEngine.QualitySettings Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_QualitySettings_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "QualitySettings" };

		private static readonly LuaFunction _DecreaseLevel = new("UnityEngine.QualitySettings.DecreaseLevel", (_context, _buffer, _) =>
		{
			System.Boolean applyExpensiveChanges;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.QualitySettings.DecreaseLevel();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg0.TryRead<System.Boolean>(out applyExpensiveChanges))
					{
						UnityEngine.QualitySettings.DecreaseLevel(applyExpensiveChanges);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetActiveQualityLevelsForPlatformCount = new("UnityEngine.QualitySettings.GetActiveQualityLevelsForPlatformCount", (_context, _buffer, _) =>
		{
			System.String buildTargetGroupName;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out buildTargetGroupName))
					{
						var returnValue = UnityEngine.QualitySettings.GetActiveQualityLevelsForPlatformCount(buildTargetGroupName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetQualityLevel = new("UnityEngine.QualitySettings.GetQualityLevel", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						var returnValue = UnityEngine.QualitySettings.GetQualityLevel();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IncreaseLevel = new("UnityEngine.QualitySettings.IncreaseLevel", (_context, _buffer, _) =>
		{
			System.Boolean applyExpensiveChanges;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.QualitySettings.IncreaseLevel();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg0.TryRead<System.Boolean>(out applyExpensiveChanges))
					{
						UnityEngine.QualitySettings.IncreaseLevel(applyExpensiveChanges);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsPlatformIncluded = new("UnityEngine.QualitySettings.IsPlatformIncluded", (_context, _buffer, _) =>
		{
			System.String buildTargetGroupName;
			System.Int32 index;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.String>(out buildTargetGroupName) &&
					    arg1.TryRead<System.Int32>(out index))
					{
						var returnValue = UnityEngine.QualitySettings.IsPlatformIncluded(buildTargetGroupName, index);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetLODSettings = new("UnityEngine.QualitySettings.SetLODSettings", (_context, _buffer, _) =>
		{
			System.Single lodBias;
			System.Int32 maximumLODLevel;
			System.Boolean setDirty = true;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;

			switch (argCount)
			{
				case 3:
				{
					if (arg0.TryRead<System.Single>(out lodBias) &&
					    arg1.TryRead<System.Int32>(out maximumLODLevel) &&
					    arg2.TryRead<System.Boolean>(out setDirty))
					{
						UnityEngine.QualitySettings.SetLODSettings(lodBias, maximumLODLevel, setDirty);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetQualityLevel = new("UnityEngine.QualitySettings.SetQualityLevel", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Boolean applyExpensiveChanges;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.Int32>(out index))
					{
						UnityEngine.QualitySettings.SetQualityLevel(index);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out index) &&
					    arg1.TryRead<System.Boolean>(out applyExpensiveChanges))
					{
						UnityEngine.QualitySettings.SetQualityLevel(index, applyExpensiveChanges);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_QualitySettings_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "DecreaseLevel": return _DecreaseLevel;
				case "GetActiveQualityLevelsForPlatformCount": return _GetActiveQualityLevelsForPlatformCount;
				case "GetQualityLevel": return _GetQualityLevel;
				case "IncreaseLevel": return _IncreaseLevel;
				case "IsPlatformIncluded": return _IsPlatformIncluded;
				case "SetLODSettings": return _SetLODSettings;
				case "SetQualityLevel": return _SetQualityLevel;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_QualitySettings_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_QualitySettings_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_QualitySettings_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_QualitySettings_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_QualitySettings_static v) => new(v);
	}

}
