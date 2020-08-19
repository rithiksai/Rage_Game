using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Touch drag;
    public float dragSpeed;
    // Start is called before the first frame update
    void Start()
    {
        dragSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            drag = Input.GetTouch(0);
            if(drag.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + drag.deltaPosition.x * dragSpeed,
                    transform.position.y,
                    transform.position.z + drag.deltaPosition.y * dragSpeed
                    );


            }
        }
    }
}
