// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CodeSmile.Luny.Tanks
{
	// Handle a simple pause menu displaying the control and allowing to restart the game or quit it.
	public sealed class LunyPauseMenu : LunyScript
	{
		public RectTransform m_PauseMenuRoot; // Reference to the root Transform of the Pause Menu
		public RectTransform m_PauseMenuButtonsRoot; // Reference to the root containing the button of the menu
		public Button m_ControlScreenButton; // Reference to the button opening the control screen

		public RectTransform m_ControlMenuRoot; // Reference to the root of the Control Screen
		public Button
			m_ControlMenuBackButton; // Reference to the button that allow to go back to the Pause Menu from Control screen

		public Button m_SelectTankButton; // Reference to the button that go back to tank selection
		public Button m_QuitButton; // Reference to the button that quit the Game

		public void Init()
		{
			// Setup clicking on the back button on the Control Screen disabling the Control Screen and re-enabling the pause menu buttons
			m_ControlMenuBackButton.onClick.AddListener(() =>
			{
				m_ControlMenuRoot.gameObject.SetActive(false);
				m_PauseMenuButtonsRoot.gameObject.SetActive(true);
			});

			m_PauseMenuButtonsRoot.gameObject.SetActive(false);

			// Setup clicking on the Control button enabling the Control Screen and disabling the pause menu buttons
			m_ControlScreenButton.onClick.AddListener(() =>
			{
				m_ControlMenuRoot.gameObject.SetActive(true);
				m_PauseMenuButtonsRoot.gameObject.SetActive(false);
			});

			// Setup clicking on the Tank Selection button reloading the scene (effectively sending back to the main menu)
			m_SelectTankButton.onClick.AddListener(() =>
			{
				Time.timeScale = 1.0f;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			});

			// If the application is the editor or a web build, quitting the game is impossible...
			if (Application.platform == RuntimePlatform.WebGLPlayer || Application.isEditor)
			{
				// so disable the quit button
				m_QuitButton.gameObject.SetActive(false);
			}
			else
			{
				// otherwise setup the quit button to Quit the application
				m_QuitButton.gameObject.SetActive(true);
				m_QuitButton.onClick.AddListener(Application.Quit);
			}

			m_PauseMenuRoot.gameObject.SetActive(false);
			m_PauseMenuButtonsRoot.gameObject.SetActive(true);
		}

		public void TogglePause()
		{
			if (m_PauseMenuRoot == null || m_PauseMenuRoot.gameObject == null || m_ControlMenuRoot == null ||
			    m_ControlMenuRoot.gameObject == null || m_PauseMenuButtonsRoot == null ||
			    m_PauseMenuButtonsRoot.gameObject == null)
				return;

			// When toggling, swap the value of active for the pause menu root.
			var state = !m_PauseMenuRoot.gameObject.activeSelf;
			m_PauseMenuRoot.gameObject.SetActive(state);

			// set the time scale to 0.0f, which is a simple way of "pausing" the game as everything will return 0 as
			// delta time and nothing will move anymore.
			Time.timeScale = state ? 0.0f : 1.0f;

			m_ControlMenuRoot.gameObject.SetActive(false);
			m_PauseMenuButtonsRoot.gameObject.SetActive(true);
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
