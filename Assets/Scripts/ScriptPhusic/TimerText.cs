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
    [SerializeField]
    private UpgradeSystem upgradeSystemScript;

    private bool isVisiblePanelUpgrade = false;
    private bool isBoss = false;

    [SerializeField]
    private GameObject spawnEnemy;
    [SerializeField]
    private GameObject spawnMeteorite;

    [SerializeField]
    private GameObject boss;
    [SerializeField]
    private GameObject bossShield;
    [SerializeField]
    private GameObject bossDodge;

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

        if (startingTimer > 7)
        {
            timerMin += 1;
            startingTimer = 0;
            isVisiblePanelUpgrade = true;
        };

        if (timerMin == 1 || timerMin == 2 || timerMin == 3 || timerMin == 4 || timerMin == 5)
        {
            if (isVisiblePanelUpgrade && upgradeSystemScript.upgradesList.Count > 0)
            {
                setIsVisiblePanelUpgrade.SetIsVisibleUpgradePlayer();
                isVisiblePanelUpgrade = false;
            }
        }

        if (timerMin == 6)
        {
            spawnEnemy.SetActive(false);
            spawnMeteorite.SetActive(false);
        }

        if (timerMin == 6 && startingTimer > 5 && !isBoss)
        {
            isBoss = true;
            boss.SetActive(true);
            bossDodge.SetActive(true);
            bossShield.SetActive(true);
        }

        theText.text = $"Time lived - {Mathf.Round(timerMin)} : {Mathf.Round(startingTimer)}";
    }
}
