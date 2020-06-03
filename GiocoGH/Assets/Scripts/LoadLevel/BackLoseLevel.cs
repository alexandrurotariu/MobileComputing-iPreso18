using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLoseLevel : MonoBehaviour
{
    public int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void OnTriggerEnter()
    {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        
    }
}
