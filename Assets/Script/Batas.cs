using UnityEngine;
using System.Collections;

public class Batas : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SinggleRope>() != null)
        {
            if (!SinggleRope.back) { 
                Destroy(collision.gameObject);
            }
        }
        {

        }
    }
}
