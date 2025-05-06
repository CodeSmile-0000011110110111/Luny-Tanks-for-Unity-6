using CodeSmile.Luny;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace CodeSmile.Luny.Tanks
{
	//Ensure it run before the TankShooting component as TankShooting grabs the InputUser from this when there are no
	//GameManager set (used during learning experience to test tank in empty scenes)
	[DefaultExecutionOrder(-10)]
	public sealed class LunyTankMovement : LunyScript
	{
		[Tooltip("The player number. Without a tank selection menu, Player 1 is left keyboard control, Player 2 is right keyboard")]
        public int m_PlayerNumber = 1;              // Used to identify which tank belongs to which player.  This is set by this tank's manager.
        [Tooltip("The speed in unity unit/second the tank move at")]
        public float m_Speed = 12f;                 // How fast the tank moves forward and back.
        [Tooltip("The speed in deg/s that tank will rotate at")]
        public float m_TurnSpeed = 180f;            // How fast the tank turns in degrees per second.
        [Tooltip("If set to true, the tank auto orient and move toward the pressed direction instead of rotating on left/right and move forward on up")]
        public bool m_IsDirectControl;
        public AudioSource m_MovementAudio;         // Reference to the audio source used to play engine sounds. NB: different to the shooting audio source.
        public AudioClip m_EngineIdling;            // Audio to play when the tank isn't moving.
        public AudioClip m_EngineDriving;           // Audio to play when the tank is moving.
		public float m_PitchRange = 0.2f;           // The amount by which the pitch of the engine noises can vary.
        [Tooltip("Is set to true this will be controlled by the computer and not a player")]
        public bool m_IsComputerControlled = false; // Is this tank player or computer controlled
        [HideInInspector]
        public LunyTankInputUser m_InputUser;            // The Input User component for that tanks. Contains the Input Actions.

        public Rigidbody Rigidbody => m_Rigidbody;

        public int ControlIndex { get; set; } = -1; //this define the index of the control 1 = left keyboard or pad, 2 = right keyboard, -1 = no control

        private string m_MovementAxisName;          // The name of the input axis for moving forward and back.
        private string m_TurnAxisName;              // The name of the input axis for turning.
        private Rigidbody m_Rigidbody;              // Reference used to move the tank.
        private float m_MovementInputValue;         // The current value of the movement input.
        private float m_TurnInputValue;             // The current value of the turn input.
        private float m_OriginalPitch;              // The pitch of the audio source at the start of the scene.
        private ParticleSystem[] m_particleSystems; // References to all the particles systems used by the Tanks

        private InputAction m_MoveAction;             // The InputAction used to move, retrieved from TankInputUser
        private InputAction m_TurnAction;             // The InputAction used to shot, retrieved from TankInputUser

        private Vector3 m_RequestedDirection;       // In Direct Control mode, store the direction the user *wants* to go toward

        protected override void OnBeforeScriptAwake()
        {
	        SetInt(nameof(m_PlayerNumber).Substring(2), m_PlayerNumber);
	        SetFloat(nameof(m_Speed).Substring(2), m_Speed);
	        SetFloat(nameof(m_TurnSpeed).Substring(2), m_TurnSpeed);
	        SetBool(nameof(m_IsDirectControl).Substring(2), m_IsDirectControl);
	        SetObject(nameof(m_MovementAudio).Substring(2), m_MovementAudio);
	        SetObject(nameof(m_EngineIdling).Substring(2), m_EngineIdling);
	        SetObject(nameof(m_EngineDriving).Substring(2), m_EngineDriving);
	        SetFloat(nameof(m_PitchRange).Substring(2), m_PitchRange);
	        SetBool(nameof(m_IsComputerControlled).Substring(2), m_IsComputerControlled);
	        SetObject(nameof(m_InputUser).Substring(2), m_InputUser);
	        SetObject(nameof(m_Rigidbody), m_Rigidbody);
        }
	}
}
