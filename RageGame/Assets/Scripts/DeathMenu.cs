using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    public GameObject player;
    public Transform teleportTarget;
    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void EndMenu()
    {
        gameObject.SetActive(true);
        
    }
    public void Restart()
    {
     
    }
    public void ToMenu()
    {

    }

}

    
 
