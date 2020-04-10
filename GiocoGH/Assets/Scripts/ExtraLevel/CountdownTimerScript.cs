using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimerScript : MonoBehaviour
{
    private float timer = 4f;
    public Text timerSeconds;
    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f1");
        if (timer <= 0)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
