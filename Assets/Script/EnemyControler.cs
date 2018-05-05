using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour {
	public float speed;
	//public GameObject pointSpawn;


	// Use this for initialization
	void Start () {
		speed = 3f;
	}

	// Update is called once per frame
	void Update () {
		//transform.position = pointSpawn.transform.position;

		Vector2 position = transform.position;

		position = new Vector2 (transform.position.x + speed * Time.deltaTime, transform.position.y);

		transform.position = position;
		if (transform.position.x > 3.59f)
			Destroy (gameObject);
	}
}
