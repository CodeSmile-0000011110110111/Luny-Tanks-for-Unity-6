using CodeSmile.Luny;
using Lua;
using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.InputSystem.Users;
using UnityEngine.UIElements;

namespace CodeSmile.Luny.Tanks
{
    [Serializable]
    public class LunyTankManager
    {
        // This class is to manage various settings on a tank.
        // It works with the GameManager class to control how the tanks behave
        // and whether or not players have control of their tank in the
        // different phases of the game.

        public Transform m_SpawnPoint;                          // The position and direction the tank will have when it spawns.

        [HideInInspector] public Color m_PlayerColor;           // This is the color this tank will be tinted.
        [HideInInspector] public int m_PlayerNumber;            // This specifies which player this the manager for.
        [HideInInspector] public string m_ColoredPlayerText;    // A string that represents the player with their number colored to match their tank.
        [HideInInspector] public GameObject m_Instance;         // A reference to the instance of the tank when it is created.
        [HideInInspector] public int m_Wins;                    // The number of wins this player has so far.
        [HideInInspector] public bool m_ComputerControlled;     // Is that tank computer controlled

        public int ControlIndex { get; set; } = 1;              //this defines the index of the control 1 = left keyboard or pad, 2 = right keyboard, -1 = no control


        private LunyTankMovement m_Movement;                        // Reference to tank's movement script, used to disable and enable control.
        private LunyTankShooting m_Shooting;                        // Reference to tank's shooting script, used to disable and enable control.
        private GameObject m_CanvasGameObject;                  // Used to disable the world space UI during the Starting and Ending phases of each round.

        private LunyTankAI m_AI;                                    // The Tank AI script that let a tank be a bot controlled by the computer
        private InputUser m_InputUser;                          // The Input user link to that tank. Input user identify a single player in the Input system

        public LuaValue ToLua()
        {
            var table = new LuaTable();
            table.SetObject(nameof(m_SpawnPoint).Substring(2), m_SpawnPoint);
            return table;
        }
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
