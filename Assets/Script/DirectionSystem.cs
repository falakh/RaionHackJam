using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSystem : MonoBehaviour {
   private Vector2 startPosition,force,destiny;
    public GameObject bullet;
    public GameObject current;
    private Quaternion rotate;
    private Rigidbody2D rb;

    private void OnEnable()
    {
        rotate = Quaternion.identity;
        rb = current.GetComponent<Rigidbody2D>();
    }

    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
       
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 end = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (startPosition.y > end.y)
            {
                destiny = setDestiny(end);
                shoot();
            }
        }
	}

    private Vector2 setDestiny(Vector2 target)
    {
        return (target - startPosition)*-1;        
    }

    private void shoot()
    {
        if (!HeadRope.isExist())
        {
            GameObject temp = Instantiate(bullet, startPosition, Quaternion.identity);
            temp.AddComponent<HeadRope>();
            temp.AddComponent<SinggleRope>();
            temp.GetComponent<HeadRope>().setDestiny(destiny, transform.position);
            temp.GetComponent<HeadRope>().speed = 10;
        }
        
    }
 

}