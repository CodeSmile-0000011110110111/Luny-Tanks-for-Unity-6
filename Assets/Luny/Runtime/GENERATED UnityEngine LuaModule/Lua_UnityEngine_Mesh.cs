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
	public class Lua_UnityEngine_Mesh : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Mesh" };

		private static readonly LuaFunction _Clear = new("UnityEngine.Mesh.Clear", (_context, _buffer, _) =>
		{
			System.Boolean keepVertexLayout;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Clear();
						return new ValueTask<Int32>(0);
				}
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out keepVertexLayout))
					{
						_this.m_Instance.Clear(keepVertexLayout);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ClearBlendShapes = new("UnityEngine.Mesh.ClearBlendShapes", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ClearBlendShapes();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBaseVertex = new("UnityEngine.Mesh.GetBaseVertex", (_context, _buffer, _) =>
		{
			System.Int32 submesh;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out submesh))
					{
						var returnValue = _this.m_Instance.GetBaseVertex(submesh);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBlendShapeFrameCount = new("UnityEngine.Mesh.GetBlendShapeFrameCount", (_context, _buffer, _) =>
		{
			System.Int32 shapeIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out shapeIndex))
					{
						var returnValue = _this.m_Instance.GetBlendShapeFrameCount(shapeIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBlendShapeFrameWeight = new("UnityEngine.Mesh.GetBlendShapeFrameWeight", (_context, _buffer, _) =>
		{
			System.Int32 shapeIndex;
			System.Int32 frameIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out shapeIndex) &&
					    arg2.TryRead<System.Int32>(out frameIndex))
					{
						var returnValue = _this.m_Instance.GetBlendShapeFrameWeight(shapeIndex, frameIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBlendShapeIndex = new("UnityEngine.Mesh.GetBlendShapeIndex", (_context, _buffer, _) =>
		{
			System.String blendShapeName;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out blendShapeName))
					{
						var returnValue = _this.m_Instance.GetBlendShapeIndex(blendShapeName);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetBlendShapeName = new("UnityEngine.Mesh.GetBlendShapeName", (_context, _buffer, _) =>
		{
			System.Int32 shapeIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out shapeIndex))
					{
						var returnValue = _this.m_Instance.GetBlendShapeName(shapeIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.Mesh.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

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

		private static readonly LuaFunction _GetIndexCount = new("UnityEngine.Mesh.GetIndexCount", (_context, _buffer, _) =>
		{
			System.Int32 submesh;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out submesh))
					{
						var returnValue = _this.m_Instance.GetIndexCount(submesh);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetIndexStart = new("UnityEngine.Mesh.GetIndexStart", (_context, _buffer, _) =>
		{
			System.Int32 submesh;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out submesh))
					{
						var returnValue = _this.m_Instance.GetIndexStart(submesh);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetInstanceID = new("UnityEngine.Mesh.GetInstanceID", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

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

		private static readonly LuaFunction _GetUVDistributionMetric = new("UnityEngine.Mesh.GetUVDistributionMetric", (_context, _buffer, _) =>
		{
			System.Int32 uvSetIndex;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out uvSetIndex))
					{
						var returnValue = _this.m_Instance.GetUVDistributionMetric(uvSetIndex);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetVertexBufferStride = new("UnityEngine.Mesh.GetVertexBufferStride", (_context, _buffer, _) =>
		{
			System.Int32 stream;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out stream))
					{
						var returnValue = _this.m_Instance.GetVertexBufferStride(stream);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MarkDynamic = new("UnityEngine.Mesh.MarkDynamic", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MarkDynamic();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MarkModified = new("UnityEngine.Mesh.MarkModified", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MarkModified();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Optimize = new("UnityEngine.Mesh.Optimize", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Optimize();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OptimizeIndexBuffers = new("UnityEngine.Mesh.OptimizeIndexBuffers", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OptimizeIndexBuffers();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OptimizeReorderVertexBuffer = new("UnityEngine.Mesh.OptimizeReorderVertexBuffer", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OptimizeReorderVertexBuffer();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RecalculateBounds = new("UnityEngine.Mesh.RecalculateBounds", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RecalculateBounds();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RecalculateNormals = new("UnityEngine.Mesh.RecalculateNormals", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RecalculateNormals();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RecalculateTangents = new("UnityEngine.Mesh.RecalculateTangents", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.RecalculateTangents();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RecalculateUVDistributionMetric = new("UnityEngine.Mesh.RecalculateUVDistributionMetric", (_context, _buffer, _) =>
		{
			System.Int32 uvSetIndex;
			System.Single uvAreaThreshold = 1e-09f;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var arg2 = argCount > 2 ? _context.GetArgument(2) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 2:
				{
					if (arg1.TryRead<System.Int32>(out uvSetIndex) &&
					    arg2.TryRead<System.Single>(out uvAreaThreshold))
					{
						_this.m_Instance.RecalculateUVDistributionMetric(uvSetIndex, uvAreaThreshold);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _RecalculateUVDistributionMetrics = new("UnityEngine.Mesh.RecalculateUVDistributionMetrics", (_context, _buffer, _) =>
		{
			System.Single uvAreaThreshold = 1e-09f;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Single>(out uvAreaThreshold))
					{
						_this.m_Instance.RecalculateUVDistributionMetrics(uvAreaThreshold);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.Mesh.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

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

		private static readonly LuaFunction _UploadMeshData = new("UnityEngine.Mesh.UploadMeshData", (_context, _buffer, _) =>
		{
			System.Boolean markNoLongerReadable;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_Mesh>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out markNoLongerReadable))
					{
						_this.m_Instance.UploadMeshData(markNoLongerReadable);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_Mesh instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Clear": return _Clear;
				case "ClearBlendShapes": return _ClearBlendShapes;
				case "GetBaseVertex": return _GetBaseVertex;
				case "GetBlendShapeFrameCount": return _GetBlendShapeFrameCount;
				case "GetBlendShapeFrameWeight": return _GetBlendShapeFrameWeight;
				case "GetBlendShapeIndex": return _GetBlendShapeIndex;
				case "GetBlendShapeName": return _GetBlendShapeName;
				case "GetHashCode": return _GetHashCode;
				case "GetIndexCount": return _GetIndexCount;
				case "GetIndexStart": return _GetIndexStart;
				case "GetInstanceID": return _GetInstanceID;
				case "GetUVDistributionMetric": return _GetUVDistributionMetric;
				case "GetVertexBufferStride": return _GetVertexBufferStride;
				case "MarkDynamic": return _MarkDynamic;
				case "MarkModified": return _MarkModified;
				case "Optimize": return _Optimize;
				case "OptimizeIndexBuffers": return _OptimizeIndexBuffers;
				case "OptimizeReorderVertexBuffer": return _OptimizeReorderVertexBuffer;
				case "RecalculateBounds": return _RecalculateBounds;
				case "RecalculateNormals": return _RecalculateNormals;
				case "RecalculateTangents": return _RecalculateTangents;
				case "RecalculateUVDistributionMetric": return _RecalculateUVDistributionMetric;
				case "RecalculateUVDistributionMetrics": return _RecalculateUVDistributionMetrics;
				case "ToString": return _ToString;
				case "UploadMeshData": return _UploadMeshData;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Mesh instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mesh>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mesh>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Mesh Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Mesh v) => new(v);
		public Lua_UnityEngine_Mesh(UnityEngine.Mesh instance) { m_Instance = instance; }
		private UnityEngine.Mesh m_Instance;
		public UnityEngine.Mesh Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_Mesh_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "Mesh" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_Mesh_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_Mesh_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mesh_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_Mesh_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_Mesh_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_Mesh_static v) => new(v);
	}

}
