using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimerCoin : MonoBehaviour
{
    private float timer = 60.04f;
    private Text timerSeconds;
    public GameObject youWinPanel;
    public GameObject gameOverPanel;

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
        if (timer <= 0 && ScoreTextScript.coinAmount >= 18)
        {
            youWinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(timer <= 0 && ScoreTextScript.coinAmount < 18)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void BackMenu()
    {
        youWinPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenù");
    }
}

