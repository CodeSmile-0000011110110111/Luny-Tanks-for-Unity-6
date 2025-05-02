using CodeSmile.Luny;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;

namespace CodeSmile.Luny.Tanks
{
	// Handle on screen UI Control used for mobile platform. By default, will auto-disable itself when not on mobile
	// Default execution is low to ensure it disable itself before any other script so other scripts can use its enabled
	// status as a test to know if on a mobile platform or not.
	[DefaultExecutionOrder(-90)]
	public sealed class LunyMobileUIControl : LunyScript
	{
		public static LunyMobileUIControl Instance { get; private set; }

		[Tooltip("If true (the default) the GameObject on which this is will get disabled when not on a mobile platform")]
		public bool AutoDisableOnNonMobilePlatform = true;

		public InputDevice Device => m_Control.control.device;

		private OnScreenControl m_Control;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		void Awake()
		{
			Instance = this;

			m_Control = GetComponentInChildren<OnScreenControl>();
			if (AutoDisableOnNonMobilePlatform && !Application.isMobilePlatform)
			{
				gameObject.SetActive(false);
			}
		}

		public void Show()
		{
			// On non mobile platform with the auto disable, we cannot show it
			if (AutoDisableOnNonMobilePlatform && !Application.isMobilePlatform)
			{
				return;
			}

			gameObject.SetActive(true);
		}

		public void Hide()
		{
			if (AutoDisableOnNonMobilePlatform && !Application.isMobilePlatform)
			{
				return;
			}

			gameObject.SetActive(false);
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
