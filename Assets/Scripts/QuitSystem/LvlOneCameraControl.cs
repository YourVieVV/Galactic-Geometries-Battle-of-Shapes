using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlOneCameraControl : MonoBehaviour
{
    private int scope;
    private int wins;
    private int loses;

    void Start()
    {
        PlayerPrefs.SetInt("IsQuit", 1);
        scope = PlayerPrefs.GetInt(StatisticsPlayer.score);
        wins = PlayerPrefs.GetInt(StatisticsPlayer.wins);
        loses = PlayerPrefs.GetInt(StatisticsPlayer.losses);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(StatisticsPlayer.score, scope);
        PlayerPrefs.SetInt(StatisticsPlayer.wins, wins);
        PlayerPrefs.SetInt(StatisticsPlayer.losses, loses);
    }
}
