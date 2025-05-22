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

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.Camera.BroadcastMessage", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var methodName = arg1.Read<System.String>();
					_this.m_Instance.BroadcastMessage(methodName);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _CompareTag = new("UnityEngine.Camera.CompareTag", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var tag = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.CompareTag(tag);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _CopyFrom = new("UnityEngine.Camera.CopyFrom", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Camera>();
					var other = otherUserData.Instance;
					_this.m_Instance.CopyFrom(other);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.Camera.GetComponentIndex", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetComponentIndex();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetGateFittedFieldOfView = new("UnityEngine.Camera.GetGateFittedFieldOfView", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					var returnValue = _this.m_Instance.GetGateFittedFieldOfView();
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Camera.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Camera.GetInstanceID", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
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

		private static readonly LuaFunction _RemoveAllCommandBuffers = new("UnityEngine.Camera.RemoveAllCommandBuffers", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.RemoveAllCommandBuffers();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Render = new("UnityEngine.Camera.Render", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.Render();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _RenderDontRestore = new("UnityEngine.Camera.RenderDontRestore", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.RenderDontRestore();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Reset = new("UnityEngine.Camera.Reset", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.Reset();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetAspect = new("UnityEngine.Camera.ResetAspect", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetAspect();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetCullingMatrix = new("UnityEngine.Camera.ResetCullingMatrix", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetCullingMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetProjectionMatrix = new("UnityEngine.Camera.ResetProjectionMatrix", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetProjectionMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetReplacementShader = new("UnityEngine.Camera.ResetReplacementShader", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetReplacementShader();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetStereoProjectionMatrices = new("UnityEngine.Camera.ResetStereoProjectionMatrices", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetStereoProjectionMatrices();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetStereoViewMatrices = new("UnityEngine.Camera.ResetStereoViewMatrices", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetStereoViewMatrices();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetTransparencySortSettings = new("UnityEngine.Camera.ResetTransparencySortSettings", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetTransparencySortSettings();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetWorldToCameraMatrix = new("UnityEngine.Camera.ResetWorldToCameraMatrix", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ResetWorldToCameraMatrix();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.Camera.SendMessage", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var methodName = arg1.Read<System.String>();
					_this.m_Instance.SendMessage(methodName);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.Camera.SendMessageUpwards", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var methodName = arg1.Read<System.String>();
					_this.m_Instance.SendMessageUpwards(methodName);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Camera.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Camera>();
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
	}
	public sealed class Lua_UnityEngine_Camera_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Camera" };

		private static readonly LuaFunction _FieldOfViewToFocalLength = new("UnityEngine.Camera.FieldOfViewToFocalLength", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var fieldOfView = arg0.Read<System.Single>();
					var sensorSize = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Camera.FieldOfViewToFocalLength(fieldOfView, sensorSize);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _FocalLengthToFieldOfView = new("UnityEngine.Camera.FocalLengthToFieldOfView", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var focalLength = arg0.Read<System.Single>();
					var sensorSize = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Camera.FocalLengthToFieldOfView(focalLength, sensorSize);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetAllCameras = new("UnityEngine.Camera.GetAllCameras", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var camerasUserData = arg0.Read<Lua_UnityEngine_Camera>();
					var cameras = camerasUserData.Instance;
					var returnValue = UnityEngine.Camera.GetAllCameras(cameras);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _HorizontalToVerticalFieldOfView = new("UnityEngine.Camera.HorizontalToVerticalFieldOfView", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var horizontalFieldOfView = arg0.Read<System.Single>();
					var aspectRatio = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Camera.HorizontalToVerticalFieldOfView(horizontalFieldOfView, aspectRatio);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetupCurrent = new("UnityEngine.Camera.SetupCurrent", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var curUserData = arg0.Read<Lua_UnityEngine_Camera>();
					var cur = curUserData.Instance;
					UnityEngine.Camera.SetupCurrent(cur);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _VerticalToHorizontalFieldOfView = new("UnityEngine.Camera.VerticalToHorizontalFieldOfView", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var verticalFieldOfView = arg0.Read<System.Single>();
					var aspectRatio = arg1.Read<System.Single>();
					var returnValue = UnityEngine.Camera.VerticalToHorizontalFieldOfView(verticalFieldOfView, aspectRatio);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Camera_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "FieldOfViewToFocalLength": return _FieldOfViewToFocalLength;
				case "FocalLengthToFieldOfView": return _FocalLengthToFieldOfView;
				case "GetAllCameras": return _GetAllCameras;
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Camera_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
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
