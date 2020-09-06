using UnityEngine;
using UnityEngine.SceneManagement;

public class youded : MonoBehaviour
{
    public GameObject player;
    public GameObject teleportTarget;
    public bool OnDead = false;
    public DeathMenu deathMenu;
  


    void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.CompareTag("dead"))
            {
                OnDead = true;
            }
        if (OnDead == true)
        {
            deathMenu.EndMenu();
        }
 
    }
    public void Restart()
    {
        player.transform.position = teleportTarget.transform.position;
        OnDead = false;
        deathMenu.Start();

    }
    public void mainmenu()
    {
        SceneManager.LoadScene("menu");
    }
}