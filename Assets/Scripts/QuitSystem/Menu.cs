using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private int score;
    private int wins;
    private int loses;

    void Start()
    {
        score = PlayerPrefs.GetInt(StatisticsPlayer.score);
        wins = PlayerPrefs.GetInt(StatisticsPlayer.wins);
        loses = PlayerPrefs.GetInt(StatisticsPlayer.losses);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(StatisticsPlayer.score, score);
        PlayerPrefs.SetInt(StatisticsPlayer.wins, wins);
        PlayerPrefs.SetInt(StatisticsPlayer.losses, loses);
    }
}
