// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny.Api;
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyTankShooting : LunyScript
	{
		public Rigidbody m_Shell; // Prefab of the shell.
		public Transform m_FireTransform; // A child of the tank where the shells are spawned.
		public Slider m_AimSlider; // A child of the tank that displays the current launch force.
		public AudioSource m_ShootingAudio; // Reference to the audio source used to play the shooting audio. NB: different to the movement audio source.
		public AudioClip m_ChargingClip; // Audio that plays when each shot is charging up.
		public AudioClip m_FireClip; // Audio that plays when each shot is fired.
		[Tooltip("The speed in unit/second the shell have when fired at minimum charge")]
		public Single m_MinLaunchForce = 5f; // The force given to the shell if the fire button is not held.
		[Tooltip("The speed in unit/second the shell have when fired at max charge")]
		public Single m_MaxLaunchForce = 20f; // The force given to the shell if the fire button is held for the max charge time.
		[Tooltip("The maximum time spent charging. When charging reach that time, the shell is fired at MaxLaunchForce")]
		public Single m_MaxChargeTime = 0.75f; // How long the shell can charge for before it is fired at max force.
		[Tooltip("The time that must pass before being able to shoot again after a shot")]
		public Single m_ShotCooldown = 1.0f; // The time required between 2 shots
		[Header("Shell Properties")]
		[Tooltip("The amount of health removed to a tank if they are exactly on the landing spot of a shell")]
		public Single m_MaxDamage = 100f; // The amount of damage done if the explosion is centred on a tank.
		[Tooltip("The force of the explosion at the shell position. It is in newton, so it need to be high, so keep it 500 and above")]
		public Single m_ExplosionForce = 1000f; // The amount of force added to a tank at the centre of the explosion.
		[Tooltip("The radius of the explosion in Unity unit. Force decrease with distance to the center, and an tank further than this from the shell explosion won't be impacted by the explosion")]
		public Single m_ExplosionRadius = 5f; // The maximum distance away from the explosion tanks can be and are still affected.

		protected override void OnBeforeScriptAwake()
		{
			SetUserData(nameof(m_Shell).Substring(2), new LunyRigidbody(m_Shell));
			SetUserData(nameof(m_FireTransform).Substring(2), new LunyTransform(m_FireTransform));
			SetUserData(nameof(m_AimSlider).Substring(2), new LunyUISlider(m_AimSlider));
			SetUserData(nameof(m_ShootingAudio).Substring(2), new LunyAudioSource(m_ShootingAudio));
			SetUserData(nameof(m_ChargingClip).Substring(2), new LunyAudioClip(m_ChargingClip));
			SetUserData(nameof(m_FireClip).Substring(2), new LunyAudioClip(m_FireClip));
			SetFloat(nameof(m_MinLaunchForce).Substring(2), m_MinLaunchForce);
			SetFloat(nameof(m_MaxLaunchForce).Substring(2), m_MaxLaunchForce);
			SetFloat(nameof(m_MaxChargeTime).Substring(2), m_MaxChargeTime);
			SetFloat(nameof(m_ShotCooldown).Substring(2), m_ShotCooldown);
			SetFloat(nameof(m_MaxDamage).Substring(2), m_MaxDamage);
			SetFloat(nameof(m_ExplosionForce).Substring(2), m_ExplosionForce);
			SetFloat(nameof(m_ExplosionRadius).Substring(2), m_ExplosionRadius);
		}
	}
}
