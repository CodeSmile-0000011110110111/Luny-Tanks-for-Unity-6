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
	public class Lua_UnityEngine_TextEditor : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "TextEditor" };

		private static readonly LuaFunction _Backspace = new("UnityEngine.TextEditor.Backspace", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.Backspace();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _CanPaste = new("UnityEngine.TextEditor.CanPaste", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.CanPaste();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Copy = new("UnityEngine.TextEditor.Copy", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Copy();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Cut = new("UnityEngine.TextEditor.Cut", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.Cut();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Delete = new("UnityEngine.TextEditor.Delete", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.Delete();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DeleteLineBack = new("UnityEngine.TextEditor.DeleteLineBack", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.DeleteLineBack();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DeleteSelection = new("UnityEngine.TextEditor.DeleteSelection", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.DeleteSelection();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DeleteWordBack = new("UnityEngine.TextEditor.DeleteWordBack", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.DeleteWordBack();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DeleteWordForward = new("UnityEngine.TextEditor.DeleteWordForward", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.DeleteWordForward();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DetectFocusChange = new("UnityEngine.TextEditor.DetectFocusChange", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.DetectFocusChange();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _DrawCursor = new("UnityEngine.TextEditor.DrawCursor", (_context, _buffer, _) =>
		{
			System.String newText;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out newText))
					{
						_this.m_Instance.DrawCursor(newText);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ExpandSelectGraphicalLineEnd = new("UnityEngine.TextEditor.ExpandSelectGraphicalLineEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ExpandSelectGraphicalLineEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ExpandSelectGraphicalLineStart = new("UnityEngine.TextEditor.ExpandSelectGraphicalLineStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.ExpandSelectGraphicalLineStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _FindStartOfNextWord = new("UnityEngine.TextEditor.FindStartOfNextWord", (_context, _buffer, _) =>
		{
			System.Int32 p;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Int32>(out p))
					{
						var returnValue = _this.m_Instance.FindStartOfNextWord(p);
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _GetHashCode = new("UnityEngine.TextEditor.GetHashCode", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

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

		private static readonly LuaFunction _Insert = new("UnityEngine.TextEditor.Insert", (_context, _buffer, _) =>
		{
			System.Char c;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Char>(out c))
					{
						_this.m_Instance.Insert(c);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MouseDragSelectsWholeWords = new("UnityEngine.TextEditor.MouseDragSelectsWholeWords", (_context, _buffer, _) =>
		{
			System.Boolean on;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.Boolean>(out on))
					{
						_this.m_Instance.MouseDragSelectsWholeWords(on);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveDown = new("UnityEngine.TextEditor.MoveDown", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveDown();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveGraphicalLineEnd = new("UnityEngine.TextEditor.MoveGraphicalLineEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveGraphicalLineEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveGraphicalLineStart = new("UnityEngine.TextEditor.MoveGraphicalLineStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveGraphicalLineStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveLeft = new("UnityEngine.TextEditor.MoveLeft", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveLeft();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveLineEnd = new("UnityEngine.TextEditor.MoveLineEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveLineEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveLineStart = new("UnityEngine.TextEditor.MoveLineStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveLineStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveParagraphBackward = new("UnityEngine.TextEditor.MoveParagraphBackward", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveParagraphBackward();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveParagraphForward = new("UnityEngine.TextEditor.MoveParagraphForward", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveParagraphForward();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveRight = new("UnityEngine.TextEditor.MoveRight", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveRight();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveSelectionToAltCursor = new("UnityEngine.TextEditor.MoveSelectionToAltCursor", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveSelectionToAltCursor();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveTextEnd = new("UnityEngine.TextEditor.MoveTextEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveTextEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveTextStart = new("UnityEngine.TextEditor.MoveTextStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveTextStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveToEndOfPreviousWord = new("UnityEngine.TextEditor.MoveToEndOfPreviousWord", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveToEndOfPreviousWord();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveToStartOfNextWord = new("UnityEngine.TextEditor.MoveToStartOfNextWord", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveToStartOfNextWord();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveUp = new("UnityEngine.TextEditor.MoveUp", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveUp();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveWordLeft = new("UnityEngine.TextEditor.MoveWordLeft", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveWordLeft();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _MoveWordRight = new("UnityEngine.TextEditor.MoveWordRight", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.MoveWordRight();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OnFocus = new("UnityEngine.TextEditor.OnFocus", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OnFocus();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _OnLostFocus = new("UnityEngine.TextEditor.OnLostFocus", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.OnLostFocus();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _Paste = new("UnityEngine.TextEditor.Paste", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						var returnValue = _this.m_Instance.Paste();
						_buffer.Span[0] = new LuaValue(returnValue);
						return new ValueTask<Int32>(1);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ReplaceSelection = new("UnityEngine.TextEditor.ReplaceSelection", (_context, _buffer, _) =>
		{
			System.String replace;

			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var arg1 = argCount > 1 ? _context.GetArgument(1) : LuaValue.Nil;
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 1:
				{
					if (arg1.TryRead<System.String>(out replace))
					{
						_this.m_Instance.ReplaceSelection(replace);
						return new ValueTask<Int32>(0);
					}
					throw new LuaRuntimeException(_context.State.GetTraceback(), "parameter type mismatch");
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SaveBackup = new("UnityEngine.TextEditor.SaveBackup", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SaveBackup();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectAll = new("UnityEngine.TextEditor.SelectAll", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectAll();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectCurrentParagraph = new("UnityEngine.TextEditor.SelectCurrentParagraph", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectCurrentParagraph();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectCurrentWord = new("UnityEngine.TextEditor.SelectCurrentWord", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectCurrentWord();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectDown = new("UnityEngine.TextEditor.SelectDown", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectDown();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectGraphicalLineEnd = new("UnityEngine.TextEditor.SelectGraphicalLineEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectGraphicalLineEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectGraphicalLineStart = new("UnityEngine.TextEditor.SelectGraphicalLineStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectGraphicalLineStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectLeft = new("UnityEngine.TextEditor.SelectLeft", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectLeft();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectNone = new("UnityEngine.TextEditor.SelectNone", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectNone();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectParagraphBackward = new("UnityEngine.TextEditor.SelectParagraphBackward", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectParagraphBackward();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectParagraphForward = new("UnityEngine.TextEditor.SelectParagraphForward", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectParagraphForward();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectRight = new("UnityEngine.TextEditor.SelectRight", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectRight();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectTextEnd = new("UnityEngine.TextEditor.SelectTextEnd", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectTextEnd();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectTextStart = new("UnityEngine.TextEditor.SelectTextStart", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectTextStart();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectToEndOfPreviousWord = new("UnityEngine.TextEditor.SelectToEndOfPreviousWord", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectToEndOfPreviousWord();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectToStartOfNextWord = new("UnityEngine.TextEditor.SelectToStartOfNextWord", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectToStartOfNextWord();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectUp = new("UnityEngine.TextEditor.SelectUp", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectUp();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectWordLeft = new("UnityEngine.TextEditor.SelectWordLeft", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectWordLeft();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _SelectWordRight = new("UnityEngine.TextEditor.SelectWordRight", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.SelectWordRight();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		private static readonly LuaFunction _ToString = new("UnityEngine.TextEditor.ToString", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

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

		private static readonly LuaFunction _Undo = new("UnityEngine.TextEditor.Undo", (_context, _buffer, _) =>
		{
			var argCount = _context.ArgumentCount;
			var arg0 = _context.GetArgument(0);
			var _this = arg0.Read<Lua_UnityEngine_TextEditor>();

			switch (argCount)
			{
				case 0:
				{
						_this.m_Instance.Undo();
						return new ValueTask<Int32>(0);
				}
				default: throw new LuaRuntimeException(_context.State.GetTraceback(), $"argument count mismatch, got {_context.ArgumentCount} args");
			}
		});

		internal static LuaValue TryGetValue(Lua_UnityEngine_TextEditor instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				case "Backspace": return _Backspace;
				case "CanPaste": return _CanPaste;
				case "Copy": return _Copy;
				case "Cut": return _Cut;
				case "Delete": return _Delete;
				case "DeleteLineBack": return _DeleteLineBack;
				case "DeleteSelection": return _DeleteSelection;
				case "DeleteWordBack": return _DeleteWordBack;
				case "DeleteWordForward": return _DeleteWordForward;
				case "DetectFocusChange": return _DetectFocusChange;
				case "DrawCursor": return _DrawCursor;
				case "ExpandSelectGraphicalLineEnd": return _ExpandSelectGraphicalLineEnd;
				case "ExpandSelectGraphicalLineStart": return _ExpandSelectGraphicalLineStart;
				case "FindStartOfNextWord": return _FindStartOfNextWord;
				case "GetHashCode": return _GetHashCode;
				case "Insert": return _Insert;
				case "MouseDragSelectsWholeWords": return _MouseDragSelectsWholeWords;
				case "MoveDown": return _MoveDown;
				case "MoveGraphicalLineEnd": return _MoveGraphicalLineEnd;
				case "MoveGraphicalLineStart": return _MoveGraphicalLineStart;
				case "MoveLeft": return _MoveLeft;
				case "MoveLineEnd": return _MoveLineEnd;
				case "MoveLineStart": return _MoveLineStart;
				case "MoveParagraphBackward": return _MoveParagraphBackward;
				case "MoveParagraphForward": return _MoveParagraphForward;
				case "MoveRight": return _MoveRight;
				case "MoveSelectionToAltCursor": return _MoveSelectionToAltCursor;
				case "MoveTextEnd": return _MoveTextEnd;
				case "MoveTextStart": return _MoveTextStart;
				case "MoveToEndOfPreviousWord": return _MoveToEndOfPreviousWord;
				case "MoveToStartOfNextWord": return _MoveToStartOfNextWord;
				case "MoveUp": return _MoveUp;
				case "MoveWordLeft": return _MoveWordLeft;
				case "MoveWordRight": return _MoveWordRight;
				case "OnFocus": return _OnFocus;
				case "OnLostFocus": return _OnLostFocus;
				case "Paste": return _Paste;
				case "ReplaceSelection": return _ReplaceSelection;
				case "SaveBackup": return _SaveBackup;
				case "SelectAll": return _SelectAll;
				case "SelectCurrentParagraph": return _SelectCurrentParagraph;
				case "SelectCurrentWord": return _SelectCurrentWord;
				case "SelectDown": return _SelectDown;
				case "SelectGraphicalLineEnd": return _SelectGraphicalLineEnd;
				case "SelectGraphicalLineStart": return _SelectGraphicalLineStart;
				case "SelectLeft": return _SelectLeft;
				case "SelectNone": return _SelectNone;
				case "SelectParagraphBackward": return _SelectParagraphBackward;
				case "SelectParagraphForward": return _SelectParagraphForward;
				case "SelectRight": return _SelectRight;
				case "SelectTextEnd": return _SelectTextEnd;
				case "SelectTextStart": return _SelectTextStart;
				case "SelectToEndOfPreviousWord": return _SelectToEndOfPreviousWord;
				case "SelectToStartOfNextWord": return _SelectToStartOfNextWord;
				case "SelectUp": return _SelectUp;
				case "SelectWordLeft": return _SelectWordLeft;
				case "SelectWordRight": return _SelectWordRight;
				case "ToString": return _ToString;
				case "Undo": return _Undo;
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_TextEditor instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TextEditor>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TextEditor>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_TextEditor Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_TextEditor v) => new(v);
		public Lua_UnityEngine_TextEditor(UnityEngine.TextEditor instance) { m_Instance = instance; }
		private UnityEngine.TextEditor m_Instance;
		public UnityEngine.TextEditor Instance { get => m_Instance; set => m_Instance = value; }
		public override String ToString() => m_Instance.ToString();
	}
	public sealed class Lua_UnityEngine_TextEditor_static : ILuaUserData
	{
		public static readonly string[] TypeFullName = { "UnityEngine", "TextEditor" };

		internal static LuaValue TryGetValue(Lua_UnityEngine_TextEditor_static instance, String key, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Getter);
			}
		}

		internal static LuaValue TrySetValue(Lua_UnityEngine_TextEditor_static instance, String key, LuaValue value, LuaFunctionExecutionContext context)
		{
			switch (key)
			{
				default: throw new LunyBindingException(instance, key, context, BindingType.Setter);
			}
		}

		private static readonly LuaFunction __index = new(Metamethods.Index, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TextEditor_static>(0);
			var key = context.GetArgument<String>(1);
			buffer.Span[0] = TryGetValue(instance, key, context);
			return new ValueTask<Int32>(1);
		});
		private static readonly LuaFunction __newindex = new(Metamethods.NewIndex, (context, buffer, _) =>
		{
			var instance = context.GetArgument<Lua_UnityEngine_TextEditor_static>(0);
			var key = context.GetArgument<String>(1);
			var value = context.GetArgument(2);
			TrySetValue(instance, key, value, context);
			return new ValueTask<Int32>(0);
		});

		private static LuaTable s_MetaTable;
		public LuaTable Metatable
		{
			get => s_MetaTable ??= LunyMetatable.Create(__index, __newindex);
			set => throw new NotSupportedException("Lua_UnityEngine_TextEditor_static Metatable not assignable");
		}

		public static implicit operator LuaValue(Lua_UnityEngine_TextEditor_static v) => new(v);
	}

}
