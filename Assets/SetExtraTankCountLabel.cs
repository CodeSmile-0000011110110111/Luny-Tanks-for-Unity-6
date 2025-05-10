// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SetExtraTankCountLabel : MonoBehaviour
{
	private TMP_Text m_Text;

	private void Awake()
	{
		m_Text = GetComponent<TMP_Text>();
		Debug.Assert(m_Text != null);
	}

	public void SetExtraTankCount(Slider slider) => m_Text.text = $"Companion Tanks: {slider.value}";
}
