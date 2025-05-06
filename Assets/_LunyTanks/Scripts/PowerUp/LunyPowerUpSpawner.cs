using CodeSmile.Luny;
using System.Collections;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyPowerUpSpawner : LunyScript
	{
		[Tooltip("Array that holds different power-up prefabs that can be spawned.")]
		public LunyPowerUp[] m_PowerUps;
		[Tooltip("Time in seconds that will wait this spawner to instantiate a new power up when collected the new one.")]
		public float m_RespawnCooldown = 20f;


		protected override void OnBeforeScriptAwake()
		{
		}

		// private void Start()
		// {
		// 	// Spawn a random power up when the game starts.
		// 	SpawnRandomPowerUp();
		// }
		//
		// private void SpawnRandomPowerUp()
		// {
		// 	// Ensure there are power ups available to spawn.
		// 	if (m_PowerUps.Length > 0)
		// 	{
		// 		// Instantiates a random power up from the power ups array
		// 		int randomNumber = Random.Range(0, m_PowerUps.Length);
		// 		Vector3 positionToSpawn = transform.position;
		// 		positionToSpawn.y = 1.09f;
		// 		LunyPowerUp m_SpawnedPowerup = Instantiate(m_PowerUps[randomNumber], positionToSpawn, Quaternion.identity);
		// 		m_SpawnedPowerup.SetSpawner(this);
		// 	}
		// }
		//
		// // Called when a power up is collected, starting a respawn timer.
		// public void CollectPowerUp()
		// {
		// 	StartCoroutine(RespawnPowerUp());
		// }
		//
		// private IEnumerator RespawnPowerUp()
		// {
		// 	// Wait for the cooldown time then spawns a power up.
		// 	yield return new WaitForSeconds(m_RespawnCooldown);
		// 	SpawnRandomPowerUp();
		// }


	}
}
