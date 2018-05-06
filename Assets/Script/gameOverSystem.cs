using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverSystem : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public static void destroyEnemy ()
	{
		EnemyControler[] enemy = GameObject.FindObjectsOfType<EnemyControler> ();
		for (int i = 0; i < enemy.Length; i++) {
			Destroy (enemy [i].gameObject);
		}
	}
}
