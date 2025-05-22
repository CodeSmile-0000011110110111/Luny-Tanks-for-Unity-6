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
	public class Lua_UnityEngine_Animator : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Animator" };

		private static readonly LuaFunction _ApplyBuiltinRootMotion = new("UnityEngine.Animator.ApplyBuiltinRootMotion", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.ApplyBuiltinRootMotion();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.Animator.BroadcastMessage", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _CompareTag = new("UnityEngine.Animator.CompareTag", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _CrossFade = new("UnityEngine.Animator.CrossFade", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 5:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var stateName = arg1.Read<System.String>();
					var normalizedTransitionDuration = arg2.Read<System.Single>();
					var layer = arg3.Read<System.Int32>();
					var normalizedTimeOffset = arg4.Read<System.Single>();
					var normalizedTransitionTime = arg5.Read<System.Single>();
					_this.m_Instance.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
					return new ValueTask<Int32>(0);
				}
				case 5:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var arg5 = context.GetArgument(5);
					var stateHashName = arg1.Read<System.Int32>();
					var normalizedTransitionDuration = arg2.Read<System.Single>();
					var layer = arg3.Read<System.Int32>();
					var normalizedTimeOffset = arg4.Read<System.Single>();
					var normalizedTransitionTime = arg5.Read<System.Single>();
					_this.m_Instance.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _CrossFadeInFixedTime = new("UnityEngine.Animator.CrossFadeInFixedTime", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 4:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var stateName = arg1.Read<System.String>();
					var fixedTransitionDuration = arg2.Read<System.Single>();
					var layer = arg3.Read<System.Int32>();
					var fixedTimeOffset = arg4.Read<System.Single>();
					_this.m_Instance.CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset);
					return new ValueTask<Int32>(0);
				}
				case 4:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var arg4 = context.GetArgument(4);
					var stateHashName = arg1.Read<System.Int32>();
					var fixedTransitionDuration = arg2.Read<System.Single>();
					var layer = arg3.Read<System.Int32>();
					var fixedTimeOffset = arg4.Read<System.Single>();
					_this.m_Instance.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetBool = new("UnityEngine.Animator.GetBool", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetBool(id);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.GetBool(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.Animator.GetComponentIndex", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _GetCurrentAnimatorClipInfoCount = new("UnityEngine.Animator.GetCurrentAnimatorClipInfoCount", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetCurrentAnimatorClipInfoCount(layerIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetFloat = new("UnityEngine.Animator.GetFloat", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetFloat(id);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.GetFloat(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Animator.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Animator.GetInstanceID", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _GetInteger = new("UnityEngine.Animator.GetInteger", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.GetInteger(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetInteger(id);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetLayerIndex = new("UnityEngine.Animator.GetLayerIndex", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerName = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.GetLayerIndex(layerName);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetLayerName = new("UnityEngine.Animator.GetLayerName", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetLayerName(layerIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetLayerWeight = new("UnityEngine.Animator.GetLayerWeight", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetLayerWeight(layerIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetNextAnimatorClipInfoCount = new("UnityEngine.Animator.GetNextAnimatorClipInfoCount", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.GetNextAnimatorClipInfoCount(layerIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _HasState = new("UnityEngine.Animator.HasState", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var layerIndex = arg1.Read<System.Int32>();
					var stateID = arg2.Read<System.Int32>();
					var returnValue = _this.m_Instance.HasState(layerIndex, stateID);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _InterruptMatchTarget = new("UnityEngine.Animator.InterruptMatchTarget", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var completeMatch = arg1.Read<System.Boolean>();
					_this.m_Instance.InterruptMatchTarget(completeMatch);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsInTransition = new("UnityEngine.Animator.IsInTransition", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var layerIndex = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.IsInTransition(layerIndex);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _IsParameterControlledByCurve = new("UnityEngine.Animator.IsParameterControlledByCurve", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					var returnValue = _this.m_Instance.IsParameterControlledByCurve(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					var returnValue = _this.m_Instance.IsParameterControlledByCurve(id);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Play = new("UnityEngine.Animator.Play", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var stateName = arg1.Read<System.String>();
					var layer = arg2.Read<System.Int32>();
					_this.m_Instance.Play(stateName, layer);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var stateNameHash = arg1.Read<System.Int32>();
					var layer = arg2.Read<System.Int32>();
					_this.m_Instance.Play(stateNameHash, layer);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _PlayInFixedTime = new("UnityEngine.Animator.PlayInFixedTime", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var stateNameHash = arg1.Read<System.Int32>();
					_this.m_Instance.PlayInFixedTime(stateNameHash);
					return new ValueTask<Int32>(0);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var stateName = arg1.Read<System.String>();
					_this.m_Instance.PlayInFixedTime(stateName);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Rebind = new("UnityEngine.Animator.Rebind", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.Rebind();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ResetTrigger = new("UnityEngine.Animator.ResetTrigger", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					_this.m_Instance.ResetTrigger(name);
					return new ValueTask<Int32>(0);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					_this.m_Instance.ResetTrigger(id);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.Animator.SendMessage", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.Animator.SendMessageUpwards", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _SetBool = new("UnityEngine.Animator.SetBool", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var value = arg2.Read<System.Boolean>();
					_this.m_Instance.SetBool(name, value);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var id = arg1.Read<System.Int32>();
					var value = arg2.Read<System.Boolean>();
					_this.m_Instance.SetBool(id, value);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.Animator.SetFloat", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var value = arg2.Read<System.Single>();
					_this.m_Instance.SetFloat(name, value);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var id = arg1.Read<System.Int32>();
					var value = arg2.Read<System.Single>();
					_this.m_Instance.SetFloat(id, value);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetInteger = new("UnityEngine.Animator.SetInteger", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var id = arg1.Read<System.Int32>();
					var value = arg2.Read<System.Int32>();
					_this.m_Instance.SetInteger(id, value);
					return new ValueTask<Int32>(0);
				}
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var name = arg1.Read<System.String>();
					var value = arg2.Read<System.Int32>();
					_this.m_Instance.SetInteger(name, value);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetLayerWeight = new("UnityEngine.Animator.SetLayerWeight", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var layerIndex = arg1.Read<System.Int32>();
					var weight = arg2.Read<System.Single>();
					_this.m_Instance.SetLayerWeight(layerIndex, weight);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetLookAtWeight = new("UnityEngine.Animator.SetLookAtWeight", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var weight = arg1.Read<System.Single>();
					_this.m_Instance.SetLookAtWeight(weight);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _SetTrigger = new("UnityEngine.Animator.SetTrigger", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var id = arg1.Read<System.Int32>();
					_this.m_Instance.SetTrigger(id);
					return new ValueTask<Int32>(0);
				}
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var name = arg1.Read<System.String>();
					_this.m_Instance.SetTrigger(name);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _StartPlayback = new("UnityEngine.Animator.StartPlayback", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.StartPlayback();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _StartRecording = new("UnityEngine.Animator.StartRecording", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var frameCount = arg1.Read<System.Int32>();
					_this.m_Instance.StartRecording(frameCount);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _StopPlayback = new("UnityEngine.Animator.StopPlayback", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.StopPlayback();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _StopRecording = new("UnityEngine.Animator.StopRecording", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.StopRecording();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Animator.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
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

		private static readonly LuaFunction _Update = new("UnityEngine.Animator.Update", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var deltaTime = arg1.Read<System.Single>();
					_this.m_Instance.Update(deltaTime);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _WriteDefaultValues = new("UnityEngine.Animator.WriteDefaultValues", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 0:
				{
					_this.m_Instance.WriteDefaultValues();
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Animator instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ApplyBuiltinRootMotion": return _ApplyBuiltinRootMotion;
				case "BroadcastMessage": return _BroadcastMessage;
				case "CompareTag": return _CompareTag;
				case "CrossFade": return _CrossFade;
				case "CrossFadeInFixedTime": return _CrossFadeInFixedTime;
				case "GetBool": return _GetBool;
				case "GetComponentIndex": return _GetComponentIndex;
				case "GetCurrentAnimatorClipInfoCount": return _GetCurrentAnimatorClipInfoCount;
				case "GetFloat": return _GetFloat;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "GetInteger": return _GetInteger;
				case "GetLayerIndex": return _GetLayerIndex;
				case "GetLayerName": return _GetLayerName;
				case "GetLayerWeight": return _GetLayerWeight;
				case "GetNextAnimatorClipInfoCount": return _GetNextAnimatorClipInfoCount;
				case "HasState": return _HasState;
				case "InterruptMatchTarget": return _InterruptMatchTarget;
				case "IsInTransition": return _IsInTransition;
				case "IsParameterControlledByCurve": return _IsParameterControlledByCurve;
				case "Play": return _Play;
				case "PlayInFixedTime": return _PlayInFixedTime;
				case "Rebind": return _Rebind;
				case "ResetTrigger": return _ResetTrigger;
				case "SendMessage": return _SendMessage;
				case "SendMessageUpwards": return _SendMessageUpwards;
				case "SetBool": return _SetBool;
				case "SetFloat": return _SetFloat;
				case "SetInteger": return _SetInteger;
				case "SetLayerWeight": return _SetLayerWeight;
				case "SetLookAtWeight": return _SetLookAtWeight;
				case "SetTrigger": return _SetTrigger;
				case "StartPlayback": return _StartPlayback;
				case "StartRecording": return _StartRecording;
				case "StopPlayback": return _StopPlayback;
				case "StopRecording": return _StopRecording;
				case "ToString": return _ToString;
				case "Update": return _Update;
				case "WriteDefaultValues": return _WriteDefaultValues;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Animator instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Animator Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Animator v) => new(v);
		public Lua_UnityEngine_Animator(UnityEngine.Animator instance) { m_Instance = instance; }
		private UnityEngine.Animator m_Instance;
		public UnityEngine.Animator Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Animator_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Animator" };

		private static readonly LuaFunction _StringToHash = new("UnityEngine.Animator.StringToHash", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg0 = context.GetArgument(0);
					var name = arg0.Read<System.String>();
					var returnValue = UnityEngine.Animator.StringToHash(name);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Animator_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "StringToHash": return _StringToHash;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Animator_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Animator_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Animator_static v) => new(v);
	}

}
