using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyControler : MonoBehaviour {
	public float speed;
    private bool destroyed=false;
    public int koin;
<<<<<<< HEAD
	private TimeManager timer;
=======
>>>>>>> 33a98cd9b6cfedcfe048e97a0846845b16a42bc3
    void Update () {
		Vector2 position = transform.position;
		position = new Vector2 (transform.position.x + speed * Time.deltaTime, transform.position.y);
		transform.position = position;
		if (transform.position.x > 3.59f)
        {
            destroyed = true;
            Destroy(gameObject);
<<<<<<< HEAD
	
=======
>>>>>>> 33a98cd9b6cfedcfe048e97a0846845b16a42bc3
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
<<<<<<< HEAD
			TimeManager.addTime ();
=======
>>>>>>> 33a98cd9b6cfedcfe048e97a0846845b16a42bc3
        }
        
    }


}
