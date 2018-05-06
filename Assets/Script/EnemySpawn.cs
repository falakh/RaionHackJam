using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	public GameObject[] enemies;
	public Vector3 start, end;
	private float rarity;

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
		rarity = Random.Range (1, 100);
		
	}

	void SpawnEnemy(){
		if (rarity > 10) {
			GameObject anEnemy = (GameObject)Instantiate (enemies [Random.Range (1, enemies.Length)], new Vector3 (transform.position.x, Random.Range (start.y, end.y), 0), Quaternion.identity);
			Vector2 position = transform.position;
			position = new Vector2 (transform.position.x, transform.position.y);

		}
		else{
			GameObject anEnemy =(GameObject)Instantiate (enemies[0],new Vector3 (transform.position.x, Random.Range(start.y,end.y),0),Quaternion.identity);
			Vector2 position = transform.position;
			position = new Vector2 (transform.position.x, transform.position.y);
		
		}
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
