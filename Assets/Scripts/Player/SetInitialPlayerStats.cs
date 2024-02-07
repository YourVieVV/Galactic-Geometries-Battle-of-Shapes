using UnityEngine;
using UnityEngine.UI;

public class SetInitialPlayerStats : MonoBehaviour
{
    [SerializeField] private GameObject firstShip;
    [SerializeField] private GameObject secondShip;
    [SerializeField] private PortalForPlayer leftPanelScript;
    [SerializeField] private PortalForPlayer rightPanelScript;
    [SerializeField] private PlayerHP playerHPScript;
    [SerializeField] private Slider sliderShieldHP;
    [SerializeField] private ShieldHP shieldScript;
    [SerializeField] private UpgradeSystem upgradeSystemScript;

    public void SetInitialValuesPalyer()
    {
        // Если IsQuit 1, тогда обнуляем данные

        if (PlayerPrefs.HasKey("isSetStartValuesPlayer") == false)
        {
            UpgradeList upgradeList = new();

            PlayerPrefs.SetFloat(PlayerStats.shootDelayGun, PlayerStats.initShootDelayGun);
            PlayerPrefs.SetFloat(PlayerStats.moveSpeed, PlayerStats.initMoveSpeed);
            PlayerPrefs.SetFloat(PlayerStats.hpPlayer, PlayerStats.initHpPlayer);
            //PlayerPrefs.SetFloat(PlayerStats.shootDelayLaser, PlayerStats.initShootDelayLaser);
            //PlayerPrefs.SetFloat(PlayerStats.shootDelayRocket, PlayerStats.initShootDelayRocket);

            PlayerPrefs.SetInt(PlayerStats.isGunTwo, PlayerStats.initIsGunTwo);
            PlayerPrefs.SetInt(PlayerStats.isGunTree, PlayerStats.initIsGunTree);
            PlayerPrefs.SetInt(PlayerStats.isRocket, PlayerStats.initIsRocket);
            PlayerPrefs.SetInt(PlayerStats.isPalyerRotate, PlayerStats.initIsPalyerRotate);
            PlayerPrefs.SetInt(PlayerStats.isShield, PlayerStats.initIsShield);
            PlayerPrefs.SetInt(PlayerStats.isOpenPortal, PlayerStats.initIsOpenPortal);
            PlayerPrefs.SetInt(PlayerStats.isFirstShipFlot, PlayerStats.initIsFirstShipFlot);
            PlayerPrefs.SetInt(PlayerStats.isSecondShipFlot, PlayerStats.initIsSecondShipFlot);


            upgradeSystemScript.SetUpgradeList(upgradeList._Upgrades);
            //PlayerPrefs.SetInt("IsQuit", 0);

            if (PlayerPrefs.HasKey(StatisticsPlayer.score) == false)
            {
                PlayerPrefs.SetInt(StatisticsPlayer.losses, StatisticsPlayer.initLosses);
                PlayerPrefs.SetInt(StatisticsPlayer.wins, StatisticsPlayer.initWins);
                PlayerPrefs.SetInt(StatisticsPlayer.score, StatisticsPlayer.initScore);
            }

            PlayerPrefs.SetInt("isSetStartValuesPlayer", 1);
        }
        else
        {
            // Сюда пишу все что не входит в скрипт игрока
            // но и улучшает его
            if (PlayerPrefs.GetInt(PlayerStats.isFirstShipFlot) != PlayerStats.initIsFirstShipFlot)
            {
                firstShip.SetActive(true);
            }
            if (PlayerPrefs.GetInt(PlayerStats.isSecondShipFlot) != PlayerStats.initIsSecondShipFlot)
            {
                secondShip.SetActive(true);
            }
            if (PlayerPrefs.GetInt(PlayerStats.isOpenPortal) != PlayerStats.initIsOpenPortal)
            {
                leftPanelScript.isOpenPortal = true;
                rightPanelScript.isOpenPortal = true;
            }
            if (PlayerPrefs.GetInt(PlayerStats.isShield) != PlayerStats.initIsShield)
            {
                sliderShieldHP.gameObject.SetActive(true);
                shieldScript.ReactivateShield();
            }
            if (PlayerPrefs.GetFloat(PlayerStats.hpPlayer) != PlayerStats.initHpPlayer)
            {
                playerHPScript.UpgradeAddHP(PlayerPrefs.GetFloat(PlayerStats.hpPlayer) - PlayerStats.initHpPlayer);
            }
        }
    }

    private void Start()
    {
        SetInitialValuesPalyer();
    }
}
