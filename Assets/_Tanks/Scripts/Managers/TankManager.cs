using System;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;
#endif
using UnityEngine;
using UnityEngine.InputSystem.Users;
using UnityEngine.UIElements;

namespace Tanks.Complete
{
    [Serializable]
    public class TankManager
    {
        // This class is to manage various settings on a tank.
        // It works with the GameManager class to control how the tanks behave
        // and whether or not players have control of their tank in the 
        // different phases of the game.

        [HideInInspector] public Color m_PlayerColor;           // This is the color this tank will be tinted.
        public Transform m_SpawnPoint;                          // The position and direction the tank will have when it spawns.
        [HideInInspector] public int m_PlayerNumber;            // This specifies which player this the manager for.
        [HideInInspector] public string m_ColoredPlayerText;    // A string that represents the player with their number colored to match their tank.
        [HideInInspector] public GameObject m_Instance;         // A reference to the instance of the tank when it is created.
        [HideInInspector] public int m_Wins;                    // The number of wins this player has so far.
        [HideInInspector] public bool m_ComputerControlled;     // Is that tank computer controlled
        
        public int ControlIndex { get; set; } = 1;              //this defines the index of the control 1 = left keyboard or pad, 2 = right keyboard, -1 = no control


        private TankMovement m_Movement;                        // Reference to tank's movement script, used to disable and enable control.
        private TankShooting m_Shooting;                        // Reference to tank's shooting script, used to disable and enable control.
        private GameObject m_CanvasGameObject;                  // Used to disable the world space UI during the Starting and Ending phases of each round.
        
        private TankAI m_AI;                                    // The Tank AI script that let a tank be a bot controlled by the computer
        private InputUser m_InputUser;                          // The Input user link to that tank. Input user identify a single player in the Input system
        
        public void Setup (GameManager manager)
        {
            // Get references to the components.
            m_Movement = m_Instance.GetComponent<TankMovement> ();
            m_Shooting = m_Instance.GetComponent<TankShooting> ();
            m_AI = m_Instance.GetComponent<TankAI> ();
            m_CanvasGameObject = m_Instance.GetComponentInChildren<Canvas> ().gameObject;

            // Assign the Input User of that Tank to the script controlling input system binding, so the move/fire actions
            // get only triggered by the right input for that users (e.g. arrow doesn't trigger move if that input user use WASD)
            var inputUser = m_Instance.GetComponent<TankInputUser>();
            inputUser.SetNewInputUser(m_InputUser);

            // Toggle computer controlled on the movement/firing if this tank was tagged as being computer controlled
            m_Movement.m_IsComputerControlled = m_ComputerControlled;
            m_Shooting.m_IsComputerControlled = m_ComputerControlled;
            
            // Pass along the player number and control index to the movement components. See the TankMovement script for
            // hose those are used to decided which input the movement respond to.
            m_Movement.m_PlayerNumber = m_PlayerNumber;
            m_Movement.ControlIndex = ControlIndex;

            // If this tank is computer controlled, add a TankAI component that take care of controlling the behavior
            if(m_ComputerControlled)
            {
                m_AI = m_Instance.AddComponent<TankAI>();
                m_AI.Setup(manager);
            }
            
            // Create a string using the correct color that says 'PLAYER 1' etc based on the tank's color and the player's number.
            m_ColoredPlayerText = "<color=#" + ColorUtility.ToHtmlStringRGB(m_PlayerColor) + ">PLAYER " + m_PlayerNumber + "</color>";

            // Get all of the renderers of the tank.
            MeshRenderer[] renderers = m_Instance.GetComponentsInChildren<MeshRenderer> ();

            // Go through all the renderers...
            for (int i = 0; i < renderers.Length; i++)
            {
                var renderer = renderers[i];
                for (int j = 0; j < renderer.materials.Length; ++j)
                {
                    // If the material is the tank color one...
                    if (renderer.materials[j].name.Contains("TankColor"))
                    {
                        // change its color to the player color
                        renderer.materials[j].color = m_PlayerColor;
                    }
                }
            }
        }


        // Used during the phases of the game where the player shouldn't be able to control their tank.
        public void DisableControl ()
        {
            m_Movement.enabled = false;
            m_Shooting.enabled = false;
            if(m_ComputerControlled)
                m_AI.enabled = false;

            m_CanvasGameObject.SetActive (false);
        }


        // Used during the phases of the game where the player should be able to control their tank.
        public void EnableControl ()
        {
            m_Movement.enabled = true;
            m_Shooting.enabled = true;
            if(m_ComputerControlled)
                m_AI.enabled = true;

            m_CanvasGameObject.SetActive (true);
        }


        // Used at the start of each round to put the tank into it's default state.
        public void Reset ()
        {
            m_Instance.transform.position = m_SpawnPoint.position;
            m_Instance.transform.rotation = m_SpawnPoint.rotation;

            m_Instance.SetActive (false);
            m_Instance.SetActive (true);
        }
    }
    
    
    #if UNITY_EDITOR
    // This is a class only used in the unity editor (and not in the final game). It customizes how the TankManager component
    // will appear in the Inspector. The default make a foldout entry where SpawnPoint is "inside" the TankManager foldout
    // in the manager array in the GameManager. This change this behavior to directly display the spawn point in the TankManager
    // Inspector, simplifying the display in the GameManager.
    [CustomPropertyDrawer(typeof(TankManager))]
    public class TankManagerDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var itemSlot = new PropertyField(property.FindPropertyRelative(nameof(TankManager.m_SpawnPoint)));
            return itemSlot;
        }
    }
    #endif
}