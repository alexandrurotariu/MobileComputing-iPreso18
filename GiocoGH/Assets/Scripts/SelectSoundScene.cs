using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSoundScene : MonoBehaviour
{
    public void goToSound()
    {
        SceneManager.LoadScene("Sound");
    }
}
