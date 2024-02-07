using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewWins : MonoBehaviour
{
    private Text textWins;
    private int winsCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        textWins = GetComponent<Text>();
        winsCount = PlayerPrefs.GetInt(StatisticsPlayer.wins);
        textWins.text = $"Victories: {winsCount}";
    }
}
