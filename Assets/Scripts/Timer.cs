using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public static float timer;
    public float maxTime = 300f;
    bool canCount = true;
    bool doOnce = false;
    void Start()
    {
        timer = maxTime;
    }

    void Update()
    {

        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce)
        {
            timerText.text = "0";
            canCount = false;
            doOnce = true;
            timer = 0.0f;
            GameOver();
        }
    }

    void GameOver()
    {
        if (timer <= 0.0)
        {
            ScoreAndWordCompletion.complete = false;
            ScoreAndWordCompletion.letterCount = 0;
            Cursor.visible = true;
            Screen.lockCursor = false;
            Timer.timer = 120f;
            ScoreAndWordCompletion.progress = " ";
            SceneManager.LoadScene("Main Menu");
        }
    }
}
