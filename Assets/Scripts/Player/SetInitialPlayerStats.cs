using UnityEngine;

public class SetInitialPlayerStats : MonoBehaviour
{
    [SerializeField] private GameObject firstShip;
    [SerializeField] private GameObject secondShip;
    [SerializeField] private PortalForPlayer leftPanelScript;
    [SerializeField] private PortalForPlayer rightPanelScript;
    [SerializeField] private PlayerHP playerHPScript;
    public void SetInitialValuesPalyer()
    {
        if (PlayerPrefs.HasKey("isSetStartValuesPlayer") == false)
        {
            PlayerPrefs.SetFloat(PlayerStats.shootDelayGun, PlayerStats.initShootDelayGun);
            PlayerPrefs.SetFloat(PlayerStats.moveSpeed, PlayerStats.initMoveSpeed);
            PlayerPrefs.SetFloat(PlayerStats.hpPlayer, PlayerStats.initHpPlayer);
            //PlayerPrefs.SetFloat(PlayerStats.shootDelayLaser, PlayerStats.initShootDelayLaser);
            PlayerPrefs.SetFloat(PlayerStats.shootDelayRocket, PlayerStats.initShootDelayRocket);

            PlayerPrefs.SetInt(PlayerStats.isGunTwo, PlayerStats.initIsGunTwo);
            PlayerPrefs.SetInt(PlayerStats.isGunTree, PlayerStats.initIsGunTree);
            PlayerPrefs.SetInt(PlayerStats.isRocket, PlayerStats.initIsRocket);
            PlayerPrefs.SetInt(PlayerStats.isPalyerRotate, PlayerStats.initIsPalyerRotate);
            PlayerPrefs.SetInt(PlayerStats.isShild, PlayerStats.initIsShild);
            PlayerPrefs.SetInt(PlayerStats.isOpenPortal, PlayerStats.initIsOpenPortal);
            PlayerPrefs.SetInt(PlayerStats.isFirstShipFlot, PlayerStats.initIsFirstShipFlot);
            PlayerPrefs.SetInt(PlayerStats.isSecondShipFlot, PlayerStats.initIsSecondShipFlot);

            PlayerPrefs.SetInt("isSetStartValuesPlayer", 1);
        }
        else
        {
            // —юда пишу все что не входит в скрипт игрока
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
