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

		private static readonly LuaFunction _Equals = new("UnityEngine.Matrix4x4.Equals", (_context, _buffer, _) =>
		{
			UnityEngine.Matrix4x4 other;
			Lua_UnityEngine_Matrix4x4 other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Matrix4x4>(out other_UserData))
					{
						other = other_UserData.Instance;
						var returnValue = _this.m_Instance.Equals(other);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Matrix4x4.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();

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

		private static readonly LuaFunction _ToString = new("UnityEngine.Matrix4x4.ToString", (_context, _buffer, _) =>
		{
			System.String format;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.ToString();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				case 1:
				{
					if (arg1.TryRead<System.String>(out format))
					{
						var returnValue = _this.m_Instance.ToString(format);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ValidTRS = new("UnityEngine.Matrix4x4.ValidTRS", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Matrix4x4>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.ValidTRS();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Matrix4x4_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Matrix4x4" };

		private static readonly LuaFunction _Determinant = new("UnityEngine.Matrix4x4.Determinant", (_context, _buffer, _) =>
		{
			UnityEngine.Matrix4x4 m;
			Lua_UnityEngine_Matrix4x4 m_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Matrix4x4>(out m_UserData))
					{
						m = m_UserData.Instance;
						var returnValue = UnityEngine.Matrix4x4.Determinant(m);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Frustum = new("UnityEngine.Matrix4x4.Frustum", (_context, _buffer, _) =>
		{
			System.Single left;
			System.Single right;
			System.Single bottom;
			System.Single top;
			System.Single zNear;
			System.Single zFar;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;

			switch (argCount)
			{
				case 6:
				{
					if (arg0.TryRead<System.Single>(out left) &&
					    arg1.TryRead<System.Single>(out right) &&
					    arg2.TryRead<System.Single>(out bottom) &&
					    arg3.TryRead<System.Single>(out top) &&
					    arg4.TryRead<System.Single>(out zNear) &&
					    arg5.TryRead<System.Single>(out zFar))
					{
						var returnValue = UnityEngine.Matrix4x4.Frustum(left, right, bottom, top, zNear, zFar);
						_buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Inverse = new("UnityEngine.Matrix4x4.Inverse", (_context, _buffer, _) =>
		{
			UnityEngine.Matrix4x4 m;
			Lua_UnityEngine_Matrix4x4 m_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Matrix4x4>(out m_UserData))
					{
						m = m_UserData.Instance;
						var returnValue = UnityEngine.Matrix4x4.Inverse(m);
						_buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Inverse3DAffine = new("UnityEngine.Matrix4x4.Inverse3DAffine", (_context, _buffer, _) =>
		{
			UnityEngine.Matrix4x4 input;
			Lua_UnityEngine_Matrix4x4 input_UserData;
			UnityEngine.Matrix4x4 result;
			Lua_UnityEngine_Matrix4x4 result_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<Lua_UnityEngine_Matrix4x4>(out input_UserData) &&
					    arg1.TryRead<Lua_UnityEngine_Matrix4x4>(out result_UserData))
					{
						input = input_UserData.Instance;
						result = result_UserData.Instance;
						var returnValue = UnityEngine.Matrix4x4.Inverse3DAffine(input, ref result);
						result_UserData.Instance = result;
						_buffer.Span[0] = new LuaValue(returnValue);
						_buffer.Span[1] = arg1;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Ortho = new("UnityEngine.Matrix4x4.Ortho", (_context, _buffer, _) =>
		{
			System.Single left;
			System.Single right;
			System.Single bottom;
			System.Single top;
			System.Single zNear;
			System.Single zFar;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;

			switch (argCount)
			{
				case 6:
				{
					if (arg0.TryRead<System.Single>(out left) &&
					    arg1.TryRead<System.Single>(out right) &&
					    arg2.TryRead<System.Single>(out bottom) &&
					    arg3.TryRead<System.Single>(out top) &&
					    arg4.TryRead<System.Single>(out zNear) &&
					    arg5.TryRead<System.Single>(out zFar))
					{
						var returnValue = UnityEngine.Matrix4x4.Ortho(left, right, bottom, top, zNear, zFar);
						_buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Perspective = new("UnityEngine.Matrix4x4.Perspective", (_context, _buffer, _) =>
		{
			System.Single fov;
			System.Single aspect;
			System.Single zNear;
			System.Single zFar;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;

			switch (argCount)
			{
				case 4:
				{
					if (arg0.TryRead<System.Single>(out fov) &&
					    arg1.TryRead<System.Single>(out aspect) &&
					    arg2.TryRead<System.Single>(out zNear) &&
					    arg3.TryRead<System.Single>(out zFar))
					{
						var returnValue = UnityEngine.Matrix4x4.Perspective(fov, aspect, zNear, zFar);
						_buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Transpose = new("UnityEngine.Matrix4x4.Transpose", (_context, _buffer, _) =>
		{
			UnityEngine.Matrix4x4 m;
			Lua_UnityEngine_Matrix4x4 m_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Matrix4x4>(out m_UserData))
					{
						m = m_UserData.Instance;
						var returnValue = UnityEngine.Matrix4x4.Transpose(m);
						_buffer.Span[0] = new Lua_UnityEngine_Matrix4x4(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Matrix4x4_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
