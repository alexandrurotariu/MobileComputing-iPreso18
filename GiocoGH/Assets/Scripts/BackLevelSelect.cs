using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackLevelSelect : MonoBehaviour
{
    public void backToLevels()
    {

        SceneManager.LoadScene("LevelSelect");
    }
}
