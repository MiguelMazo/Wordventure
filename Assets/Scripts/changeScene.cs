using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKey("escape"))
            Application.Quit();
        Screen.SetResolution(1980, 1080, true, 60) ;
        Application.targetFrameRate = 60;
    }

    public void StartGameScene()
    {
        Timer.timer = 120f;
        ScoreAndWordCompletion.progress = " ";
        ScoreAndWordCompletion.complete = false;
        SceneManager.LoadScene("Level1");
    }
    public void StartLevel2()
    {
        if (ScoreAndWordCompletion.complete)
        {
            Timer.timer = 120f;
            ScoreAndWordCompletion.progress = " ";
            ScoreAndWordCompletion.complete = false;
            ScoreAndWordCompletion.chooseWord();
            ScoreAndWordCompletion.letterCount = 0;
            SceneManager.LoadScene("Level2");
        }
    }
    public void StartLevel3()
    {
        if (ScoreAndWordCompletion.complete)
        {
            Timer.timer = 120f;
            ScoreAndWordCompletion.progress = " ";
            ScoreAndWordCompletion.complete = false;
            ScoreAndWordCompletion.chooseWord();
            ScoreAndWordCompletion.letterCount = 0;
            SceneManager.LoadScene("Level3");
        }
    }
    public void StartLevel1()
    {
        if (ScoreAndWordCompletion.complete)
        {
            Timer.timer = 120f;
            ScoreAndWordCompletion.progress = " ";
            ScoreAndWordCompletion.complete = false;
            ScoreAndWordCompletion.chooseWord();
            ScoreAndWordCompletion.letterCount = 0;
            SceneManager.LoadScene("Level1");
        }
    }

    public void SetEnglish()
    {
        ScoreAndWordCompletion.language = 1;
    }

    public void SetSpanish()
    {
        ScoreAndWordCompletion.language = 2;
    }

    public void SetGerman()
    {
        ScoreAndWordCompletion.language = 3;
    }

    public void SetFrench()
    {
        ScoreAndWordCompletion.language = 4;
    }
}
