﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudioExit : MonoBehaviour
{
    void Start()
    {
        DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }


    public void riattivaMenu()
    {
        DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
