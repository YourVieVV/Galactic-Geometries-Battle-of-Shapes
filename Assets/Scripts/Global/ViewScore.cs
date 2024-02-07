using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewScore : MonoBehaviour
{
    private Text textScore;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<Text>();
        score = PlayerPrefs.GetInt(StatisticsPlayer.score);
        textScore.text = $"Best score: {score}";
    }
}
