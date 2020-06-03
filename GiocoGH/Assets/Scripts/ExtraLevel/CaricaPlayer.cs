using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaricaPlayer : MonoBehaviour
{
    public GameObject uomo;
    public GameObject donna;
    int index;

    void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");
        if (index == 1)
        {
            uomo.SetActive(true);
        }
        else
            donna.SetActive(true);
    }
}
