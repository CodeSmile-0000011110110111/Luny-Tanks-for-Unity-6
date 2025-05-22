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

		private static readonly LuaFunction _DisableKeyword = new("UnityEngine.ComputeShader.DisableKeyword", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keyword = arg1.Read<System.String>();
					_this.m_Instance.DisableKeyword(keyword);
					return new ValueTask<Int32>(0);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keywordUserData = arg1.Read<Lua_UnityEngine_Rendering_LocalKeyword>();
					var keyword = keywordUserData.Instance;
					_this.m_Instance.DisableKeyword(ref keyword);
					keywordUserData.Instance = keyword;
					buffer.Span[0] = arg1;
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Dispatch = new("UnityEngine.ComputeShader.Dispatch", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var kernelIndex = arg1.Read<System.Int32>();
					var threadGroupsX = arg2.Read<System.Int32>();
					var threadGroupsY = arg3.Read<System.Int32>();
					var threadGroupsZ = arg4.Read<System.Int32>();
					_this.m_Instance.Dispatch(kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _EnableKeyword = new("UnityEngine.ComputeShader.EnableKeyword", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keywordUserData = arg1.Read<Lua_UnityEngine_Rendering_LocalKeyword>();
					var keyword = keywordUserData.Instance;
					_this.m_Instance.EnableKeyword(ref keyword);
					keywordUserData.Instance = keyword;
					buffer.Span[0] = arg1;
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keyword = arg1.Read<System.String>();
					_this.m_Instance.EnableKeyword(keyword);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _FindKernel = new("UnityEngine.ComputeShader.FindKernel", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.FindKernel(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ComputeShader.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetHashCode();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.ComputeShader.GetInstanceID", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetInstanceID();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetKernelThreadGroupSizes = new("UnityEngine.ComputeShader.GetKernelThreadGroupSizes", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var kernelIndex = arg1.Read<System.Int32>();
					var x = arg2.Read<System.UInt32>();
					var y = arg3.Read<System.UInt32>();
					var z = arg4.Read<System.UInt32>();
					_this.m_Instance.GetKernelThreadGroupSizes(kernelIndex, out x, out y, out z);
					buffer.Span[0] = arg2;
					buffer.Span[1] = arg3;
					buffer.Span[2] = arg4;
					return new ValueTask<Int32>(3);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _HasKernel = new("UnityEngine.ComputeShader.HasKernel", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.HasKernel(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsKeywordEnabled = new("UnityEngine.ComputeShader.IsKeywordEnabled", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keyword = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.IsKeywordEnabled(keyword);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var keywordUserData = arg1.Read<Lua_UnityEngine_Rendering_LocalKeyword>();
					var keyword = keywordUserData.Instance;
					var returnValue = _this.m_Instance.IsKeywordEnabled(ref keyword);
					keywordUserData.Instance = keyword;
					buffer.Span[0] = new LuaValue(returnValue);
					buffer.Span[1] = arg1;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsSupported = new("UnityEngine.ComputeShader.IsSupported", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var kernelIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.IsSupported(kernelIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetBool = new("UnityEngine.ComputeShader.SetBool", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var val = arg2.Read<System.Boolean>();
					_this.m_Instance.SetBool(name, val);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var nameID = arg1.Read<System.Int32>();
					var val = arg2.Read<System.Boolean>();
					_this.m_Instance.SetBool(nameID, val);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.ComputeShader.SetFloat", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var nameID = arg1.Read<System.Int32>();
					var val = arg2.Read<System.Single>();
					_this.m_Instance.SetFloat(nameID, val);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var val = arg2.Read<System.Single>();
					_this.m_Instance.SetFloat(name, val);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetFloats = new("UnityEngine.ComputeShader.SetFloats", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var nameID = arg1.Read<System.Int32>();
					var values = arg2.Read<System.Single>();
					_this.m_Instance.SetFloats(nameID, values);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var values = arg2.Read<System.Single>();
					_this.m_Instance.SetFloats(name, values);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetInt = new("UnityEngine.ComputeShader.SetInt", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var nameID = arg1.Read<System.Int32>();
					var val = arg2.Read<System.Int32>();
					_this.m_Instance.SetInt(nameID, val);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var val = arg2.Read<System.Int32>();
					_this.m_Instance.SetInt(name, val);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetInts = new("UnityEngine.ComputeShader.SetInts", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var nameID = arg1.Read<System.Int32>();
					var values = arg2.Read<System.Int32>();
					_this.m_Instance.SetInts(nameID, values);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var values = arg2.Read<System.Int32>();
					_this.m_Instance.SetInts(name, values);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetKeyword = new("UnityEngine.ComputeShader.SetKeyword", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var keywordUserData = arg1.Read<Lua_UnityEngine_Rendering_LocalKeyword>();
					var value = arg2.Read<System.Boolean>();
					var keyword = keywordUserData.Instance;
					_this.m_Instance.SetKeyword(ref keyword, value);
					keywordUserData.Instance = keyword;
					buffer.Span[0] = arg1;
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetTextureFromGlobal = new("UnityEngine.ComputeShader.SetTextureFromGlobal", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var kernelIndex = arg1.Read<System.Int32>();
					var nameID = arg2.Read<System.Int32>();
					var globalTextureNameID = arg3.Read<System.Int32>();
					_this.m_Instance.SetTextureFromGlobal(kernelIndex, nameID, globalTextureNameID);
					return new ValueTask<Int32>(0);
				}
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var kernelIndex = arg1.Read<System.Int32>();
					var name = arg2.Read<System.String>();
					var globalTextureName = arg3.Read<System.String>();
					_this.m_Instance.SetTextureFromGlobal(kernelIndex, name, globalTextureName);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ComputeShader.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ComputeShader>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ToString();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
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
				case "SetFloats": return _SetFloats;
				case "SetInt": return _SetInt;
				case "SetInts": return _SetInts;
				case "SetKeyword": return _SetKeyword;
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ComputeShader_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
