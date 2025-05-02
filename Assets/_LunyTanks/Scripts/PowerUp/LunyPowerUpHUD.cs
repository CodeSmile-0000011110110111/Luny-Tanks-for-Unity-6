using CodeSmile.Luny;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyPowerUpHUD : LunyScript
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
        public void SetActivePowerUp(LunyPowerUp.PowerUpType powerUpType, float duration)
        {
            switch (powerUpType)
            {
                case LunyPowerUp.PowerUpType.DamageReduction:
                    m_DamageReductionHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_DamageReductionHUD;
                    break;
                case LunyPowerUp.PowerUpType.ShootingBonus:
                    m_EnhancedShootingHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedShootingHUD;
                    break;
                case LunyPowerUp.PowerUpType.Speed:
                    m_EnhancedSpeedHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedSpeedHUD;
                    break;
                case LunyPowerUp.PowerUpType.DamageMultiplier:
                    m_EnhancedShellHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_EnhancedShellHUD;
                    break;
                case LunyPowerUp.PowerUpType.Healing:
                    m_HealingHUD.SetActive(true);
                    m_ActivePowerUpHUD = m_HealingHUD;
                    break;
                case LunyPowerUp.PowerUpType.Invincibility:
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


		// Awake cannot be overridden, use OnAwake instead. The script has not been loaded at this point!
		protected override void OnAwake() {}

		// Script was run and returned a LuaTable. Script's Awake() function has not been called yet.
		// You may want to get/set initial script variables before script's Awake():
		protected override void OnBeforeScriptAwake()
		{
			// Variables are set to the script table (commonly named 'script'): 'print(script.ImportantMessage)'
			SetString("ImportantMessage", "Testing One-Two-Three ..");

			// If you need the value of 'script.OhWowThatsCoolBool' assigned by the Lua script:
			var datBool = GetBool("OhWowThatsCoolBool");
		}
	}
}
