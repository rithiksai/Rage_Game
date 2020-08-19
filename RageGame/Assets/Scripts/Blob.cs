using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour
{
    private Rigidbody rb;
    public float acc;

    private Vector2 spoint, epoint, offset;
    private Vector3 jumpVect;

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

        if(Input.GetMouseButtonDown(0))
        {
            spoint = Input.mousePosition;
            //Debug.Log(spoint);
        }
        if(Input.GetMouseButtonUp(0))
        {
            epoint = Input.mousePosition;

            offset = spoint - epoint;

            jumpVect = new Vector3(offset.x, 100f * acc, offset.y);

            rb.AddForce(jumpVect * .1f, ForceMode.Impulse);
        }


    }
}
