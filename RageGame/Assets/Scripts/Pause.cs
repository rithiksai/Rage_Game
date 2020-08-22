using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
 
        public GameObject PauseMenu, PauseButton;

        public void pause()
        {
            PauseMenu.SetActive(true);
            PauseButton.SetActive(false);
            Time.timeScale = 0f;
        }

        public void Resume()
        {
            PauseMenu.SetActive(false);
            PauseButton.SetActive(true);
            Time.timeScale = 1f;
        }
        public void Mainmenu()
        {
            SceneManager.LoadScene(0);
        }
    }
