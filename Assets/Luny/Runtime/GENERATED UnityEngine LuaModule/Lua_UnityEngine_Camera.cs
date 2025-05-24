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
	public class Lua_UnityEngine_Camera : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Camera" };

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.Camera.BroadcastMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out methodName))
					{
						_this.m_Instance.BroadcastMessage(methodName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CompareTag = new("UnityEngine.Camera.CompareTag", (_context, _buffer, _) =>
		{
			System.String tag;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out tag))
					{
						var returnValue = _this.m_Instance.CompareTag(tag);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CopyFrom = new("UnityEngine.Camera.CopyFrom", (_context, _buffer, _) =>
		{
			UnityEngine.Camera other;
			Lua_UnityEngine_Camera other_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<Lua_UnityEngine_Camera>(out other_UserData))
					{
						other = other_UserData.Instance;
						_this.m_Instance.CopyFrom(other);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.Camera.GetComponentIndex", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetComponentIndex();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetGateFittedFieldOfView = new("UnityEngine.Camera.GetGateFittedFieldOfView", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.GetGateFittedFieldOfView();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Camera.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Camera.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

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

		private static readonly LuaFunction _RemoveAllCommandBuffers = new("UnityEngine.Camera.RemoveAllCommandBuffers", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RemoveAllCommandBuffers();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Render = new("UnityEngine.Camera.Render", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Render();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RenderDontRestore = new("UnityEngine.Camera.RenderDontRestore", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RenderDontRestore();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Reset = new("UnityEngine.Camera.Reset", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Reset();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetAspect = new("UnityEngine.Camera.ResetAspect", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetAspect();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetCullingMatrix = new("UnityEngine.Camera.ResetCullingMatrix", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetCullingMatrix();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetProjectionMatrix = new("UnityEngine.Camera.ResetProjectionMatrix", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetProjectionMatrix();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetReplacementShader = new("UnityEngine.Camera.ResetReplacementShader", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetReplacementShader();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetStereoProjectionMatrices = new("UnityEngine.Camera.ResetStereoProjectionMatrices", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetStereoProjectionMatrices();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetStereoViewMatrices = new("UnityEngine.Camera.ResetStereoViewMatrices", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetStereoViewMatrices();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetTransparencySortSettings = new("UnityEngine.Camera.ResetTransparencySortSettings", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetTransparencySortSettings();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetWorldToCameraMatrix = new("UnityEngine.Camera.ResetWorldToCameraMatrix", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ResetWorldToCameraMatrix();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.Camera.SendMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out methodName))
					{
						_this.m_Instance.SendMessage(methodName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.Camera.SendMessageUpwards", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out methodName))
					{
						_this.m_Instance.SendMessageUpwards(methodName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Camera.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();

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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Camera instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "BroadcastMessage": return _BroadcastMessage;
				case "CompareTag": return _CompareTag;
				case "CopyFrom": return _CopyFrom;
				case "GetComponentIndex": return _GetComponentIndex;
				case "GetGateFittedFieldOfView": return _GetGateFittedFieldOfView;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "RemoveAllCommandBuffers": return _RemoveAllCommandBuffers;
				case "Render": return _Render;
				case "RenderDontRestore": return _RenderDontRestore;
				case "Reset": return _Reset;
				case "ResetAspect": return _ResetAspect;
				case "ResetCullingMatrix": return _ResetCullingMatrix;
				case "ResetProjectionMatrix": return _ResetProjectionMatrix;
				case "ResetReplacementShader": return _ResetReplacementShader;
				case "ResetStereoProjectionMatrices": return _ResetStereoProjectionMatrices;
				case "ResetStereoViewMatrices": return _ResetStereoViewMatrices;
				case "ResetTransparencySortSettings": return _ResetTransparencySortSettings;
				case "ResetWorldToCameraMatrix": return _ResetWorldToCameraMatrix;
				case "SendMessage": return _SendMessage;
				case "SendMessageUpwards": return _SendMessageUpwards;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Camera instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Camera Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Camera v) => new(v);
		public Lua_UnityEngine_Camera(UnityEngine.Camera instance) { m_Instance = instance; }
		private UnityEngine.Camera m_Instance;
		public UnityEngine.Camera Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Camera_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Camera" };

		private static readonly LuaFunction _FieldOfViewToFocalLength = new("UnityEngine.Camera.FieldOfViewToFocalLength", (_context, _buffer, _) =>
		{
			System.Single fieldOfView;
			System.Single sensorSize;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Single>(out fieldOfView) &&
					    arg1.TryRead<System.Single>(out sensorSize))
					{
						var returnValue = UnityEngine.Camera.FieldOfViewToFocalLength(fieldOfView, sensorSize);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _FocalLengthToFieldOfView = new("UnityEngine.Camera.FocalLengthToFieldOfView", (_context, _buffer, _) =>
		{
			System.Single focalLength;
			System.Single sensorSize;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Single>(out focalLength) &&
					    arg1.TryRead<System.Single>(out sensorSize))
					{
						var returnValue = UnityEngine.Camera.FocalLengthToFieldOfView(focalLength, sensorSize);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HorizontalToVerticalFieldOfView = new("UnityEngine.Camera.HorizontalToVerticalFieldOfView", (_context, _buffer, _) =>
		{
			System.Single horizontalFieldOfView;
			System.Single aspectRatio;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Single>(out horizontalFieldOfView) &&
					    arg1.TryRead<System.Single>(out aspectRatio))
					{
						var returnValue = UnityEngine.Camera.HorizontalToVerticalFieldOfView(horizontalFieldOfView, aspectRatio);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetupCurrent = new("UnityEngine.Camera.SetupCurrent", (_context, _buffer, _) =>
		{
			UnityEngine.Camera cur;
			Lua_UnityEngine_Camera cur_UserData;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<Lua_UnityEngine_Camera>(out cur_UserData))
					{
						cur = cur_UserData.Instance;
						UnityEngine.Camera.SetupCurrent(cur);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _VerticalToHorizontalFieldOfView = new("UnityEngine.Camera.VerticalToHorizontalFieldOfView", (_context, _buffer, _) =>
		{
			System.Single verticalFieldOfView;
			System.Single aspectRatio;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Single>(out verticalFieldOfView) &&
					    arg1.TryRead<System.Single>(out aspectRatio))
					{
						var returnValue = UnityEngine.Camera.VerticalToHorizontalFieldOfView(verticalFieldOfView, aspectRatio);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Camera_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "FieldOfViewToFocalLength": return _FieldOfViewToFocalLength;
				case "FocalLengthToFieldOfView": return _FocalLengthToFieldOfView;
				case "HorizontalToVerticalFieldOfView": return _HorizontalToVerticalFieldOfView;
				case "SetupCurrent": return _SetupCurrent;
				case "VerticalToHorizontalFieldOfView": return _VerticalToHorizontalFieldOfView;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Camera_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Camera_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Camera_static v) => new(v);
	}

}
