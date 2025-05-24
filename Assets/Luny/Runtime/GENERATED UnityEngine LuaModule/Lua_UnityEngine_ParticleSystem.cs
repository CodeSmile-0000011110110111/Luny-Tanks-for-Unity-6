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
	public class Lua_UnityEngine_ParticleSystem : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ParticleSystem" };

		private static readonly LuaFunction _AllocateAxisOfRotationAttribute = new("UnityEngine.ParticleSystem.AllocateAxisOfRotationAttribute", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.AllocateAxisOfRotationAttribute();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _AllocateMeshIndexAttribute = new("UnityEngine.ParticleSystem.AllocateMeshIndexAttribute", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.AllocateMeshIndexAttribute();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _BroadcastMessage = new("UnityEngine.ParticleSystem.BroadcastMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _Clear = new("UnityEngine.ParticleSystem.Clear", (_context, _buffer, _) =>
		{
			System.Boolean withChildren;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Clear();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out withChildren))
					{
						_this.m_Instance.Clear(withChildren);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CompareTag = new("UnityEngine.ParticleSystem.CompareTag", (_context, _buffer, _) =>
		{
			System.String tag;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _Emit = new("UnityEngine.ParticleSystem.Emit", (_context, _buffer, _) =>
		{
			System.Int32 count;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out count))
					{
						_this.m_Instance.Emit(count);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetComponentIndex = new("UnityEngine.ParticleSystem.GetComponentIndex", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.ParticleSystem.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.ParticleSystem.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _IsAlive = new("UnityEngine.ParticleSystem.IsAlive", (_context, _buffer, _) =>
		{
			System.Boolean withChildren;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.IsAlive();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out withChildren))
					{
						var returnValue = _this.m_Instance.IsAlive(withChildren);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Pause = new("UnityEngine.ParticleSystem.Pause", (_context, _buffer, _) =>
		{
			System.Boolean withChildren;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Pause();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out withChildren))
					{
						_this.m_Instance.Pause(withChildren);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Play = new("UnityEngine.ParticleSystem.Play", (_context, _buffer, _) =>
		{
			System.Boolean withChildren;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Play();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out withChildren))
					{
						_this.m_Instance.Play(withChildren);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SendMessage = new("UnityEngine.ParticleSystem.SendMessage", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _SendMessageUpwards = new("UnityEngine.ParticleSystem.SendMessageUpwards", (_context, _buffer, _) =>
		{
			System.String methodName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _Simulate = new("UnityEngine.ParticleSystem.Simulate", (_context, _buffer, _) =>
		{
			System.Single t;
			System.Boolean withChildren;
			System.Boolean restart;
			System.Boolean fixedTimeStep;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var arg3 = argCount > 3 ? _context.GetArgument(3) : LuaValue.Nil;
			var arg4 = argCount > 4 ? _context.GetArgument(4) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out t))
					{
						_this.m_Instance.Simulate(t);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 3:
				{
					if (arg1.TryRead<System.Single>(out t) &&
					    arg2.TryRead<System.Boolean>(out withChildren) &&
					    arg3.TryRead<System.Boolean>(out restart))
					{
						_this.m_Instance.Simulate(t, withChildren, restart);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 2:
				{
					if (arg1.TryRead<System.Single>(out t) &&
					    arg2.TryRead<System.Boolean>(out withChildren))
					{
						_this.m_Instance.Simulate(t, withChildren);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				case 4:
				{
					if (arg1.TryRead<System.Single>(out t) &&
					    arg2.TryRead<System.Boolean>(out withChildren) &&
					    arg3.TryRead<System.Boolean>(out restart) &&
					    arg4.TryRead<System.Boolean>(out fixedTimeStep))
					{
						_this.m_Instance.Simulate(t, withChildren, restart, fixedTimeStep);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Stop = new("UnityEngine.ParticleSystem.Stop", (_context, _buffer, _) =>
		{
			System.Boolean withChildren;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Stop();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out withChildren))
					{
						_this.m_Instance.Stop(withChildren);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.ParticleSystem.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

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

		private static readonly LuaFunction _TriggerSubEmitter = new("UnityEngine.ParticleSystem.TriggerSubEmitter", (_context, _buffer, _) =>
		{
			System.Int32 subEmitterIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_ParticleSystem>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out subEmitterIndex))
					{
						_this.m_Instance.TriggerSubEmitter(subEmitterIndex);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_ParticleSystem instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "AllocateAxisOfRotationAttribute": return _AllocateAxisOfRotationAttribute;
				case "AllocateMeshIndexAttribute": return _AllocateMeshIndexAttribute;
				case "BroadcastMessage": return _BroadcastMessage;
				case "Clear": return _Clear;
				case "CompareTag": return _CompareTag;
				case "Emit": return _Emit;
				case "GetComponentIndex": return _GetComponentIndex;
				case "GetHashCode": return _GetHashCode;
				case "GetInstanceID": return _GetInstanceID;
				case "IsAlive": return _IsAlive;
				case "Pause": return _Pause;
				case "Play": return _Play;
				case "SendMessage": return _SendMessage;
				case "SendMessageUpwards": return _SendMessageUpwards;
				case "Simulate": return _Simulate;
				case "Stop": return _Stop;
				case "ToString": return _ToString;
				case "TriggerSubEmitter": return _TriggerSubEmitter;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ParticleSystem instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ParticleSystem>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ParticleSystem>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ParticleSystem Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ParticleSystem v) => new(v);
		public Lua_UnityEngine_ParticleSystem(UnityEngine.ParticleSystem instance) { m_Instance = instance; }
		private UnityEngine.ParticleSystem m_Instance;
		public UnityEngine.ParticleSystem Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_ParticleSystem_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "ParticleSystem" };

		private static readonly LuaFunction _ResetPreMappedBufferMemory = new("UnityEngine.ParticleSystem.ResetPreMappedBufferMemory", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;

			switch (argCount)
			{
				case 0:
				{
						UnityEngine.ParticleSystem.ResetPreMappedBufferMemory();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SetMaximumPreMappedBufferCounts = new("UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts", (_context, _buffer, _) =>
		{
			System.Int32 vertexBuffersCount;
			System.Int32 indexBuffersCount;

			var argCount = _context.ArgumentCount;
			var arg0 = argCount > 0 ? _context.GetArgument(0) : LuaValue.Nil;
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;

			switch (argCount)
			{
				case 2:
				{
					if (arg0.TryRead<System.Int32>(out vertexBuffersCount) &&
					    arg1.TryRead<System.Int32>(out indexBuffersCount))
					{
						UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts(vertexBuffersCount, indexBuffersCount);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_ParticleSystem_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "ResetPreMappedBufferMemory": return _ResetPreMappedBufferMemory;
				case "SetMaximumPreMappedBufferCounts": return _SetMaximumPreMappedBufferCounts;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_ParticleSystem_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ParticleSystem_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_ParticleSystem_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_ParticleSystem_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_ParticleSystem_static v) => new(v);
	}

}
