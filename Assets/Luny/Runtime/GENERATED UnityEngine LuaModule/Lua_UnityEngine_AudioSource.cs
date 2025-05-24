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
	public class Lua_UnityEngine_AudioSource : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioSource" };

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.AudioSource.BroadcastMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _CompareTag = new("UnityEngine.AudioSource.CompareTag", (_context, _buffer, _) =>
		{
			System.String tag;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _DisableGamepadOutput = new("UnityEngine.AudioSource.DisableGamepadOutput", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.DisableGamepadOutput();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetAmbisonicDecoderFloat = new("UnityEngine.AudioSource.GetAmbisonicDecoderFloat", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out index) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = _this.m_Instance.GetAmbisonicDecoderFloat(index, out value);
						_buffer.Span[0] = new LuaValue(returnValue);
						_buffer.Span[1] = arg2;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.AudioSource.GetComponentIndex", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.AudioSource.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.AudioSource.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _GetSpatializerFloat = new("UnityEngine.AudioSource.GetSpatializerFloat", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out index) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = _this.m_Instance.GetSpatializerFloat(index, out value);
						_buffer.Span[0] = new LuaValue(returnValue);
						_buffer.Span[1] = arg2;
						return new ValueTask<Int32>(2);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Pause = new("UnityEngine.AudioSource.Pause", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Pause();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Play = new("UnityEngine.AudioSource.Play", (_context, _buffer, _) =>
		{
			System.UInt64 delay;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Play();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.UInt64>(out delay))
					{
						_this.m_Instance.Play(delay);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _PlayDelayed = new("UnityEngine.AudioSource.PlayDelayed", (_context, _buffer, _) =>
		{
			System.Single delay;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out delay))
					{
						_this.m_Instance.PlayDelayed(delay);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _PlayOnGamepad = new("UnityEngine.AudioSource.PlayOnGamepad", (_context, _buffer, _) =>
		{
			System.Int32 slot;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out slot))
					{
						var returnValue = _this.m_Instance.PlayOnGamepad(slot);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _PlayScheduled = new("UnityEngine.AudioSource.PlayScheduled", (_context, _buffer, _) =>
		{
			System.Double time;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Double>(out time))
					{
						_this.m_Instance.PlayScheduled(time);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.AudioSource.SendMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.AudioSource.SendMessageUpwards", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _SetAmbisonicDecoderFloat = new("UnityEngine.AudioSource.SetAmbisonicDecoderFloat", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out index) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = _this.m_Instance.SetAmbisonicDecoderFloat(index, value);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGamepadSpeakerMixLevel = new("UnityEngine.AudioSource.SetGamepadSpeakerMixLevel", (_context, _buffer, _) =>
		{
			System.Int32 slot;
			System.Int32 mixLevel;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out slot) &&
					    arg2.TryRead<System.Int32>(out mixLevel))
					{
						var returnValue = _this.m_Instance.SetGamepadSpeakerMixLevel(slot, mixLevel);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGamepadSpeakerMixLevelDefault = new("UnityEngine.AudioSource.SetGamepadSpeakerMixLevelDefault", (_context, _buffer, _) =>
		{
			System.Int32 slot;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out slot))
					{
						var returnValue = _this.m_Instance.SetGamepadSpeakerMixLevelDefault(slot);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetGamepadSpeakerRestrictedAudio = new("UnityEngine.AudioSource.SetGamepadSpeakerRestrictedAudio", (_context, _buffer, _) =>
		{
			System.Int32 slot;
			System.Boolean restricted;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out slot) &&
					    arg2.TryRead<System.Boolean>(out restricted))
					{
						var returnValue = _this.m_Instance.SetGamepadSpeakerRestrictedAudio(slot, restricted);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetScheduledEndTime = new("UnityEngine.AudioSource.SetScheduledEndTime", (_context, _buffer, _) =>
		{
			System.Double time;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Double>(out time))
					{
						_this.m_Instance.SetScheduledEndTime(time);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetScheduledStartTime = new("UnityEngine.AudioSource.SetScheduledStartTime", (_context, _buffer, _) =>
		{
			System.Double time;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Double>(out time))
					{
						_this.m_Instance.SetScheduledStartTime(time);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetSpatializerFloat = new("UnityEngine.AudioSource.SetSpatializerFloat", (_context, _buffer, _) =>
		{
			System.Int32 index;
			System.Single value;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out index) &&
					    arg2.TryRead<System.Single>(out value))
					{
						var returnValue = _this.m_Instance.SetSpatializerFloat(index, value);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Stop = new("UnityEngine.AudioSource.Stop", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Stop();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.AudioSource.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

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

		private static readonly LuaFunction _UnPause = new("UnityEngine.AudioSource.UnPause", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_AudioSource>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.UnPause();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioSource instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "BroadcastMessage": return _BroadcastMessage;
				case "CompareTag": return _CompareTag;
				case "DisableGamepadOutput": return _DisableGamepadOutput;
				case "GetAmbisonicDecoderFloat": return _GetAmbisonicDecoderFloat;
				case "GetComponentIndex": return _GetComponentIndex;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "GetSpatializerFloat": return _GetSpatializerFloat;
				case "Pause": return _Pause;
				case "Play": return _Play;
				case "PlayDelayed": return _PlayDelayed;
				case "PlayOnGamepad": return _PlayOnGamepad;
				case "PlayScheduled": return _PlayScheduled;
				case "SendMessage": return _SendMessage;
				case "SendMessageUpwards": return _SendMessageUpwards;
				case "SetAmbisonicDecoderFloat": return _SetAmbisonicDecoderFloat;
				case "SetGamepadSpeakerMixLevel": return _SetGamepadSpeakerMixLevel;
				case "SetGamepadSpeakerMixLevelDefault": return _SetGamepadSpeakerMixLevelDefault;
				case "SetGamepadSpeakerRestrictedAudio": return _SetGamepadSpeakerRestrictedAudio;
				case "SetScheduledEndTime": return _SetScheduledEndTime;
				case "SetScheduledStartTime": return _SetScheduledStartTime;
				case "SetSpatializerFloat": return _SetSpatializerFloat;
				case "Stop": return _Stop;
				case "ToString": return _ToString;
				case "UnPause": return _UnPause;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioSource instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSource>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSource>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioSource Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioSource v) => new(v);
		public Lua_UnityEngine_AudioSource(UnityEngine.AudioSource instance) { m_Instance = instance; }
		private UnityEngine.AudioSource m_Instance;
		public UnityEngine.AudioSource Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_AudioSource_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "AudioSource" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_AudioSource_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_AudioSource_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSource_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_AudioSource_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_AudioSource_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_AudioSource_static v) => new(v);
	}

}
