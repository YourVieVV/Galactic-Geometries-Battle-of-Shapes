using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{

    public float startingTimer;
    [HideInInspector]
    public float timerMin = 0;

    private Text theText;
    private PauseGame thePauseMenu;
    private IsVisibleUpgradePanel setIsVisiblePanelUpgrade;

    private bool isVisiblePanelUpgrade = false;

    void Start()
    {
        theText = GetComponent<Text>();
        thePauseMenu = FindObjectOfType<PauseGame>();
        setIsVisiblePanelUpgrade = FindObjectOfType<IsVisibleUpgradePanel>();
    }

    void Update()
    {
        if (thePauseMenu.isPaused)
            return;

        startingTimer += Time.deltaTime;

        if (startingTimer > 3)
        {
            timerMin += 1;
            startingTimer = 0;
            isVisiblePanelUpgrade = true;
        };

        if (timerMin == 1 || timerMin == 2 || timerMin == 3 || timerMin == 4 || timerMin == 5 || timerMin == 6 || timerMin == 7 || timerMin == 8 || timerMin == 9)
        {
            if (isVisiblePanelUpgrade)
            {
                setIsVisiblePanelUpgrade.SetIsVisibleUpgradePlayer();
                isVisiblePanelUpgrade = false;
            }
        }

        theText.text = $"Time lived - {Mathf.Round(timerMin)} : {Mathf.Round(startingTimer)}";
    }
}
