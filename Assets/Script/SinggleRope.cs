using UnityEngine;
using UnityEditor;
[RequireComponent(typeof(CircleCollider2D),typeof(HingeJoint2D))]
public class SinggleRope : MonoBehaviour
{
    [HideInInspector]
    public static bool back;

	public void start(){
		if (Time.timeScale == 0) {
			Destroy (gameObject);
		}
	}

    public static bool isBack()
    {
        return back;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
  
}