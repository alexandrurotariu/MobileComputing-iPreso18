using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSelectPlayer : MonoBehaviour
{
    public void loadPreLevel1()
    {
        SceneManager.LoadScene("PreLevel1");
    }

    public void loadPreLevel2()
    {
        SceneManager.LoadScene("PreLevel2");
    }

    public void loadPreLevel3()
    { 
        SceneManager.LoadScene("PreLevel3");
    }

    public void loadPreLevel4()
    {
        SceneManager.LoadScene("PreLevel4");
    }
}
