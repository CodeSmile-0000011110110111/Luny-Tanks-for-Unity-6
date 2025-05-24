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
	public class Lua_UnityEngine_ComputeShader : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ComputeShader" };

		private static readonly LuaFunction _DisableKeyword = new("UnityEngine.ComputeShader.DisableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		private static readonly LuaFunction _Dispatch = new("UnityEngine.ComputeShader.Dispatch", (_context, _buffer, _) =>
		{
			System.Int32 kernelIndex;
			System.Int32 threadGroupsX;
			System.Int32 threadGroupsY;
			System.Int32 threadGroupsZ;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 4:
				{
					if (arg1.TryRead<System.Int32>(out kernelIndex) &&
					    arg2.TryRead<System.Int32>(out threadGroupsX) &&
					    arg3.TryRead<System.Int32>(out threadGroupsY) &&
					    arg4.TryRead<System.Int32>(out threadGroupsZ))
					{
						_this.m_Instance.Dispatch(kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _EnableKeyword = new("UnityEngine.ComputeShader.EnableKeyword", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		private static readonly LuaFunction _FindKernel = new("UnityEngine.ComputeShader.FindKernel", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.FindKernel(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ComputeShader.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.ComputeShader.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		private static readonly LuaFunction _GetKernelThreadGroupSizes = new("UnityEngine.ComputeShader.GetKernelThreadGroupSizes", (_context, _buffer, _) =>
		{
			System.Int32 kernelIndex;
			System.UInt32 x;
			System.UInt32 y;
			System.UInt32 z;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 4:
				{
					if (arg1.TryRead<System.Int32>(out kernelIndex) &&
					    arg2.TryRead<System.UInt32>(out x) &&
					    arg3.TryRead<System.UInt32>(out y) &&
					    arg4.TryRead<System.UInt32>(out z))
					{
						_this.m_Instance.GetKernelThreadGroupSizes(kernelIndex, out x, out y, out z);
						_buffer.Span[0] = arg2;
						_buffer.Span[1] = arg3;
						_buffer.Span[2] = arg4;
						return new ValueTask<Int32>(3);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasKernel = new("UnityEngine.ComputeShader.HasKernel", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.HasKernel(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsKeywordEnabled = new("UnityEngine.ComputeShader.IsKeywordEnabled", (_context, _buffer, _) =>
		{
			System.String keyword;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		private static readonly LuaFunction _IsSupported = new("UnityEngine.ComputeShader.IsSupported", (_context, _buffer, _) =>
		{
			System.Int32 kernelIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out kernelIndex))
					{
						var returnValue = _this.m_Instance.IsSupported(kernelIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetBool = new("UnityEngine.ComputeShader.SetBool", (_context, _buffer, _) =>
		{
			System.String name;
			System.Boolean val;
			System.Int32 nameID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Boolean>(out val))
					{
						_this.m_Instance.SetBool(name, val);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Boolean>(out val))
					{
						_this.m_Instance.SetBool(nameID, val);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.ComputeShader.SetFloat", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Single val;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Single>(out val))
					{
						_this.m_Instance.SetFloat(nameID, val);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Single>(out val))
					{
						_this.m_Instance.SetFloat(name, val);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetInt = new("UnityEngine.ComputeShader.SetInt", (_context, _buffer, _) =>
		{
			System.Int32 nameID;
			System.Int32 val;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out nameID) &&
					    arg2.TryRead<System.Int32>(out val))
					{
						_this.m_Instance.SetInt(nameID, val);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Int32>(out val))
					{
						_this.m_Instance.SetInt(name, val);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetTextureFromGlobal = new("UnityEngine.ComputeShader.SetTextureFromGlobal", (_context, _buffer, _) =>
		{
			System.Int32 kernelIndex;
			System.Int32 nameID;
			System.Int32 globalTextureNameID;
			System.String name;
			System.String globalTextureName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out kernelIndex) &&
					    arg2.TryRead<System.Int32>(out nameID) &&
					    arg3.TryRead<System.Int32>(out globalTextureNameID))
					{
						_this.m_Instance.SetTextureFromGlobal(kernelIndex, nameID, globalTextureNameID);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out kernelIndex) &&
					    arg2.TryRead<System.String>(out name) &&
					    arg3.TryRead<System.String>(out globalTextureName))
					{
						_this.m_Instance.SetTextureFromGlobal(kernelIndex, name, globalTextureName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ComputeShader.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_ComputeShader instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "DisableKeyword": return _DisableKeyword;
				case "Dispatch": return _Dispatch;
				case "EnableKeyword": return _EnableKeyword;
				case "FindKernel": return _FindKernel;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "GetKernelThreadGroupSizes": return _GetKernelThreadGroupSizes;
				case "HasKernel": return _HasKernel;
				case "IsKeywordEnabled": return _IsKeywordEnabled;
				case "IsSupported": return _IsSupported;
				case "SetBool": return _SetBool;
				case "SetFloat": return _SetFloat;
				case "SetInt": return _SetInt;
				case "SetTextureFromGlobal": return _SetTextureFromGlobal;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ComputeShader instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ComputeShader Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ComputeShader v) => new(v);
		public Lua_UnityEngine_ComputeShader(UnityEngine.ComputeShader instance) { m_Instance = instance; }
		private UnityEngine.ComputeShader m_Instance;
		public UnityEngine.ComputeShader Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_ComputeShader_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ComputeShader" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_ComputeShader_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ComputeShader_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ComputeShader_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ComputeShader_static v) => new(v);
	}

}
