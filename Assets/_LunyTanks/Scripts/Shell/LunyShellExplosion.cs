using CodeSmile.Luny;
using CodeSmile.Luny.Api;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
    public sealed class LunyShellExplosion : LunyScript
    {
        public LayerMask m_TankMask;                        // Used to filter what the explosion affects, this should be set to "Players".
        public ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
        public AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.

        protected override void OnBeforeScriptAwake()
        {
            SetUserData(nameof(m_TankMask).Substring(2),  new LunyLayerMask(m_TankMask));
            SetUserData(nameof(m_ExplosionParticles).Substring(2),  new LunyParticleSystem(m_ExplosionParticles));
            SetUserData(nameof(m_ExplosionAudio).Substring(2), new LunyAudioSource(m_ExplosionAudio));
        }
    }
}
