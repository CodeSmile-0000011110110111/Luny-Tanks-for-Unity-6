using Lua;
using Lua.Runtime;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace CodeSmile.Luny.DefaultContext
{
    public class FileIO_static : ILuaUserData
    {
        public static readonly string[] TypeFullName = { "System", "IO", "File" };

        public static implicit operator LuaValue(FileIO_static value) => new(value);
        private static LuaTable s_MetaTable;
        public LuaTable Metatable
        {
            get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
            set => throw new NotSupportedException("Metatable not assignable");
        }

        private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, ct) =>
            {
                var instance = context.GetArgument<FileIO_static>(0);
                var key = context.GetArgument<String>(1);
                buffer.Span[0] = TryGetValue(instance, key, context);
                return new ValueTask<Int32>(1);
            }
        );

        private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, ct) =>
            {
                var instance = context.GetArgument<FileIO_static>(0);
                var key = context.GetArgument<String>(1);
                var value = context.GetArgument(2);
                TrySetValue(instance, key, value, context);
                return new ValueTask<Int32>(0);
            }
        );

        internal static LuaValue TryGetValue(FileIO_static instance, String key, LuaFunctionExecutionContext context)
        {
            switch (key)
            {
                case "testfunc": return _testfunc;
                default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
            }
        }

        internal static void TrySetValue(FileIO_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
        {
            switch (key)
            {
                default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
            }
        }

        private static readonly LuaFunction _testfunc = new("testfunc", (context, buffer, ct) =>
            {
                var argCount = context.ArgumentCount;
                var arg0 = argCount > 0 ? context.GetArgument(0) : LuaValue.Nil;
                var arg1 = argCount > 1 ? context.GetArgument(1) : LuaValue.Nil;
                Debug.Log($"testfunc called on {arg0} with arg1: {arg1}");
                buffer.Span[0] = "did run";
                return new ValueTask<Int32>(1);
            }
        );
    }
}
