using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{

    public AudioClip[] clips;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;

    }
    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];

    }
    // Update is called once per frame
    void Update()
    {
     if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }   
    }
}
