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
	public class Lua_UnityEngine_GL : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "GL" };

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.GL.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GL>();
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

		private static readonly LuaFunction _ToString = new("UnityEngine.GL.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_GL>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_GL instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "GetHashCode": return _GetHashCode;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_GL instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GL>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GL>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_GL Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_GL v) => new(v);
		public Lua_UnityEngine_GL(UnityEngine.GL instance) { m_Instance = instance; }
		private UnityEngine.GL m_Instance;
		public UnityEngine.GL Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_GL_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "GL" };

		private static readonly LuaFunction _Begin = new("UnityEngine.GL.Begin", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var mode = arg0.Read<System.Int32>();
					UnityEngine.GL.Begin(mode);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _End = new("UnityEngine.GL.End", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.End();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Flush = new("UnityEngine.GL.Flush", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.Flush();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _InvalidateState = new("UnityEngine.GL.InvalidateState", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.InvalidateState();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IssuePluginEvent = new("UnityEngine.GL.IssuePluginEvent", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var callback = arg0.Read<System.IntPtr>();
					var eventID = arg1.Read<System.Int32>();
					UnityEngine.GL.IssuePluginEvent(callback, eventID);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LoadIdentity = new("UnityEngine.GL.LoadIdentity", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.LoadIdentity();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LoadOrtho = new("UnityEngine.GL.LoadOrtho", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.LoadOrtho();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _LoadPixelMatrix = new("UnityEngine.GL.LoadPixelMatrix", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.LoadPixelMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MultiTexCoord2 = new("UnityEngine.GL.MultiTexCoord2", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var unit = arg0.Read<System.Int32>();
					var x = arg1.Read<System.Single>();
					var y = arg2.Read<System.Single>();
					UnityEngine.GL.MultiTexCoord2(unit, x, y);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _MultiTexCoord3 = new("UnityEngine.GL.MultiTexCoord3", (context, buffer, ct) =>
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
					var unit = arg0.Read<System.Int32>();
					var x = arg1.Read<System.Single>();
					var y = arg2.Read<System.Single>();
					var z = arg3.Read<System.Single>();
					UnityEngine.GL.MultiTexCoord3(unit, x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PopMatrix = new("UnityEngine.GL.PopMatrix", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.PopMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PushMatrix = new("UnityEngine.GL.PushMatrix", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.PushMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RenderTargetBarrier = new("UnityEngine.GL.RenderTargetBarrier", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					UnityEngine.GL.RenderTargetBarrier();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _TexCoord2 = new("UnityEngine.GL.TexCoord2", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					UnityEngine.GL.TexCoord2(x, y);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _TexCoord3 = new("UnityEngine.GL.TexCoord3", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var z = arg2.Read<System.Single>();
					UnityEngine.GL.TexCoord3(x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Vertex3 = new("UnityEngine.GL.Vertex3", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var x = arg0.Read<System.Single>();
					var y = arg1.Read<System.Single>();
					var z = arg2.Read<System.Single>();
					UnityEngine.GL.Vertex3(x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_GL_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Begin": return _Begin;
				case "End": return _End;
				case "Flush": return _Flush;
				case "InvalidateState": return _InvalidateState;
				case "IssuePluginEvent": return _IssuePluginEvent;
				case "LoadIdentity": return _LoadIdentity;
				case "LoadOrtho": return _LoadOrtho;
				case "LoadPixelMatrix": return _LoadPixelMatrix;
				case "MultiTexCoord2": return _MultiTexCoord2;
				case "MultiTexCoord3": return _MultiTexCoord3;
				case "PopMatrix": return _PopMatrix;
				case "PushMatrix": return _PushMatrix;
				case "RenderTargetBarrier": return _RenderTargetBarrier;
				case "TexCoord2": return _TexCoord2;
				case "TexCoord3": return _TexCoord3;
				case "Vertex3": return _Vertex3;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_GL_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GL_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_GL_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_GL_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_GL_static v) => new(v);
	}

}
