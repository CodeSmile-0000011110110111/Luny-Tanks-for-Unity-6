// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny.Api;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyTankHealth : LunyScript
	{
		[Tooltip("The amount of health each tank starts with.")]
		[SerializeField] private Single m_StartingHealth = 100f;

		[Tooltip("The slider to represent how much health the tank currently has.")]
		[SerializeField] private Slider m_Slider;

		[Tooltip("The image component of the slider.")]
		[SerializeField] private Image m_FillImage;

		[Tooltip("The color the health bar will be when on full health.")]
		[SerializeField] private Color m_FullHealthColor = Color.green;

		[Tooltip("The color the health bar will be when on no health.")]
		[SerializeField] private Color m_ZeroHealthColor = Color.red;

		[Tooltip("A prefab that will be instantiated in Awake, then used whenever the tank dies.")]
		[SerializeField] private GameObject m_ExplosionPrefab;

		// FIXME: remove
		public Single StartingHealth
		{
			get
			{
				Debug.LogWarning("StartingHealth - REPLACE ME");
				return GetFloat(nameof(StartingHealth));
			}
		}

		public Boolean HasShield => throw new NotImplementedException();

		protected override void OnBeforeScriptAwake()
		{
			SetFloat(nameof(m_StartingHealth).Substring(2), m_StartingHealth);
			SetUserData(nameof(m_Slider).Substring(2), new LunyUISlider(m_Slider));
			SetUserData(nameof(m_FillImage).Substring(2), new LunyUIImage(m_FillImage));
			SetUserData(nameof(m_FullHealthColor).Substring(2), new LunyColor(m_FullHealthColor));
			SetUserData(nameof(m_ZeroHealthColor).Substring(2), new LunyColor(m_ZeroHealthColor));
			SetObject(nameof(m_ExplosionPrefab).Substring(2), m_ExplosionPrefab);
		}

		// FIXME: remove
		public void TakeDamage(Single damage)
		{
			Debug.LogWarning("TakeDamage - REPLACE ME");
			Script.Invoke(nameof(TakeDamage), damage);
		}

		public void ToggleShield(Single shieldAmount) => throw new NotImplementedException();

		public void IncreaseHealth(Single healAmount) => throw new NotImplementedException();

		public void ToggleInvincibility() => throw new NotImplementedException();
	}
}
