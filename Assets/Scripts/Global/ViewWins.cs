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
        if (PlayerPrefs.GetString("Lang") == "ru")
        {
            textWins.text = $"ֲûידנûרוי: {winsCount}";
        }
        else
        {
            textWins.text = $"Victories: {winsCount}";
        }
    }
}
