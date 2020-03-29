using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectHelp : MonoBehaviour
{
    public void goToSound()
    {
        SceneManager.LoadScene("Help");
    }
}
