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
	public struct Lua_UnityEngine_Vector3Int : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3Int" };

		private static readonly LuaFunction _Clamp = new("UnityEngine.Vector3Int.Clamp", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var minUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var maxUserData = arg2.Read<Lua_UnityEngine_Vector3Int>();
					var min = minUserData.Instance;
					var max = maxUserData.Instance;
					_this.m_Instance.Clamp(min, max);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Equals = new("UnityEngine.Vector3Int.Equals", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var otherUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var other = otherUserData.Instance;
					var returnValue = _this.m_Instance.Equals(other);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Vector3Int.GetHashCode", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
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

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3Int.Scale", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 1:
				{
					var arg1 = context.GetArgument(1);
					var scaleUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var scale = scaleUserData.Instance;
					_this.m_Instance.Scale(scale);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Set = new("UnityEngine.Vector3Int.Set", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 3:
				{
					var arg1 = context.GetArgument(1);
					var arg2 = context.GetArgument(2);
					var arg3 = context.GetArgument(3);
					var x = arg1.Read<System.Int32>();
					var y = arg2.Read<System.Int32>();
					var z = arg3.Read<System.Int32>();
					_this.m_Instance.Set(x, y, z);
					return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Vector3Int.ToString", (context, buffer, ct) =>
		{
			var arg0 = context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Vector3Int>();
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

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3Int instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Clamp": return _Clamp;
				case "Equals": return _Equals;
				case "GetHashCode": return _GetHashCode;
				case "Scale": return _Scale;
				case "Set": return _Set;
				case "ToString": return _ToString;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3Int instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3Int Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3Int v) => new(v);
		public Lua_UnityEngine_Vector3Int(UnityEngine.Vector3Int instance) { m_Instance = instance; }
		private UnityEngine.Vector3Int m_Instance;
		public UnityEngine.Vector3Int Value { get => m_Instance; set => m_Instance = value; }
		internal UnityEngine.Vector3Int Instance { get => m_Instance; set => m_Instance = value; }
	}
	public sealed class Lua_UnityEngine_Vector3Int_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Vector3Int" };

		private static readonly LuaFunction _Distance = new("UnityEngine.Vector3Int.Distance", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3Int>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3Int.Distance(a, b);
					buffer.Span[0] = new LuaValue(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Max = new("UnityEngine.Vector3Int.Max", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3Int>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3Int.Max(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Min = new("UnityEngine.Vector3Int.Min", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var lhsUserData = arg0.Read<Lua_UnityEngine_Vector3Int>();
					var rhsUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var lhs = lhsUserData.Instance;
					var rhs = rhsUserData.Instance;
					var returnValue = UnityEngine.Vector3Int.Min(lhs, rhs);
					buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		private static readonly LuaFunction _Scale = new("UnityEngine.Vector3Int.Scale", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			switch (argCount)
			{
				case 2:
				{
					var arg0 = context.GetArgument(0);
					var arg1 = context.GetArgument(1);
					var aUserData = arg0.Read<Lua_UnityEngine_Vector3Int>();
					var bUserData = arg1.Read<Lua_UnityEngine_Vector3Int>();
					var a = aUserData.Instance;
					var b = bUserData.Instance;
					var returnValue = UnityEngine.Vector3Int.Scale(a, b);
					buffer.Span[0] = new Lua_UnityEngine_Vector3Int(returnValue);
					return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(context.State.GetTraceback(), "argument count mismatch");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Vector3Int_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Distance": return _Distance;
				case "Max": return _Max;
				case "Min": return _Min;
				case "Scale": return _Scale;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Vector3Int_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Vector3Int_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Vector3Int_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Vector3Int_static v) => new(v);
	}

}
