// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

public class LoadUserScript : MonoBehaviour
{
	[SerializeField] private RuntimeScriptEditor m_ScriptEditor;

	private void OnEnable() => m_ScriptEditor?.CompileUserScript(m_ScriptEditor?.UserScript);
}
