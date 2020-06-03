using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisattivaMusicaButton : MonoBehaviour
{
    public void disattvia()
    {
        DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

    public void riattiva()
    {
        DontDestroyAudio.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}