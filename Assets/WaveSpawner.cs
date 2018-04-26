using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {
	
		public Transform EnemyPrefab;

		public Transform EnemyPrefab2;

		public Transform EnemyPrefab3;

		public Transform EnemyPrefab4;


		public Transform spawnPoint;

		public float timeBetweenWaves = 7f;
		private float countdown = 2f;

		private int waveIndex = 0;

		void Update ()
		{
			if (countdown <= 0f)
					{
						StartCoroutine(SpawnWave());
						countdown = timeBetweenWaves;
					}

				countdown -= Time.deltaTime;

			}

		IEnumerator SpawnWave ()
		{
				waveIndex++;

				for (int i = 0; i < waveIndex; i++)
				{
					SpawnEnemy();
						yield return new WaitForSeconds(1f);
				}
			}

		void SpawnEnemy ()
		{
		
		var randomEnemy = Random.Range(0, 3);
			switch(randomEnemy) {
				case 0: Instantiate(EnemyPrefab, spawnPoint.position, spawnPoint.rotation); break;
				case 1: Instantiate(EnemyPrefab2, spawnPoint.position, spawnPoint.rotation); break;
				case 2: Instantiate(EnemyPrefab3, spawnPoint.position, spawnPoint.rotation); break;
				case 3: Instantiate (EnemyPrefab4, spawnPoint.position, spawnPoint.rotation); break;
			}
		}
}