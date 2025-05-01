using UnityEngine;

namespace Tanks.Complete
{
    public class PowerUpHUD : MonoBehaviour
    {
        [SerializeField] private GameObject m_DamageReductionHUD;
        [SerializeField] private GameObject m_EnhancedShootingHUD;
        [SerializeField] private GameObject m_EnhancedSpeedHUD;
        [SerializeField] private GameObject m_EnhancedShellHUD;
        [SerializeField] private GameObject m_HealingHUD;
        [SerializeField] private GameObject m_TemporaryInvencibilityHUD;

        private GameObject m_ActivePowerUpHUD;
        private float m_DisplayTime;
        private bool m_HasActivePowerUp = false;

        private void Update()
        {
            // Checks that there is an active power up
            if (m_HasActivePowerUp)
            {
                // Rotates the PowerUpHUD
                transform.rotation = Quaternion.Euler(0, 100f * Time.time, 0);
                // Checks that the power up is not time based (just EnhancedShell for now)
                if(m_ActivePowerUpHUD != m_EnhancedShellHUD)
                {
                    // If the display time hasn't run out, the time that has passed gets updated
                    if (m_DisplayTime > 0f)
                        m_DisplayTime -= Time.deltaTime;

                    // If there is no display time left, this power up HUD gets disabled
                    else
                        DisableActiveHUD();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="powerUpType">Type of the power up to activate.</param>
        /// <param name="duration"> Time of displaying the power up HUD. This should coincide with the duration time of the power up.</param>
        public void SetActivePowerUp(PowerUp.PowerUpType powerUpType, float duration)
        {
            switch (powerUpType)
            {
                case PowerUp.PowerUpType.DamageReduction:
                    m_DamageReductionHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_DamageReductionHUD;
                    break;
                case PowerUp.PowerUpType.ShootingBonus:
                    m_EnhancedShootingHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedShootingHUD;
                    break;
                case PowerUp.PowerUpType.Speed:
                    m_EnhancedSpeedHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedSpeedHUD;
                    break;
                case PowerUp.PowerUpType.DamageMultiplier:
                    m_EnhancedShellHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedShellHUD;
                    break;
                case PowerUp.PowerUpType.Healing:
                    m_HealingHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_HealingHUD;
                    break;
                case PowerUp.PowerUpType.Invincibility:
                    m_TemporaryInvencibilityHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_TemporaryInvencibilityHUD;
                    break;
            }
            m_DisplayTime = duration;
            m_HasActivePowerUp = true;
        }

        /// <summary>
        /// Disables the Active Power Up HUD of the Tank.
        /// </summary>
        public void DisableActiveHUD()
        {
            m_ActivePowerUpHUD.SetActive(false);
            m_ActivePowerUpHUD = null;
            m_HasActivePowerUp = false;
            m_DisplayTime = 0f;
        }
    }
}