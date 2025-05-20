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
			set => throw new NotSupportedException("System_IO_File_static Metatable not assignable");
		}

		private static readonly LuaFunction _AppendAllText = new("System.IO.File.AppendAllText", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path = arg0.Read<System.String>();
				var contents = arg1.Read<System.String>();
				System.IO.File.AppendAllText(path, contents);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Copy = new("System.IO.File.Copy", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 3) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var arg2 = context.GetArgument(2);
				var sourceFileName = arg0.Read<System.String>();
				var destFileName = arg1.Read<System.String>();
				var overwrite = arg2.Read<System.Boolean>();
				System.IO.File.Copy(sourceFileName, destFileName, overwrite);
			}

			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var sourceFileName = arg0.Read<System.String>();
				var destFileName = arg1.Read<System.String>();
				System.IO.File.Copy(sourceFileName, destFileName);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Decrypt = new("System.IO.File.Decrypt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				System.IO.File.Decrypt(path);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Delete = new("System.IO.File.Delete", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				System.IO.File.Delete(path);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Encrypt = new("System.IO.File.Encrypt", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				System.IO.File.Encrypt(path);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _Exists = new("System.IO.File.Exists", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.File.Exists(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _Move = new("System.IO.File.Move", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var sourceFileName = arg0.Read<System.String>();
				var destFileName = arg1.Read<System.String>();
				System.IO.File.Move(sourceFileName, destFileName);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _ReadAllText = new("System.IO.File.ReadAllText", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.File.ReadAllText(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _Replace = new("System.IO.File.Replace", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 3) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var arg2 = context.GetArgument(2);
				var sourceFileName = arg0.Read<System.String>();
				var destinationFileName = arg1.Read<System.String>();
				var destinationBackupFileName = arg2.Read<System.String>();
				System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
			}

			if (argCount == 4) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var arg2 = context.GetArgument(2);
				var arg3 = context.GetArgument(3);
				var sourceFileName = arg0.Read<System.String>();
				var destinationFileName = arg1.Read<System.String>();
				var destinationBackupFileName = arg2.Read<System.String>();
				var ignoreMetadataErrors = arg3.Read<System.Boolean>();
				System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
			}

			return new ValueTask<Int32>(0);
		});

		private static readonly LuaFunction _WriteAllText = new("System.IO.File.WriteAllText", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path = arg0.Read<System.String>();
				var contents = arg1.Read<System.String>();
				System.IO.File.WriteAllText(path, contents);
			}

			return new ValueTask<Int32>(0);
		});

		internal static LuaValue TryGetValue(System_IO_File_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				case "AppendAllText": return _AppendAllText;
				case "Copy": return _Copy;
				case "Decrypt": return _Decrypt;
				case "Delete": return _Delete;
				case "Encrypt": return _Encrypt;
				case "Exists": return _Exists;
				case "Move": return _Move;
				case "ReadAllText": return _ReadAllText;
				case "Replace": return _Replace;
				case "WriteAllText": return _WriteAllText;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}
		internal static LuaValue TrySetValue(System_IO_File_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
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
	}
}
