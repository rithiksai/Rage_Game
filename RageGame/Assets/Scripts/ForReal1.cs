using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForReal1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Moederskut()
    {
        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
    public void OnClick()
    {
        Debug.Log("CLick");

    }
}
