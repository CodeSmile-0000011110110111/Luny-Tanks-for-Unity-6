using CodeSmile.Luny;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyPowerUpFX : LunyScript
	{
		private AudioSource m_PowerUpAudioSource; // Reference to the AudioSource component
		private float lifeTime = 3f; // Time in seconds that this GameObject will be in scene before being destroyed

		private void Start()
		{
			m_PowerUpAudioSource = GetComponent<AudioSource>();
			m_PowerUpAudioSource.PlayDelayed(0);
		}

		private void Update()
		{
			// Reduces its lifetime to know when to destroy this effect
			lifeTime -= Time.deltaTime;
			if (lifeTime <= 0.0f)
				Destroy(gameObject);
		}

		// Awake cannot be overridden, use OnAwake instead. The script has not been loaded at this point!
		protected override void OnAwake() {}

		// Script was run and returned a LuaTable. Script's Awake() function has not been called yet.
		// You may want to get/set initial script variables before script's Awake():
		protected override void OnBeforeScriptAwake()
		{
			// Variables are set to the script table (commonly named 'script'): 'print(script.ImportantMessage)'
			SetString("ImportantMessage", "Testing One-Two-Three ..");

			// If you need the value of 'script.OhWowThatsCoolBool' assigned by the Lua script:
			var datBool = GetBool("OhWowThatsCoolBool");
		}
	}
}
