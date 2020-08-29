using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDown : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Button;

    // Start is called before the first frame update
    public void OpenPanel()
    {
        if (Button != null)
        {
            Button.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
