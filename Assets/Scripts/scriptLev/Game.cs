using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    public GameObject pause;
    public Score scoreScript;
    private TimerText timer;
    private PlayerHP hp;
    private int currentScore;
    private bool isWin = false;
    private bool isLosse = false;

    private void Start()
    {
        timer = FindObjectOfType<TimerText>();
        hp = FindObjectOfType<PlayerHP>();
    }

    // Update is called once per frame
    void Update () {
        #region CheckWin
/*        if (!isWin)
        {
            *//*            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
                        {
                            LevelManager.countUnlockedLevel++;
                        }*//*
            //Debug.Log("win");
            //SceneManager.LoadScene(12);

            PlayerPrefs.SetInt(StatisticsPlayer.wins, PlayerPrefs.GetInt(StatisticsPlayer.wins) + 1);
            if (PlayerPrefs.GetInt(StatisticsPlayer.score) < currentScore)
                PlayerPrefs.SetInt(StatisticsPlayer.score, currentScore);

            isWin = true;
        }*/
        #endregion

        #region CheckLose
        if(hp.currentHealth <= 0 && !isLosse)
        {
            Debug.Log("lose");
            currentScore = scoreScript.score;

            PlayerPrefs.SetInt(StatisticsPlayer.losses, PlayerPrefs.GetInt(StatisticsPlayer.losses) + 1);
            if (PlayerPrefs.GetInt(StatisticsPlayer.score) < currentScore)
                PlayerPrefs.SetInt(StatisticsPlayer.score, currentScore);
            
            StartCoroutine(WaitAndThenDoSomething(1));
            isLosse = true;
        }
        #endregion
    }

    private IEnumerator WaitAndThenDoSomething(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<PauseGame>().PauseAndSetActivePanelFunction(true, pause);
    }

}
