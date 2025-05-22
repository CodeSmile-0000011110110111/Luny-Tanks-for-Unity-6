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
	public struct Lua_UnityEngine_Matrix4x4 : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Matrix4x4" };

		private static readonly LuaFunction _Equals = new("UnityEngine.Matrix4x4.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Matrix4x4>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Matrix4x4.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.Matrix4x4.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var format = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.ToString(format);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ValidTRS = new("UnityEngine.Matrix4x4.ValidTRS", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.ValidTRS();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Matrix4x4 instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				case "ValidTRS": return _ValidTRS;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Matrix4x4 instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Matrix4x4 Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Matrix4x4 v) => new(v);
		public Lua_UnityEngine_Matrix4x4(UnityEngine.Matrix4x4 instance) { m_Instance = instance; }
		private UnityEngine.Matrix4x4 m_Instance;
		public UnityEngine.Matrix4x4 Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Matrix4x4 Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Matrix4x4_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Matrix4x4" };

		private static readonly LuaFunction _Determinant = new("UnityEngine.Matrix4x4.Determinant", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var mUserData = arg0.Read<Lua_UnityEngine_Matrix4x4>();
					var m = mUserData.Instance;
					var returnValue = UnityEngine.Matrix4x4.Determinant(m);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Frustum = new("UnityEngine.Matrix4x4.Frustum", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 6:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var left = arg0.Read<System.Single>();
					var right = arg1.Read<System.Single>();
					var bottom = arg2.Read<System.Single>();
					var top = arg3.Read<System.Single>();
					var zNear = arg4.Read<System.Single>();
					var zFar = arg5.Read<System.Single>();
					var returnValue = UnityEngine.Matrix4x4.Frustum(left, right, bottom, top, zNear, zFar);
					buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Inverse = new("UnityEngine.Matrix4x4.Inverse", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var mUserData = arg0.Read<Lua_UnityEngine_Matrix4x4>();
					var m = mUserData.Instance;
					var returnValue = UnityEngine.Matrix4x4.Inverse(m);
					buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Inverse3DAffine = new("UnityEngine.Matrix4x4.Inverse3DAffine", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var inputUserData = arg0.Read<Lua_UnityEngine_Matrix4x4>();
					var resultUserData = arg1.Read<Lua_UnityEngine_Matrix4x4>();
					var input = inputUserData.Instance;
					var result = resultUserData.Instance;
					var returnValue = UnityEngine.Matrix4x4.Inverse3DAffine(input, ref result);
					resultUserData.Instance = result;
					buffer.Span[0] = new LuaValue(returnValue);
					buffer.Span[1] = arg1;
					return new ValueTask<Int32>(2);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Ortho = new("UnityEngine.Matrix4x4.Ortho", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 6:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var left = arg0.Read<System.Single>();
					var right = arg1.Read<System.Single>();
					var bottom = arg2.Read<System.Single>();
					var top = arg3.Read<System.Single>();
					var zNear = arg4.Read<System.Single>();
					var zFar = arg5.Read<System.Single>();
					var returnValue = UnityEngine.Matrix4x4.Ortho(left, right, bottom, top, zNear, zFar);
					buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Perspective = new("UnityEngine.Matrix4x4.Perspective", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var fov = arg0.Read<System.Single>();
					var aspect = arg1.Read<System.Single>();
					var zNear = arg2.Read<System.Single>();
					var zFar = arg3.Read<System.Single>();
					var returnValue = UnityEngine.Matrix4x4.Perspective(fov, aspect, zNear, zFar);
					buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Transpose = new("UnityEngine.Matrix4x4.Transpose", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var mUserData = arg0.Read<Lua_UnityEngine_Matrix4x4>();
					var m = mUserData.Instance;
					var returnValue = UnityEngine.Matrix4x4.Transpose(m);
					buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Matrix4x4_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Determinant": return _Determinant;
				case "Frustum": return _Frustum;
				case "Inverse": return _Inverse;
				case "Inverse3DAffine": return _Inverse3DAffine;
				case "Ortho": return _Ortho;
				case "Perspective": return _Perspective;
				case "Transpose": return _Transpose;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Matrix4x4_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Matrix4x4_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Matrix4x4_static v) => new(v);
	}

}
