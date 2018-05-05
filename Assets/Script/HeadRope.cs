using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRope : MonoBehaviour {
    private Vector2 destiny;
    private bool canMove,back,completed=true;
    public int speed;
    private Vector2 startPos;
    public float distance;
    public GameObject nodePrefab;
    public GameObject hooker;
    private GameObject lastNode;
    private static bool exist;
    private void Start()
    {
        //hooker = GameObject.FindGameObjectWithTag("Hooker");
        lastNode = transform.gameObject;
        lastNode.AddComponent<SinggleRope>();
    }
    // Update is called once per frame
    void Update () {
        if (canMove)
        {
            if((Vector2) transform.position != destiny && !back)
            {
               moveTo(destiny);
                if (Vector2.Distance(hooker.transform.position, lastNode.transform.position)
                    >distance)
                {
                    createNode();
                }
            }
            else
            {
                back = true;
                if (Input.GetMouseButton(0))
                {
                    moveTo(startPos);
                }
                if (SinggleRope.back)
                {
                    SinggleRope.back = false;
                    
                }
                if (completed)
                {
                    addSinggeleRope();
                    completed = false;
                }
             lastNode.GetComponent<HingeJoint2D>().connectedBody = hooker.GetComponent<Rigidbody2D>();


            }
            
        }
       
	}

    void addSinggeleRope()
    {
        Transform[] temp = GetComponentsInChildren<Transform>();
        for(int i=0; i < temp.Length; i++)
        {
            if(temp[i].GetComponent<SinggleRope>()==null)
            temp[i].gameObject.AddComponent<SinggleRope>();
        }
    }

    void createNode()
    {
        Vector2 pos = hooker.transform.position - lastNode.transform.position;
        pos.Normalize();
        pos *= distance;
        pos += (Vector2) lastNode.transform.position;
        GameObject anak = Instantiate(nodePrefab, pos, Quaternion.identity);
        lastNode.GetComponent<HingeJoint2D>().connectedBody = anak.GetComponent<Rigidbody2D>();
        anak.transform.SetParent(transform);
        lastNode = anak;


    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Batas>()!=null)
        {
            Destroy(collision.gameObject);
        }
    }

    private void moveTo(Vector2 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    public void setDestiny(Vector2 tujuan,Vector2 start)
    {

        this.destiny = tujuan;
        this.startPos = start;
        canMove = true;
        back = false;
    }
    private void OnDestroy()
    {
        exist = false;
    }
    private void OnBecameInvisible()
    {
        moveTo(startPos);   
    }
    public static bool isExist()
    {
        return exist;
    }
}
