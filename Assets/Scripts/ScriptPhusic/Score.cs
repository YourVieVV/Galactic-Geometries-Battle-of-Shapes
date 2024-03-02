using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text textScore;
    private IsVisibleUpgradePanel setIsVisiblePanelUpgrade;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<Text>();
        setIsVisiblePanelUpgrade = FindObjectOfType<IsVisibleUpgradePanel>();
    }

    public void CounterScope(int count)
    {
        score += count;
        textScore.text = $"Scope: {score}";
        if (score % 100 == 0 && PlayerPrefs.GetString(PlayerStats.upgradeList) != "")
        {
            setIsVisiblePanelUpgrade.SetIsVisibleUpgradePlayer();
        }
    }
}
