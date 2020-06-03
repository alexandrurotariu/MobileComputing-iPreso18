using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int n;

    public void ScegliUomo()
    {
        PlayerPrefs.SetInt("CharacterSelected", 1);
        SceneManager.LoadScene("Level" + n.ToString());
    }

    public void ScegliDonna()
    {
        PlayerPrefs.SetInt("CharacterSelected", 2);
        SceneManager.LoadScene("Level" + n.ToString());
    }
}
