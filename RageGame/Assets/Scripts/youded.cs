using UnityEngine;
using UnityEngine.SceneManagement;

public class youded : MonoBehaviour
{



    
    // OnCollisionEnter2D is called when this collider2D/rigidbody2D has begun touching another rigidbody2D/collider2D (2D physics only)
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "dead")
            SceneManager.LoadScene("Map1");
    }
}