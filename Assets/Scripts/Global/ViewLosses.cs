using UnityEngine;
using UnityEngine.UI;

public class ViewLosses : MonoBehaviour
{
    private Text textLosses;
    private int lossesCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        textLosses = GetComponent<Text>();
        lossesCount = PlayerPrefs.GetInt(StatisticsPlayer.losses);
        if (PlayerPrefs.GetString("Lang") == "ru")
        {
            textLosses.text = $"Неудачных попыток: {lossesCount}";
        }
        else
        {
            textLosses.text = $"Unsuccessful attempts: {lossesCount}";
        }
    }
}
