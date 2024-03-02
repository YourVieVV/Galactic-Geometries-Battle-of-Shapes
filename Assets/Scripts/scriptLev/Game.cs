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
    [SerializeField]
    private EnemyHP enemyHPScript;
    [SerializeField]
    private GameObject boss;

    private void Start()
    {
        timer = FindObjectOfType<TimerText>();
        hp = FindObjectOfType<PlayerHP>();
    }

    // Update is called once per frame
    void Update () {
        #region CheckWin
        if (!boss && enemyHPScript.isBossDead)
        {
            PlayerPrefs.SetInt(StatisticsPlayer.wins, PlayerPrefs.GetInt(StatisticsPlayer.wins) + 1);
            if (PlayerPrefs.GetInt(StatisticsPlayer.score) < currentScore)
                PlayerPrefs.SetInt(StatisticsPlayer.score, currentScore);
            SceneManager.LoadScene(4);
        }
        #endregion

        #region CheckLose
        if (hp.currentHealth <= 0)
        {
            Debug.Log("lose");
            currentScore = scoreScript.score;

            PlayerPrefs.SetInt(StatisticsPlayer.losses, PlayerPrefs.GetInt(StatisticsPlayer.losses) + 1);
            if (PlayerPrefs.GetInt(StatisticsPlayer.score) < currentScore)
                PlayerPrefs.SetInt(StatisticsPlayer.score, currentScore);

            SceneManager.LoadScene(1);
        }
        #endregion
    }
}
