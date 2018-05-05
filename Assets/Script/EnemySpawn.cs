using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] enemies;

	//public float speed;
	//public GameObject pointSpawn;
	//private GameObject[] anEnemy;
	public float maxSpawnRateInSecond = 0.5f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRateInSecond);

		InvokeRepeating ("IncreaseSpawnRate", 30f, 60f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnEnemy(){
		GameObject anEnemy =(GameObject)Instantiate (enemies[Random.Range(0,enemies.Length)],new Vector3 (transform.position.x, Random.Range(-1.7f,1.7f),0),Quaternion.identity);
		Vector2 position = transform.position;
		position = new Vector2 (transform.position.x, transform.position.y);
		ScheduleNextEnemySpawn ();
	}

	void ScheduleNextEnemySpawn(){
		float spawnInNSeconds;

		if (maxSpawnRateInSecond > 0.2f) {
			spawnInNSeconds = Random.Range (0.2f, maxSpawnRateInSecond);
		} else
			spawnInNSeconds = 0.2f;
		Invoke ("SpawnEnemy", spawnInNSeconds);
	}

	void IncreaseSpawnRate(){
		if (maxSpawnRateInSecond > 0.2f)
			maxSpawnRateInSecond++;
		if (maxSpawnRateInSecond == 5f)
			CancelInvoke ("IncreaseSpawnRate");
	}
}
