using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour
{
    private bool onGround;
    private Rigidbody rb;
    public float acc;

    private Vector2 spoint, epoint, offset;
    private Vector3 jumpVect;

    public bool isDraging;

    public Trajectory trajectory;

    Vector2 endPoint;
    Vector2 direction;
    Vector2 force;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //test jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0f, acc * rb.mass, 0f), ForceMode.Impulse);
        }

        if(Input.GetMouseButtonDown(0) && onGround)
        {
            spoint = Input.mousePosition;

            isDraging = true;
            OnDragStart();
            //Debug.Log(spoint);
        }
        if(Input.GetMouseButtonUp(0) && onGround)
        {
            epoint = Input.mousePosition;

            offset = spoint - epoint;

            jumpVect = new Vector3(offset.x, 100f * acc, offset.y);

            rb.AddForce(jumpVect * .1f, ForceMode.Impulse);

            isDraging = false;
            onGround = false;

            OnDragEnd();
        }

        if(isDraging)
        {
            OnDrag();
        }


    }

    void OnDragStart()
    {


        trajectory.show();
    }


    void OnDrag()
    {
        endPoint = Input.mousePosition;
        distance = Vector2.Distance(spoint, endPoint);
        direction = (spoint - endPoint).normalized;
        force = direction * distance * 0.008f ;

        //just for debug
        Debug.DrawLine(spoint, endPoint);


        trajectory.UpdateDots(transform.position, force);
    }

    void OnDragEnd()
    {


        trajectory.hide();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }
}

