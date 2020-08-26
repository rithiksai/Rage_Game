using UnityEngine;
using UnityEngine.SceneManagement;

public class youded : MonoBehaviour
{




    // OnCollisionEnter2D is called when this collider2D/rigidbody2D has begun touching another rigidbody2D/collider2D (2D physics only)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dead")
        {
            Debug.Log("Hai");

            SceneManager.LoadScene("newmap");
        }
    }
}