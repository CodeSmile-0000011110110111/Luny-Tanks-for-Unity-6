using CodeSmile.Luny;
using TMPro;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	// This is used to quickly find the GameObject it is added to by using FindObjectOfType.
	// Used by the GameManager to find the text used to display game informations
	public sealed class LunyMessageTextReference : LunyScript
	{
		public TextMeshProUGUI Text => GetComponent<TextMeshProUGUI>();


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
