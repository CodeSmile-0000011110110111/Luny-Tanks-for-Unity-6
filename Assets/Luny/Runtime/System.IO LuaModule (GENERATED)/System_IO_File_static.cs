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
	public sealed class System_IO_File_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "System", "IO", "File" };

		public static implicit operator LuaValue(System_IO_File_static v) => new(v);

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Metatable not assignable");
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_File_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_File_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});
		internal static LuaValue TryGetValue(System_IO_File_static instance, String key,
			LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case var _:
					throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static void TrySetValue(System_IO_File_static instance, String key, LuaValue value,
			LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

	}
}
