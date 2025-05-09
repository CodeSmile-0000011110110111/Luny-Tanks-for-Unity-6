// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
#if UNITY_EDITOR
using UnityEditor.UIElements;
#endif

namespace CodeSmile.Luny.Tanks
{
	[Serializable]
	public class LunyTankManager
	{
		public Transform m_SpawnPoint; // The position and direction the tank will have when it spawns.
	}

#if UNITY_EDITOR
	// This is a class only used in the unity editor (and not in the final game). It customizes how the TankManager component
	// will appear in the Inspector. The default make a foldout entry where SpawnPoint is "inside" the TankManager foldout
	// in the manager array in the GameManager. This change this behavior to directly display the spawn point in the TankManager
	// Inspector, simplifying the display in the GameManager.
	[CustomPropertyDrawer(typeof(LunyTankManager))]
	public class TankManagerDrawer : PropertyDrawer
	{
		public override VisualElement CreatePropertyGUI(SerializedProperty property) =>
			new PropertyField(property.FindPropertyRelative(nameof(LunyTankManager.m_SpawnPoint)));
	}
#endif
}
