using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace Tanks.Complete
{
    //Ensure it run before the TankShooting component as TankShooting grabs the InputUser from this when there are no
    //GameManager set (used during learning experience to test tank in empty scenes)
    [DefaultExecutionOrder(-10)]
    public class TankMovement : MonoBehaviour
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
        public TankInputUser m_InputUser;            // The Input User component for that tanks. Contains the Input Actions.
        
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
        
        private void Awake ()
        {
            m_Rigidbody = GetComponent<Rigidbody> ();
            
            m_InputUser = GetComponent<TankInputUser>();
            if (m_InputUser == null)
                m_InputUser = gameObject.AddComponent<TankInputUser>();
        }


        private void OnEnable ()
        {
            // Computer controlled tank are kinematic
            m_Rigidbody.isKinematic = false;

            // Also reset the input values.
            m_MovementInputValue = 0f;
            m_TurnInputValue = 0f;

            // We grab all the Particle systems child of that Tank to be able to Stop/Play them on Deactivate/Activate
            // It is needed because we move the Tank when spawning it, and if the Particle System is playing while we do that
            // it "think" it move from (0,0,0) to the spawn point, creating a huge trail of smoke
            m_particleSystems = GetComponentsInChildren<ParticleSystem>();
            for (int i = 0; i < m_particleSystems.Length; ++i)
            {
                m_particleSystems[i].Play();
            }
        }


        private void OnDisable ()
        {
            // When the tank is turned off, set it to kinematic so it stops moving.
            m_Rigidbody.isKinematic = true;

            // Stop all particle system so it "reset" it's position to the actual one instead of thinking we moved when spawning
            for(int i = 0; i < m_particleSystems.Length; ++i)
            {
                m_particleSystems[i].Stop();
            }
        }


        private void Start ()
        {
            // If this is computer controlled...
            if (m_IsComputerControlled)
            {
                // but it doesn't have an AI component...
                var ai = GetComponent<TankAI>();
                if (ai == null)
                {
                    // we add it, to ensure this will control the tank.
                    // This is only useful when user test tank in empty scene, otherwise the TankManager ensure 
                    // computer controlled tank are setup properly
                    gameObject.AddComponent<TankAI>();
                }
            }

            // If no control index was set, this mean this is a scene without a GameManager and that tank was manually
            // added to an empty scene, so we used the manually set Player Number in the Inspector as the ControlIndex,
            // so Player 1 will be ControlIndex 1 -> KeyboardLeft and Player 2 -> KeyboardRight
            if (ControlIndex == -1 && !m_IsComputerControlled)
            {
                ControlIndex = m_PlayerNumber;
            }
            
            var mobileControl = FindAnyObjectByType<MobileUIControl>();
            
            // By default, ControlIndex 1 is matched to KeyboardLeft. But if there is a mobile UI control component in the scene
            // and it is active (so we either are on mobile or it was force activated to test by the user) then we instead 
            // match ControlIndex 1 to the virtual Gamepad on screen.
            if (mobileControl != null && ControlIndex == 1)
            {
                m_InputUser.SetNewInputUser(InputUser.PerformPairingWithDevice(mobileControl.Device));
                m_InputUser.ActivateScheme("Gamepad");
            }
            else
            {
                // otherwise if no mobile ui control is active, ControlIndex is KeyboardLeft scheme and ControlIndex 2 is KeyboardRight
                m_InputUser.ActivateScheme(ControlIndex == 1 ? "KeyboardLeft" : "KeyboardRight");
            }

            // The axes names are based on player number.
            m_MovementAxisName = "Vertical";
            m_TurnAxisName = "Horizontal";
            
            // Get the action input from the TankInputUser component which will have taken care of copying them and
            // binding them to the right device and control scheme
            m_MoveAction = m_InputUser.ActionAsset.FindAction(m_MovementAxisName);
            m_TurnAction = m_InputUser.ActionAsset.FindAction(m_TurnAxisName);
            
            // actions need to be enabled before they can react to input
            m_MoveAction.Enable();
            m_TurnAction.Enable();
            
            // Store the original pitch of the audio source.
            m_OriginalPitch = m_MovementAudio.pitch;
        }


        private void Update ()
        {
            // Computer controlled tank will be moved by the TankAI component, so only read input for player controlled tanks
            if (!m_IsComputerControlled)
            {
                m_MovementInputValue = m_MoveAction.ReadValue<float>();
                m_TurnInputValue = m_TurnAction.ReadValue<float>();
            }
            
            EngineAudio ();
        }


        private void EngineAudio ()
        {
            // If there is no input (the tank is stationary)...
            if (Mathf.Abs (m_MovementInputValue) < 0.1f && Mathf.Abs (m_TurnInputValue) < 0.1f)
            {
                // ... and if the audio source is currently playing the driving clip...
                if (m_MovementAudio.clip == m_EngineDriving)
                {
                    // ... change the clip to idling and play it.
                    m_MovementAudio.clip = m_EngineIdling;
                    m_MovementAudio.pitch = Random.Range (m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                    m_MovementAudio.Play ();
                }
            }
            else
            {
                // Otherwise if the tank is moving and if the idling clip is currently playing...
                if (m_MovementAudio.clip == m_EngineIdling)
                {
                    // ... change the clip to driving and play.
                    m_MovementAudio.clip = m_EngineDriving;
                    m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                    m_MovementAudio.Play();
                }
            }
        }


        private void FixedUpdate ()
        {
            // If this is using a gamepad or have direct control enabled, this used a different movement method : instead of
            // "up" behind moving forward for the tank, it instead takes the gamepad move direction as the desired forward for the tank
            // and will compute the speed and rotation needed to move the tank toward that direction.
            if (m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" ||  m_IsDirectControl)
            {
                var camForward = Camera.main.transform.forward;
                camForward.y = 0;
                camForward.Normalize();
                var camRight = Vector3.Cross(Vector3.up, camForward);
                
                //this creates a vector based on camera look (e.g. pressing up mean we want to go up in the direction of the
                //camera, not forward in the direction of the tank)
                m_RequestedDirection = (camForward * m_MovementInputValue + camRight * m_TurnInputValue);
            }
            
            // Adjust the rigidbodies position and orientation in FixedUpdate.
            Move ();
            Turn ();
        }


        private void Move ()
        {
            float speedInput = 0.0f;
            
            // In direct control mode, the speed will depend on how far from the desired direction we are
            if (m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" || m_IsDirectControl)
            {
                speedInput = m_RequestedDirection.magnitude;
                //if we are direct control, the speed of the move is based angle between current direction and the wanted
                //direction. If under 90, full speed, then speed reduced between 90 and 180
                speedInput *= 1.0f - Mathf.Clamp01((Vector3.Angle(m_RequestedDirection, transform.forward) - 90) / 90.0f);
            }
            else
            {
                // in normal "tank control" the speed value is how much we press "up/forward"
                speedInput = m_MovementInputValue;
            }
            
            // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
            Vector3 movement = transform.forward * speedInput * m_Speed * Time.deltaTime;

            // Apply this movement to the rigidbody's position.
            m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
        }


        private void Turn ()
        {
            Quaternion turnRotation;
            // If in direct control...
            if (m_InputUser.InputUser.controlScheme.Value.name == "Gamepad" || m_IsDirectControl)
            {
                // Compute the rotation needed to reach the desired direction
                float angleTowardTarget = Vector3.SignedAngle(m_RequestedDirection, transform.forward, transform.up);
                var rotatingAngle = Mathf.Sign(angleTowardTarget) * Mathf.Min(Mathf.Abs(angleTowardTarget), m_TurnSpeed * Time.deltaTime);
                turnRotation = Quaternion.AngleAxis(-rotatingAngle, Vector3.up);
            }
            else
            {
                float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

                // Make this into a rotation in the y axis.
                turnRotation = Quaternion.Euler (0f, turn, 0f);
            }

            // Apply this rotation to the rigidbody's rotation.
            m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnRotation);
        }
    }
}