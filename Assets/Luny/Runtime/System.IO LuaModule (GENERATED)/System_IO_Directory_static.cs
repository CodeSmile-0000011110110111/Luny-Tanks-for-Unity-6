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
	public sealed class System_IO_Directory_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "System", "IO", "Directory" };

		public static implicit operator LuaValue(System_IO_Directory_static v) => new(v);

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("System_IO_Directory_static Metatable not assignable");
		}

		private static readonly LuaFunction _Delete = new("System.IO.Directory.Delete", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path = arg0.Read<System.String>();
				var recursive = arg1.Read<System.Boolean>();
				System.IO.Directory.Delete(path, recursive);
			}

			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				System.IO.Directory.Delete(path);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Exists = new("System.IO.Directory.Exists", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Directory.Exists(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetCurrentDirectory = new("System.IO.Directory.GetCurrentDirectory", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 0) {
				buffer.Span[0] = System.IO.Directory.GetCurrentDirectory();
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetDirectoryRoot = new("System.IO.Directory.GetDirectoryRoot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Directory.GetDirectoryRoot(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _Move = new("System.IO.Directory.Move", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var sourceDirName = arg0.Read<System.String>();
				var destDirName = arg1.Read<System.String>();
				System.IO.Directory.Move(sourceDirName, destDirName);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _SetCurrentDirectory = new("System.IO.Directory.SetCurrentDirectory", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				System.IO.Directory.SetCurrentDirectory(path);
			}

			return new ValueTask<Int32>(0);
		});

		internal static LuaValue TryGetValue(System_IO_Directory_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				case "Delete": return _Delete;
				case "Exists": return _Exists;
				case "GetCurrentDirectory": return _GetCurrentDirectory;
				case "GetDirectoryRoot": return _GetDirectoryRoot;
				case "Move": return _Move;
				case "SetCurrentDirectory": return _SetCurrentDirectory;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}
		internal static LuaValue TrySetValue(System_IO_Directory_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_Directory_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_Directory_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});
	}
}
