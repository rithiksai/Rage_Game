using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour
{
    private Rigidbody rb;
    public float acc;

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
    }
}
