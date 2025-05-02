using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace Tanks.Complete
{
    // This handle both the start menu (selecting which tank each player use) and the pause menu if present
    public class GameUIHandler : MonoBehaviour
    {
        public GameManager m_GameManager;               // Reference to the GameManager in the scene

        [Header("Start Menu")] 
        public RectTransform m_StartMenuRoot;           // The GameObject root that is parent of the Start Menu
        public Button m_StartButton;                    // The Button that will start the game

        [Tooltip("The slot in the UI that can be taken by a player or computer tank")]
        public StartMenuSlot[] m_PlayerSlots;           // The Slots in the Start Menu that display the available tanks and handle players selections

        public OnScreenButton m_PauseMenuButton;        // Reference to OnScreenButton that emulate pressing a Gamepad Start button
        
        private TextMeshProUGUI m_StartButtonText;      // Reference to the Text on the Start Button 
        private int m_SlotUsed = 0;                     // How many slots are currently used, the game need at least 2 to start

        private PauseMenu m_PauseMenu;                  // Reference to the pause menu (if present in the scene)
        private InputAction m_PauseAction;              // The InputAction that will trigger the pause menu
        
        private CanvasScaler m_CanvasScaler;

        private void Awake()
        {
            // URP require stacking camera to be explicitly added to the stack on the main camera
            // so this check if the main camera already have our parent camera in their stack and otherwise add it.
            Camera cam = GetComponentInParent<Camera>();

            m_CanvasScaler = GetComponentInParent<CanvasScaler>();

            var data = Camera.main.GetUniversalAdditionalCameraData();
            if (!data.cameraStack.Contains(cam))
            {
                data.cameraStack.Add(cam);
            }
        }

        private void Start()
        {
            // Hide the Mobile UI Control if present in the scene. This will have no effect on desktop, but on mobile we
            // do not want the mobile UI control on top of the start menu
            if (MobileUIControl.Instance != null)
                MobileUIControl.Instance.Hide();

            // Setup the Start button to StartGame when clicked
            m_StartButton.onClick.AddListener(StartGame);
            // but disable it until we have at least 2 tank selected
            m_StartButton.interactable = false;
            m_StartButtonText = m_StartButton.GetComponentInChildren<TextMeshProUGUI>();
            m_StartButtonText.text = "2 Tanks required";
            
            // Disable the on screen pause button
            m_PauseMenuButton.gameObject.SetActive(false);

            // Pause Menu
            m_PauseMenu = FindAnyObjectByType<PauseMenu>(FindObjectsInactive.Include);
            if (m_PauseMenu != null)
            {
                m_PauseMenu.Init();
                //clone the action so it doesn't change the default one
                m_PauseAction = InputSystem.actions.FindAction("Pause").Clone();
                var rectTransform = m_PauseMenuButton.GetComponent<RectTransform>();
                //force the button to be on top of everything so it can be clicked no matter what other screen is shown 
                rectTransform.SetAsLastSibling();
            }

            // We use an array because the code was originally written to have any number of prefabs and player, but
            // this was fixed to always 4 tanks during development, so to avoid rewriting the code for static number,
            // we simply transform our 4 static tank prefab into an array
            var tanksPrefabs =
                new[]
                {
                    m_GameManager.m_Tank1Prefab, m_GameManager.m_Tank2Prefab, m_GameManager.m_Tank3Prefab,
                    m_GameManager.m_Tank4Prefab
                };

            // Go over all the player slots (4) and initialize them...
            for (int i = 0; i < m_PlayerSlots.Length; ++i)
            {
                var slot = m_PlayerSlots[i];

                // set the preview on the slot 
                slot.SetTankPreview(tanksPrefabs.Length > i ? tanksPrefabs[i] : tanksPrefabs[0]);

                var i1 = i;
                slot.m_AddControlButton.onClick.AddListener(() =>
                {
                    slot.AddTank();
                    m_SlotUsed += 1;

                    //we check if they are player 1 already used
                    bool player1Present = false;
                    for (int j = 0; j < m_PlayerSlots.Length; ++j)
                    {
                        if (i1 == j) continue;

                        if (m_PlayerSlots[j].PlayerControlling == 1)
                            player1Present = true;
                    }

                    // If there is no Player 1 tank, this new tank is assigned player 1
                    if (!player1Present)
                    {
                        slot.SetPlayerControlling(1);
                    }
                    else
                    {
                        // Otherwise, this tank is a computer controlled tank by default
                        slot.SetPlayerControlling(-1);
                    }

                    // If 2 slots or more are now used, we can start the game, so re-enable the Start button and update
                    // the text on the Start button
                    if (m_SlotUsed >= 2)
                    {
                        m_StartButtonText.text = "Start";
                        m_StartButton.interactable = true;
                    }
                });

                // Setup the Off button on the tank controller section
                slot.m_OffControlButton.onClick.AddListener(() =>
                {
                    slot.RemoveTank();
                    m_SlotUsed -= 1;
                    
                    // If after removing that tank from the used tanks we have less than 2 slots open, disable the 
                    // Start button and reset the text to the required warning
                    if (m_SlotUsed < 2)
                    {
                        m_StartButtonText.text = "2 Tanks required";
                        m_StartButton.interactable = false;
                    }
                });

                // Setup the Player 1 control button
                slot.m_P1ControlButton.onClick.AddListener(() =>
                {
                    slot.SetPlayerControlling(1);

                    //check if any other slot are player 1 controlled and switch it to computer
                    for (int j = 0; j < m_PlayerSlots.Length; ++j)
                    {
                        var localSlot = m_PlayerSlots[j];
                        if (localSlot.IsOpen || localSlot == slot) continue;

                        if (localSlot.PlayerControlling == 1)
                        {
                            localSlot.SetPlayerControlling(-1);
                        }
                    }
                });

                // Setup the Player 2 control button
                slot.m_P2ControlButton.onClick.AddListener(() =>
                {
                    slot.SetPlayerControlling(2);

                    //check if any other slot are player 2 controlled and switch it to computer
                    for (int j = 0; j < m_PlayerSlots.Length; ++j)
                    {
                        var localSlot = m_PlayerSlots[j];
                        if (localSlot.IsOpen || localSlot == slot) continue;

                        if (localSlot.PlayerControlling == 2)
                        {
                            localSlot.SetPlayerControlling(-1);
                        }
                    }
                });

                // Setup the Computer control button
                slot.m_ComputerControlButton.onClick.AddListener(() => { slot.SetPlayerControlling(-1); });
            }
        }

        void StartGame()
        {
            // When starting the game, we disable the Start Menu
            m_StartMenuRoot.gameObject.SetActive(false);

            // PlayerData is a structure that allow to pass info between the menu and the GameManager
            List<GameManager.PlayerData> playerData = new List<GameManager.PlayerData>();
            foreach (var slot in m_PlayerSlots)
            {
                if (!slot.IsOpen)
                {
                    playerData.Add(new GameManager.PlayerData()
                    {
                        TankColor = slot.m_SlotColor,
                        IsComputer = slot.IsComputer,
                        ControlIndex = slot.PlayerControlling,
                        UsedPrefab = slot.TankPrefab,
                    });
                }
            }

            m_GameManager.StartGame(playerData.ToArray());

            //Destroy all the preview tanks
            foreach (var slot in m_PlayerSlots)
            {
                Destroy(slot.TankPreview);
            }

            // If there was a Mobile UI Control, we now show it again (on desktop this will do nothing)
            if (MobileUIControl.Instance != null)
                MobileUIControl.Instance.Show();

            // If there is a pause menu, we re-enable the on screen pause button and listen to the pause action to
            // display the pause menu when pressed
            if (m_PauseMenu != null)
            {
                m_PauseAction.performed += evt => { TogglePause(); };
                m_PauseAction.Enable();
                
                m_PauseMenuButton.gameObject.SetActive(true);
            }
        }
        
        private void TogglePause()
        {
            m_PauseMenu.TogglePause();
        }

        private void Update()
        {
            // This help keeping the UI readable in both portrait and landscape mode (game should only be played in landscape
            // but Unity Play cannot enforce an orientation so we need it to be readable even in portrait)
            float ratio = Screen.width / (float)Screen.height;
            m_CanvasScaler.matchWidthOrHeight = ratio > 1.0f ? 1.0f : 0.0f;
        }
    }
}