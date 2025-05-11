// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class RuntimeScriptEditor : MonoBehaviour
{
	private const String PrefsKey = "UserScript";
	private const String DefaultScript =
		"\n-- This function instantiates shells (projectiles) and returns preset data for flight and impact.\n\nfunction FireShell(ShellPrefab, FireTransform, LaunchForce, ExplosionForce, ExplosionRadius, Damage)\n\n    local shellPos = FireTransform.position\n    local shellRot = FireTransform.rotation\n\n    -- Create one or more instances of the shell and store them in the table 'instances'\n    local instances = {}\n    instances[1] = gameobject.Instantiate(ShellPrefab, shellPos, shellRot)\n\n    -- Uncomment the following lines to create a multi-shot:\n    --shellPos = shellPos + vector3.up\n    --instances[2] = gameobject.Instantiate(ShellPrefab, shellPos, shellRot)\n    --shellPos = shellPos + vector3.up\n    --instances[3] = gameobject.Instantiate(ShellPrefab, shellPos, shellRot)\n\n    -- Set the shell's properties and return them\n    local shellData = {}\n    shellData.Instances = instances\n    shellData.Velocity = LaunchForce * FireTransform.forward\n    -- try launching straight up?\n    --shellData.Velocity = LaunchForce * 0.2 * FireTransform.up + FireTransform.forward * 3\n    shellData.ExplosionForce = ExplosionForce\n    shellData.ExplosionRadius = ExplosionRadius\n    shellData.Damage = Damage\n    -- try 'instant death'\n    --shellData.Damage = Damage * 100\n\n    return shellData\nend";
	[SerializeField] private TMP_InputField m_UserScript;
	[SerializeField] private TMP_Text m_ErrorText;

	public String UserScript
	{
		get => PlayerPrefs.GetString(PrefsKey, DefaultScript);
		private set => PlayerPrefs.SetString(PrefsKey, value);
	}

	private void OnEnable()
	{
		m_ErrorText.text = "";
		m_UserScript.text = UserScript;
	}

	private void OnDisable() => UserScript = m_UserScript.text;

	public void TryCompileAndClose()
	{
		if (CompileUserScript(m_UserScript.text))
			gameObject.SetActive(false);
	}

	public void ResetScript() => m_UserScript.text = UserScript = DefaultScript;

	public Boolean CompileUserScript(String script)
	{
		var success = false;
		var lua = Luny.Singleton.Lua;
		try
		{
			lua.DoString(script, "FireShell.lua");
			success = true;
		}
		catch (Exception e)
		{
			m_ErrorText.text = e.Message;
		}

		return success;
	}
}
