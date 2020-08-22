using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButton;

    public void Pause()
    {
        Pausemenu.SetActive (true);
        PauseButton.SetActive (false);
        Time.timeScale = 0f;
    }

    public void Resume ()
    {
        Pausemenu.SetActive (false);
        PauseButton.SetActive (true);
        Time.timeScale = 1f;
    }
    public void Mainmenu ()
    {
        SceneManager.LoadScene (0);
    }
}
