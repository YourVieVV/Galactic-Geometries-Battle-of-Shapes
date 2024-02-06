using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesForPlayer : MonoBehaviour
{
    public GameObject upgradePanel;

    [SerializeField] private PauseGame getPauseGameScript;
    [SerializeField] private PlayerController getPlayerControllerScript;
    [SerializeField] private PortalForPlayer leftPanelScript;
    [SerializeField] private PortalForPlayer rightPanelScript;
    [SerializeField] private Joystick joysticRotate;
    [SerializeField] private GameObject firstShip;
    [SerializeField] private GameObject secondShip;
    [SerializeField] private Slider sliderShieldHP;
    [SerializeField] private ShieldHP shieldScript;

    private float currentHpPlayer;
    private float currentShutDelay;
    private float currentShutDelayRocket;

    public void AddRateOfFire()
    {
        currentShutDelay = getPlayerControllerScript.shootDelayGun;
        getPlayerControllerScript.shootDelayGun = currentShutDelay - PlayerStats.incShootDelayGun;
        PlayerPrefs.SetFloat(PlayerStats.shootDelayGun, currentShutDelay - PlayerStats.incShootDelayGun);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddHP()
    {
        FindObjectOfType<PlayerHP>().UpgradeAddHP(20);
        currentHpPlayer = PlayerPrefs.GetFloat(PlayerStats.hpPlayer);
        PlayerPrefs.SetFloat(PlayerStats.hpPlayer, currentHpPlayer + 20f);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddGunTwo()
    {
        getPlayerControllerScript.isGunTwo = true;
        PlayerPrefs.SetInt(PlayerStats.isGunTwo, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddGunTree()
    {
        getPlayerControllerScript.isGunTree = true;
        PlayerPrefs.SetInt(PlayerStats.isGunTree, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddMoveSpeed()
    {
        getPlayerControllerScript.moveSpeed += PlayerStats.incMoveSpeed;
        PlayerPrefs.SetFloat(PlayerStats.moveSpeed, getPlayerControllerScript.moveSpeed);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void OpenPortal()
    {
        leftPanelScript.isOpenPortal = true;
        rightPanelScript.isOpenPortal = true;
        PlayerPrefs.SetInt(PlayerStats.isOpenPortal, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddRotation()
    {
        joysticRotate.gameObject.SetActive(true);
        getPlayerControllerScript.isPalyerRotate = true;
        PlayerPrefs.SetInt(PlayerStats.isPalyerRotate, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddFlot()
    {
        firstShip.SetActive(true);
        PlayerPrefs.SetInt(PlayerStats.isFirstShipFlot, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddSecondShipFlot()
    {
        secondShip.SetActive(true);
        PlayerPrefs.SetInt(PlayerStats.isSecondShipFlot, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddRocket()
    {
        getPlayerControllerScript.isRocket = true;
        PlayerPrefs.SetInt(PlayerStats.isRocket, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    /*public void AddRocketRateOfFire()
    {
        currentShutDelayRocket = getPlayerControllerScript.shootDelayRocket;
        getPlayerControllerScript.shootDelayRocket = currentShutDelayRocket - PlayerStats.incShootDelayRocket;
        PlayerPrefs.SetFloat(PlayerStats.shootDelayRocket, currentShutDelayRocket - PlayerStats.incShootDelayRocket);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }*/

    public void ActivateShield()
    {
        shieldScript.ReactivateShield();
        sliderShieldHP.gameObject.SetActive(true);
        PlayerPrefs.SetInt(PlayerStats.isShield, 1);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }
}
