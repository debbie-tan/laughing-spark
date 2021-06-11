﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Text highscoreText;

    void Start()
    {
        if(PlayerPrefs.GetString("HIGHSCORENAME") != "")
        {
            highscoreText.text = "High Score Set by " + PlayerPrefs.GetString ("HIGHSCORENAME") + " " + PlayerPrefs.GetInt ("HIGHSCORE");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Button Pushed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
