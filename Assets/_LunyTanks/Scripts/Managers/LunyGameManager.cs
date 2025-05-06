// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using CodeSmile.Luny.Api;
using Lua;
using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyGameManager : LunyScript
	{
		public Int32 m_NumRoundsToWin = 3; // The number of rounds a single player has to win to win the game.
		public Single m_StartDelay = 3f; // The delay between the start of RoundStarting and RoundPlaying phases.
		public Single m_EndDelay = 3f; // The delay between the end of RoundPlaying and RoundEnding phases.
		public LunyCameraControl m_CameraControl; // Reference to the CameraControl script for control during different phases.

		[Header("Tanks Prefabs")]
		public GameObject m_Tank1Prefab; // The Prefab used by the tank in Slot 1 of the Menu
		public GameObject m_Tank2Prefab; // The Prefab used by the tank in Slot 2 of the Menu
		public GameObject m_Tank3Prefab; // The Prefab used by the tank in Slot 3 of the Menu
		public GameObject m_Tank4Prefab; // The Prefab used by the tank in Slot 4 of the Menu

		public LunyTankManager[] m_SpawnPoints; // A collection of managers for enabling and disabling different aspects of the tanks.

		// Data about the selected tanks passed from the menu to the GameManager
		public class PlayerData
		{
			public Boolean IsComputer;
			public Color TankColor;
			public GameObject UsedPrefab;
			public Int32 ControlIndex;
		}

		protected override void OnBeforeScriptAwake()
		{
			SetInt(nameof(m_NumRoundsToWin).Substring(2), m_NumRoundsToWin);
			SetFloat(nameof(m_StartDelay).Substring(2), m_StartDelay);
			SetFloat(nameof(m_EndDelay).Substring(2), m_EndDelay);
			SetObject(nameof(m_CameraControl).Substring(2), m_CameraControl);
			SetObject(nameof(m_Tank1Prefab).Substring(2), m_Tank1Prefab);
			SetObject(nameof(m_Tank2Prefab).Substring(2), m_Tank2Prefab);
			SetObject(nameof(m_Tank3Prefab).Substring(2), m_Tank3Prefab);
			SetObject(nameof(m_Tank4Prefab).Substring(2), m_Tank4Prefab);

			// TankManager is a standard C# class thus simply serialize its fields to a LuaTable
			var tanksTable = new LuaTable();
			for (var i = 0; i < m_SpawnPoints.Length; i++)
				tanksTable[i + 1] = m_SpawnPoints[i].ToLua();

			SetTable(nameof(m_SpawnPoints).Substring(2), tanksTable);
		}

		public void StartGame(PlayerData[] playerData)
		{
			Debug.LogWarning("FIXME: Start Game called from C#");
			var playerDataTable = new LuaTable();
			for (var i = 0; i < playerData.Length; i++)
			{
				var data = new LuaTable();
				data[nameof(PlayerData.IsComputer)] = playerData[i].IsComputer;
				data[nameof(PlayerData.TankColor)] = LunyColor.Bind(playerData[i].TankColor);
				data[nameof(PlayerData.UsedPrefab)] = LunyGameObject.Bind(playerData[i].UsedPrefab);
				data[nameof(PlayerData.ControlIndex)] = playerData[i].ControlIndex;
				playerDataTable[i + 1] = data;
			}
			Script.Invoke("StartGame", playerDataTable);
		}
	}
}
