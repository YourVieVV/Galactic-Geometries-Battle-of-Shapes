﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagerM : MonoBehaviour {

    public GameObject pause;

    public void PlayGame()
    {
        FindObjectOfType<PauseGame>().PauseGameFunction(false, pause);
    }
    
    public void ExitGame()
    {
        SceneManager.LoadScene(0);
        // Application.Quit();
    }
}
