using UnityEngine;

namespace Tanks.Complete
{
    public class PowerUpFX : MonoBehaviour
    {
        private AudioSource m_PowerUpAudioSource;       // Reference to the AudioSource component
        private float lifeTime = 3f;                    // Time in seconds that this GameObject will be in scene before being destroyed

        private void Start()
        {
            m_PowerUpAudioSource = GetComponent<AudioSource>();
            m_PowerUpAudioSource.PlayDelayed(0);
        }

        private void Update()
        {
            // Reduces its lifetime to know when to destroy this effect
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0.0f)
                Destroy(gameObject);
        }

    }
}
