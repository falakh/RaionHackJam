using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyControler : MonoBehaviour {
	public float speed;
    private bool destroyed=false;
    public int koin;
    void Update () {
		Vector2 position = transform.position;
		position = new Vector2 (transform.position.x + speed * Time.deltaTime, transform.position.y);
		transform.position = position;
		if (transform.position.x > 3.59f)
        {
            destroyed = true;
            Destroy(gameObject);
        }
			
	}
    public void stop()
    {
        speed = 0;
    }
    private void OnDestroy()
    {
        if (!destroyed)
        {
            PlayerData.addCoin(koin);
			TimeManager.addTime ();
        }
        
    }


}
