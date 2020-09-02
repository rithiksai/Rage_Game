using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForReal1 : MonoBehaviour
{
    // Start is called before the first frame update

    SavePlayerPos playerPosData;


    private void Start()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();

    }


    public void Moederskut()
    {
        playerPosData.PlayerPosSave();

        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame

 
}
