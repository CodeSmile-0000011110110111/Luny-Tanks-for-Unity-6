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
	public sealed class System_IO_Path_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "System", "IO", "Path" };

		public static implicit operator LuaValue(System_IO_Path_static v) => new(v);

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("System_IO_Path_static Metatable not assignable");
		}

		private static readonly LuaFunction _ChangeExtension = new("System.IO.Path.ChangeExtension", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path = arg0.Read<System.String>();
				var extension = arg1.Read<System.String>();
				buffer.Span[0] = System.IO.Path.ChangeExtension(path, extension);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _Combine = new("System.IO.Path.Combine", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 3) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var arg2 = context.GetArgument(2);
				var path1 = arg0.Read<System.String>();
				var path2 = arg1.Read<System.String>();
				var path3 = arg2.Read<System.String>();
				buffer.Span[0] = System.IO.Path.Combine(path1, path2, path3);
			}

			if (argCount == 4) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var arg2 = context.GetArgument(2);
				var arg3 = context.GetArgument(3);
				var path1 = arg0.Read<System.String>();
				var path2 = arg1.Read<System.String>();
				var path3 = arg2.Read<System.String>();
				var path4 = arg3.Read<System.String>();
				buffer.Span[0] = System.IO.Path.Combine(path1, path2, path3, path4);
			}

			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path1 = arg0.Read<System.String>();
				var path2 = arg1.Read<System.String>();
				buffer.Span[0] = System.IO.Path.Combine(path1, path2);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetDirectoryName = new("System.IO.Path.GetDirectoryName", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetDirectoryName(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetExtension = new("System.IO.Path.GetExtension", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetExtension(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetFileName = new("System.IO.Path.GetFileName", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetFileName(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetFileNameWithoutExtension = new("System.IO.Path.GetFileNameWithoutExtension", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetFileNameWithoutExtension(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetFullPath = new("System.IO.Path.GetFullPath", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetFullPath(path);
			}

			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var path = arg0.Read<System.String>();
				var basePath = arg1.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetFullPath(path, basePath);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetPathRoot = new("System.IO.Path.GetPathRoot", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetPathRoot(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetRandomFileName = new("System.IO.Path.GetRandomFileName", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 0) {
				buffer.Span[0] = System.IO.Path.GetRandomFileName();
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetRelativePath = new("System.IO.Path.GetRelativePath", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 2) {
				var arg0 = context.GetArgument(0);
				var arg1 = context.GetArgument(1);
				var relativeTo = arg0.Read<System.String>();
				var path = arg1.Read<System.String>();
				buffer.Span[0] = System.IO.Path.GetRelativePath(relativeTo, path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetTempFileName = new("System.IO.Path.GetTempFileName", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 0) {
				buffer.Span[0] = System.IO.Path.GetTempFileName();
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _GetTempPath = new("System.IO.Path.GetTempPath", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 0) {
				buffer.Span[0] = System.IO.Path.GetTempPath();
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _HasExtension = new("System.IO.Path.HasExtension", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.HasExtension(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _IsPathFullyQualified = new("System.IO.Path.IsPathFullyQualified", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.IsPathFullyQualified(path);
			}

			return new ValueTask<Int32>(1);
		});

		private static readonly LuaFunction _IsPathRooted = new("System.IO.Path.IsPathRooted", (context, buffer, ct) =>
		{
			var argCount = context.ArgumentCount;
			if (argCount == 1) {
				var arg0 = context.GetArgument(0);
				var path = arg0.Read<System.String>();
				buffer.Span[0] = System.IO.Path.IsPathRooted(path);
			}

			return new ValueTask<Int32>(1);
		});

		internal static LuaValue TryGetValue(System_IO_Path_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				case "ChangeExtension": return _ChangeExtension;
				case "Combine": return _Combine;
				case "GetDirectoryName": return _GetDirectoryName;
				case "GetExtension": return _GetExtension;
				case "GetFileName": return _GetFileName;
				case "GetFileNameWithoutExtension": return _GetFileNameWithoutExtension;
				case "GetFullPath": return _GetFullPath;
				case "GetPathRoot": return _GetPathRoot;
				case "GetRandomFileName": return _GetRandomFileName;
				case "GetRelativePath": return _GetRelativePath;
				case "GetTempFileName": return _GetTempFileName;
				case "GetTempPath": return _GetTempPath;
				case "HasExtension": return _HasExtension;
				case "IsPathFullyQualified": return _IsPathFullyQualified;
				case "IsPathRooted": return _IsPathRooted;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}
		internal static LuaValue TrySetValue(System_IO_Path_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch(key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}
		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_Path_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
		{
			var instance = context.GetArgument<System_IO_Path_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});
	}
}
