using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicked : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Settings()
    {
        SceneManager.LoadScene("scensSettings");

    }
    public void ExitHelp()
    {
        SceneManager.LoadScene("scensmenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
