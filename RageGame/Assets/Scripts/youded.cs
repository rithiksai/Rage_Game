using UnityEngine;
using UnityEngine.SceneManagement;

public class youded : MonoBehaviour
{

    public Transform teleportTarget;

    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;

    }
}
