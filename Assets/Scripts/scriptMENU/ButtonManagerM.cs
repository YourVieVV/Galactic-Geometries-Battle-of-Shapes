using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagerM : MonoBehaviour {

    public GameObject pause;

    public void PlayGame()
    {
        FindObjectOfType<PauseGame>().PauseAndSetActivePanelFunction(false, pause);
    }
    
    public void ExitGame()
    {
        PlayerPrefs.SetInt("IsQuit", 0);
        SceneManager.LoadScene(0);
        // Application.Quit();
    }

    public void ViewSettings()
    {
        FindObjectOfType<PauseGame>().PauseAndSetActivePanelFunction(true, pause);
    }

}
