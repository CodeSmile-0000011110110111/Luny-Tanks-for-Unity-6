using CodeSmile.Luny;
using System.Collections;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyPowerUpDetector : LunyScript
	{
        // Variable that indicates if the tank has a PowerUp right now
        public bool m_HasActivePowerUp = false;
        // References to the tank's components
        private LunyTankShooting m_TankShooting;
        private LunyTankMovement m_TankMovement;
        private LunyTankHealth m_TankHealth;
        private LunyPowerUpHUD m_PowerUpHUD;

        protected override void OnBeforeScriptAwake()
        {
        }

        // private void Awake()
        // {
        //     // Get references to the tank's movement, shooting, and health components
        //     m_TankShooting = GetComponent<LunyTankShooting>();
        //     m_TankMovement = GetComponent<LunyTankMovement>();
        //     m_TankHealth = GetComponent<LunyTankHealth>();
        //     m_PowerUpHUD = GetComponentInChildren<LunyPowerUpHUD>();
        // }
        //
        // // Applies a temporary speed boost to the tank
        // public void PowerUpSpeed(float speedBoost, float turnSpeedBoost, float duration)
        // {
        //     StartCoroutine(IncreaseSpeed(speedBoost, turnSpeedBoost, duration));
        // }
        //
        // // Coroutine to temporarily increase the tank's movement speed and turn speed
        // private IEnumerator IncreaseSpeed(float speedBoost, float TurnSpeedBoost, float duration)
        // {
        //     // Apply the speed boost
        //     m_HasActivePowerUp = true;
        //     m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.Speed, duration);
        //     m_TankMovement.m_Speed += speedBoost;
        //     m_TankMovement.m_TurnSpeed += TurnSpeedBoost;
        //     // Wait for the duration of the power up
        //     yield return new WaitForSeconds(duration);
        //     // Revert the speed boost
        //     m_TankMovement.m_Speed -= speedBoost;
        //     m_TankMovement.m_TurnSpeed -= TurnSpeedBoost;
        //     m_HasActivePowerUp = false;
        // }
        //
        // // Applies a temporary shooting rate boost to the tank
        // public void PowerUpShoootingRate(float cooldownReduction, float duration)
        // {
        //     StartCoroutine(IncreaseShootingRate(cooldownReduction, duration));
        // }
        //
        // // Coroutine to temporarily enhance the tank's shooting rate
        // private IEnumerator IncreaseShootingRate(float cooldownReduction, float duration)
        // {
        //     // Apply the shooting cooldown reduction if it is greater than zero
        //     if(cooldownReduction > 0)
        //     {
        //         m_HasActivePowerUp = true;
        //         m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.ShootingBonus, duration);
        //         m_TankShooting.m_ShotCooldown *= cooldownReduction;
        //         // Wait for the duration of the power up
        //         yield return new WaitForSeconds(duration);
        //         // Revert the shooting boost after the duration ends
        //         m_TankShooting.m_ShotCooldown /= cooldownReduction;
        //         m_HasActivePowerUp = false;
        //     }
        // }
        //
        // // Grants the tank a temporary shield if it does not already have one
        // public void PickUpShield(float shieldAmount, float duration)
        // {
        //     if (!m_TankHealth.HasShield)
        //         StartCoroutine(ActivateShield(shieldAmount, duration));
        // }
        //
        // // Grants the tank a temporary shield if it does not already have one
        // private IEnumerator ActivateShield(float shieldAmount, float duration)
        // {
        //     // Activate the shield
        //     m_HasActivePowerUp = true;
        //     m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.DamageReduction, duration);
        //     m_TankHealth.ToggleShield(shieldAmount);
        //     // Wait for the duration of the power up
        //     yield return new WaitForSeconds(duration);
        //     // Deactivate the shield
        //     m_TankHealth.ToggleShield(shieldAmount);
        //     m_HasActivePowerUp = false;
        // }
        //
        // // Increases the health of the tank
        // public void PowerUpHealing(float healAmount)
        // {
        //     m_TankHealth.IncreaseHealth(healAmount);
        //     m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.Healing, 1.0f);
        // }
        //
        // // Makes the tank invulnerable for an amount of time
        // public void PowerUpInvincibility(float duration)
        // {
        //     StartCoroutine(ActivateInvincibility(duration));
        // }
        //
        // private IEnumerator ActivateInvincibility(float duration)
        // {
        //     m_HasActivePowerUp = true;
        //     m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.Invincibility, duration);
        //     m_TankHealth.ToggleInvincibility();
        //     yield return new WaitForSeconds(duration);
        //     m_HasActivePowerUp = false;
        //     m_TankHealth.ToggleInvincibility();
        // }
        //
        // // Equips the tank with a special shell that increases damage
        // public void PowerUpSpecialShell(float damageMultiplier)
        // {
        //     m_HasActivePowerUp = true;
        //     m_PowerUpHUD.SetActivePowerUp(LunyPowerUp.PowerUpType.DamageMultiplier, 0f);
        //     m_TankShooting.EquipSpecialShell(damageMultiplier);
        // }
	}
}
