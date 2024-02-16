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
    private NewEnemySpawner spawnEnemy;
    private SpawnMeteor spawnMeteorite;

    [SerializeField]
    private UpgradeSystem upgradeSystemScript;

    private bool isVisiblePanelUpgrade = false;
    private bool isBoss = false;

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
        spawnEnemy = FindObjectOfType<NewEnemySpawner>();
        spawnMeteorite = FindObjectOfType<SpawnMeteor>();
    }

    void Update()
    {
        if (thePauseMenu.isPaused)
            return;

        startingTimer += Time.deltaTime;

        if (startingTimer > 59)
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
                switch (timerMin){
                    case 1:
                        PlayerPrefs.SetFloat(EmenyStats.hpRectangle, PlayerPrefs.GetFloat(EmenyStats.hpRectangle) + 100f);
                        break;
                    case 2:
                        PlayerPrefs.SetFloat(EmenyStats.hpIsometric, PlayerPrefs.GetFloat(EmenyStats.hpIsometric) + 100f);
                        break;
                    case 3:
                        PlayerPrefs.SetFloat(EmenyStats.hpOval, PlayerPrefs.GetFloat(EmenyStats.hpOval) + 100f);
                        break;
                    case 4:
                        PlayerPrefs.SetFloat(EmenyStats.hpCapsule, PlayerPrefs.GetFloat(EmenyStats.hpCapsule) + 100f);
                        break;
                    case 5:
                        PlayerPrefs.SetFloat(EmenyStats.hpCircle, PlayerPrefs.GetFloat(EmenyStats.hpCircle) + 100f);
                        break;
                }

            }
        }

        if (timerMin == 6)
        {
            if (spawnEnemy != null)
            spawnEnemy.gameObject.SetActive(false);
            if (spawnMeteorite != null)
            spawnMeteorite.gameObject.SetActive(false);
        }

        if (timerMin == 6 && startingTimer > 5 && !isBoss)
        {
            isBoss = true;
            boss.SetActive(true);
            bossDodge.SetActive(true);
            bossShield.SetActive(true);
            PlayerPrefs.SetFloat(EmenyStats.hpHexagon, PlayerPrefs.GetFloat(EmenyStats.hpHexagon) + 100f);
        }

        theText.text = $"Time lived - {Mathf.Round(timerMin)} : {Mathf.Round(startingTimer)}";
    }
}
