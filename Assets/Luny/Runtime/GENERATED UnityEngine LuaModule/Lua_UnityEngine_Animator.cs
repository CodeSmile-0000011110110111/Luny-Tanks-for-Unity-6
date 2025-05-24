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

		private static readonly LuaFunction _ApplyBuiltinRootMotion = new("UnityEngine.Animator.ApplyBuiltinRootMotion", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ApplyBuiltinRootMotion();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.Animator.BroadcastMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _CompareTag = new("UnityEngine.Animator.CompareTag", (_context, _buffer, _) =>
		{
			System.String tag;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _CrossFade = new("UnityEngine.Animator.CrossFade", (_context, _buffer, _) =>
		{
			System.Int32 stateHashName;
			System.Single normalizedTransitionDuration;
			System.Int32 layer;
			System.String stateName;
			System.Single normalizedTimeOffset;
			System.Single normalizedTransitionTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.CrossFade(stateHashName, normalizedTransitionDuration, layer);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.CrossFade(stateName, normalizedTransitionDuration, layer);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out normalizedTimeOffset))
					{
						_this.m_Instance.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out normalizedTimeOffset))
					{
						_this.m_Instance.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration))
					{
						_this.m_Instance.CrossFade(stateName, normalizedTransitionDuration);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration))
					{
						_this.m_Instance.CrossFade(stateHashName, normalizedTransitionDuration);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 5:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out normalizedTimeOffset) &&
					    arg5.TryRead<System.Single>(out normalizedTransitionTime))
					{
						_this.m_Instance.CrossFade(stateName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out normalizedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out normalizedTimeOffset) &&
					    arg5.TryRead<System.Single>(out normalizedTransitionTime))
					{
						_this.m_Instance.CrossFade(stateHashName, normalizedTransitionDuration, layer, normalizedTimeOffset, normalizedTransitionTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CrossFadeInFixedTime = new("UnityEngine.Animator.CrossFadeInFixedTime", (_context, _buffer, _) =>
		{
			System.String stateName;
			System.Single fixedTransitionDuration;
			System.Int32 layer;
			System.Single fixedTimeOffset;
			System.Int32 stateHashName;
			System.Single normalizedTransitionTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 4:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out fixedTimeOffset))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out fixedTimeOffset))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateName, fixedTransitionDuration);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 5:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out fixedTimeOffset) &&
					    arg5.TryRead<System.Single>(out normalizedTransitionTime))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateHashName) &&
					    arg2.TryRead<System.Single>(out fixedTransitionDuration) &&
					    arg3.TryRead<System.Int32>(out layer) &&
					    arg4.TryRead<System.Single>(out fixedTimeOffset) &&
					    arg5.TryRead<System.Single>(out normalizedTransitionTime))
					{
						_this.m_Instance.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration, layer, fixedTimeOffset, normalizedTransitionTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBool = new("UnityEngine.Animator.GetBool", (_context, _buffer, _) =>
		{
			System.Int32 id;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out id))
					{
						var returnValue = _this.m_Instance.GetBool(id);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetBool(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.Animator.GetComponentIndex", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _GetCurrentAnimatorClipInfoCount = new("UnityEngine.Animator.GetCurrentAnimatorClipInfoCount", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.GetCurrentAnimatorClipInfoCount(layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetFloat = new("UnityEngine.Animator.GetFloat", (_context, _buffer, _) =>
		{
			System.Int32 id;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out id))
					{
						var returnValue = _this.m_Instance.GetFloat(id);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetFloat(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Animator.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Animator.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _GetInteger = new("UnityEngine.Animator.GetInteger", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 id;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.GetInteger(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out id))
					{
						var returnValue = _this.m_Instance.GetInteger(id);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetLayerIndex = new("UnityEngine.Animator.GetLayerIndex", (_context, _buffer, _) =>
		{
			System.String layerName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out layerName))
					{
						var returnValue = _this.m_Instance.GetLayerIndex(layerName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetLayerName = new("UnityEngine.Animator.GetLayerName", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.GetLayerName(layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetLayerWeight = new("UnityEngine.Animator.GetLayerWeight", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.GetLayerWeight(layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetNextAnimatorClipInfoCount = new("UnityEngine.Animator.GetNextAnimatorClipInfoCount", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.GetNextAnimatorClipInfoCount(layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _HasState = new("UnityEngine.Animator.HasState", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;
			System.Int32 stateID;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex) &&
					    arg2.TryRead<System.Int32>(out stateID))
					{
						var returnValue = _this.m_Instance.HasState(layerIndex, stateID);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _InterruptMatchTarget = new("UnityEngine.Animator.InterruptMatchTarget", (_context, _buffer, _) =>
		{
			System.Boolean completeMatch;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.InterruptMatchTarget();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out completeMatch))
					{
						_this.m_Instance.InterruptMatchTarget(completeMatch);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsInTransition = new("UnityEngine.Animator.IsInTransition", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex))
					{
						var returnValue = _this.m_Instance.IsInTransition(layerIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _IsParameterControlledByCurve = new("UnityEngine.Animator.IsParameterControlledByCurve", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 id;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						var returnValue = _this.m_Instance.IsParameterControlledByCurve(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					if (arg1.TryRead<System.Int32>(out id))
					{
						var returnValue = _this.m_Instance.IsParameterControlledByCurve(id);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Play = new("UnityEngine.Animator.Play", (_context, _buffer, _) =>
		{
			System.Int32 stateNameHash;
			System.String stateName;
			System.Int32 layer;
			System.Single normalizedTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out stateNameHash))
					{
						_this.m_Instance.Play(stateNameHash);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName))
					{
						_this.m_Instance.Play(stateName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.Play(stateName, layer);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out stateNameHash) &&
					    arg2.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.Play(stateNameHash, layer);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out stateNameHash) &&
					    arg2.TryRead<System.Int32>(out layer) &&
					    arg3.TryRead<System.Single>(out normalizedTime))
					{
						_this.m_Instance.Play(stateNameHash, layer, normalizedTime);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Int32>(out layer) &&
					    arg3.TryRead<System.Single>(out normalizedTime))
					{
						_this.m_Instance.Play(stateName, layer, normalizedTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _PlayInFixedTime = new("UnityEngine.Animator.PlayInFixedTime", (_context, _buffer, _) =>
		{
			System.Int32 stateNameHash;
			System.String stateName;
			System.Int32 layer;
			System.Single fixedTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out stateNameHash))
					{
						_this.m_Instance.PlayInFixedTime(stateNameHash);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName))
					{
						_this.m_Instance.PlayInFixedTime(stateName);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out stateNameHash) &&
					    arg2.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.PlayInFixedTime(stateNameHash, layer);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Int32>(out layer))
					{
						_this.m_Instance.PlayInFixedTime(stateName, layer);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.Int32>(out stateNameHash) &&
					    arg2.TryRead<System.Int32>(out layer) &&
					    arg3.TryRead<System.Single>(out fixedTime))
					{
						_this.m_Instance.PlayInFixedTime(stateNameHash, layer, fixedTime);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out stateName) &&
					    arg2.TryRead<System.Int32>(out layer) &&
					    arg3.TryRead<System.Single>(out fixedTime))
					{
						_this.m_Instance.PlayInFixedTime(stateName, layer, fixedTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Rebind = new("UnityEngine.Animator.Rebind", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Rebind();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ResetTrigger = new("UnityEngine.Animator.ResetTrigger", (_context, _buffer, _) =>
		{
			System.String name;
			System.Int32 id;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out name))
					{
						_this.m_Instance.ResetTrigger(name);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out id))
					{
						_this.m_Instance.ResetTrigger(id);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.Animator.SendMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.Animator.SendMessageUpwards", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _SetBool = new("UnityEngine.Animator.SetBool", (_context, _buffer, _) =>
		{
			System.String name;
			System.Boolean value;
			System.Int32 id;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Boolean>(out value))
					{
						_this.m_Instance.SetBool(name, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out id) &&
					    arg2.TryRead<System.Boolean>(out value))
					{
						_this.m_Instance.SetBool(id, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetFloat = new("UnityEngine.Animator.SetFloat", (_context, _buffer, _) =>
		{
			System.String name;
			System.Single value;
			System.Int32 id;
			System.Single dampTime;
			System.Single deltaTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Single>(out value))
					{
						_this.m_Instance.SetFloat(name, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out id) &&
					    arg2.TryRead<System.Single>(out value))
					{
						_this.m_Instance.SetFloat(id, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Single>(out value) &&
					    arg3.TryRead<System.Single>(out dampTime) &&
					    arg4.TryRead<System.Single>(out deltaTime))
					{
						_this.m_Instance.SetFloat(name, value, dampTime, deltaTime);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.Int32>(out id) &&
					    arg2.TryRead<System.Single>(out value) &&
					    arg3.TryRead<System.Single>(out dampTime) &&
					    arg4.TryRead<System.Single>(out deltaTime))
					{
						_this.m_Instance.SetFloat(id, value, dampTime, deltaTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetInteger = new("UnityEngine.Animator.SetInteger", (_context, _buffer, _) =>
		{
			System.Int32 id;
			System.Int32 value;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out id) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInteger(id, value);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name) &&
					    arg2.TryRead<System.Int32>(out value))
					{
						_this.m_Instance.SetInteger(name, value);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetLayerWeight = new("UnityEngine.Animator.SetLayerWeight", (_context, _buffer, _) =>
		{
			System.Int32 layerIndex;
			System.Single weight;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out layerIndex) &&
					    arg2.TryRead<System.Single>(out weight))
					{
						_this.m_Instance.SetLayerWeight(layerIndex, weight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetLookAtWeight = new("UnityEngine.Animator.SetLookAtWeight", (_context, _buffer, _) =>
		{
			System.Single weight;
			System.Single bodyWeight;
			System.Single headWeight;
			System.Single eyesWeight;
			System.Single clampWeight;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var arg5 = argCount > 5 ? _context.GetArgument(5) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out weight))
					{
						_this.m_Instance.SetLookAtWeight(weight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.Single>(out weight) &&
					    arg2.TryRead<System.Single>(out bodyWeight))
					{
						_this.m_Instance.SetLookAtWeight(weight, bodyWeight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg1.TryRead<System.Single>(out weight) &&
					    arg2.TryRead<System.Single>(out bodyWeight) &&
					    arg3.TryRead<System.Single>(out headWeight) &&
					    arg4.TryRead<System.Single>(out eyesWeight))
					{
						_this.m_Instance.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.Single>(out weight) &&
					    arg2.TryRead<System.Single>(out bodyWeight) &&
					    arg3.TryRead<System.Single>(out headWeight))
					{
						_this.m_Instance.SetLookAtWeight(weight, bodyWeight, headWeight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 5:
				{
					if (arg1.TryRead<System.Single>(out weight) &&
					    arg2.TryRead<System.Single>(out bodyWeight) &&
					    arg3.TryRead<System.Single>(out headWeight) &&
					    arg4.TryRead<System.Single>(out eyesWeight) &&
					    arg5.TryRead<System.Single>(out clampWeight))
					{
						_this.m_Instance.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetTrigger = new("UnityEngine.Animator.SetTrigger", (_context, _buffer, _) =>
		{
			System.Int32 id;
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out id))
					{
						_this.m_Instance.SetTrigger(id);
						return new ValueTask<Int32>(0);
					}
					if (arg1.TryRead<System.String>(out name))
					{
						_this.m_Instance.SetTrigger(name);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _StartPlayback = new("UnityEngine.Animator.StartPlayback", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.StartPlayback();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _StartRecording = new("UnityEngine.Animator.StartRecording", (_context, _buffer, _) =>
		{
			System.Int32 frameCount;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out frameCount))
					{
						_this.m_Instance.StartRecording(frameCount);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _StopPlayback = new("UnityEngine.Animator.StopPlayback", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.StopPlayback();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _StopRecording = new("UnityEngine.Animator.StopRecording", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.StopRecording();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Animator.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

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

		private static readonly LuaFunction _Update = new("UnityEngine.Animator.Update", (_context, _buffer, _) =>
		{
			System.Single deltaTime;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out deltaTime))
					{
						_this.m_Instance.Update(deltaTime);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _WriteDefaultValues = new("UnityEngine.Animator.WriteDefaultValues", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Animator>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.WriteDefaultValues();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Animator_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Animator" };

		private static readonly LuaFunction _StringToHash = new("UnityEngine.Animator.StringToHash", (_context, _buffer, _) =>
		{
			System.String name;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;

			switch (argCount)
			{
				case 1:
				{
					if (arg0.TryRead<System.String>(out name))
					{
						var returnValue = UnityEngine.Animator.StringToHash(name);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
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

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Animator_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
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
