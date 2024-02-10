using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private int score;
    private int wins;
    private int loses;
    private int isFirstStart;

    private float musicVolume;

    void Start()
    {
        score = PlayerPrefs.GetInt(StatisticsPlayer.score);
        wins = PlayerPrefs.GetInt(StatisticsPlayer.wins);
        loses = PlayerPrefs.GetInt(StatisticsPlayer.losses);
        musicVolume = PlayerPrefs.GetFloat("musicVolume");
        isFirstStart = PlayerPrefs.GetInt("FirstStartGame");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(StatisticsPlayer.score, score);
        PlayerPrefs.SetInt(StatisticsPlayer.wins, wins);
        PlayerPrefs.SetInt(StatisticsPlayer.losses, loses);
        PlayerPrefs.SetInt("FirstStartGame", isFirstStart);
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
    }
}
