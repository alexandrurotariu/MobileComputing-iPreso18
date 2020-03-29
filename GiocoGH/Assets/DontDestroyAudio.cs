using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroyAudio : MonoBehaviour
{

    public static DontDestroyAudio instance = null;

    public static DontDestroyAudio Instance
    {
        get { return instance; }
    }


     void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
   
}
