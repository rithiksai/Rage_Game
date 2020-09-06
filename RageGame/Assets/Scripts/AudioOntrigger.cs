using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOntrigger : MonoBehaviour
{
    public AudioClip VoiceOverClip;
    public AudioSource VoiceOverThing;
    bool soundHasPlayed = false;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (!soundHasPlayed)
        {
            GetComponent<AudioSource>().PlayOneShot(VoiceOverClip);

            VoiceOverThing.Play(); soundHasPlayed = true;

        




            if (!(soundHasPlayed = true)) {


                Debug.Log("Klaar");

            }
        }


        }
    }
     

    // Update is called once per frame


