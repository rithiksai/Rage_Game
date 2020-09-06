using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public youded DeathChechpoint;
    // Start is called before the first frame update
    void Start()
    {
        DeathChechpoint = FindObjectOfType<youded>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            DeathChechpoint.teleportTarget = gameObject;
        }
    }
}
