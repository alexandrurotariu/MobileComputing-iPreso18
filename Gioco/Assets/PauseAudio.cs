using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    public bool musicOn = true; // this variable appears in the Inspector and controls the music

    void Start()
    {
        if (musicOn)
        {
            DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }
}
