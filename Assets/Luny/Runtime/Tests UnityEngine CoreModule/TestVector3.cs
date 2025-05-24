// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny;
using Lua;
using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;

public class TestVector3
{
	private const Single Tolerance = 0.0001f;

	private ILunyLua m_Lua;

	[SetUp] public void SetUp() => m_Lua = LuaAssetRegistry.Singleton.DefaultContext.Lua;

	[Test] public void AngleTest()
	{
		var results = RunScript(
			"local from = UnityEngine.Vector3.New(1, 2, 3)\n" +
			"local to = UnityEngine.Vector3.New(4, 5, 6)\n" +
			"return UnityEngine.Vector3.Angle(from, to)\n", nameof(AngleTest));
		var resultLua = results[0].Read<Single>();

		var from = new Vector3(1, 2, 3);
		var to = new Vector3(4, 5, 6);
		var resultCSharp = Vector3.Angle(from, to);

		Debug.Log($"result C#: {resultCSharp}, result Lua: {resultLua}");
		Assert.That(resultCSharp, Is.EqualTo(12.93314).Within(Tolerance));
		Assert.That(resultLua, Is.EqualTo(resultCSharp).Within(Tolerance));
	}

	private LuaValue[] RunScript(String script, String testName)
	{
		var results = m_Lua.DoString(script, testName);
		Assert.That(results, Is.Not.Null, testName);
		return results;
	}
}
