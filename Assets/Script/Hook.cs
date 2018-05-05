using UnityEngine;
using System.Collections;

public class Hook : MonoBehaviour
{
    private Transform awal;
    private bool follow;
    // Use this for initialization
    void Start()
    {
        awal = transform;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            follow = true;
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 current = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rotateHook(current);
        }
        if (Input.GetMouseButtonUp(0))
        {
            follow = false;
            rotateHook(transform.position);
        }
    }
    private void rotateHook(Vector3 target)
    {
        float derajat = Vector2.SignedAngle(transform.position, target);
        transform.eulerAngles = new Vector3(0, 0, derajat);
    
    }


}
