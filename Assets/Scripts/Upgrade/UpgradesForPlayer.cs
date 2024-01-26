using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesForPlayer : MonoBehaviour
{
    public GameObject upgradePanel;
    private float currentShutDelay;

    [SerializeField] private PauseGame getPauseGameScript;
    [SerializeField] private PlayerController getPlayerControllerScript;
    [SerializeField] private PortalForPlayer leftPanelScript;
    [SerializeField] private PortalForPlayer rightPanelScript;

    public void AddRateOfFire()
    {
        currentShutDelay = getPlayerControllerScript.shootDelay;
        getPlayerControllerScript.shootDelay = currentShutDelay - 0.2f;
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddHP()
    {
        FindObjectOfType<PlayerHP>().UpgradeAddHP(20);
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddGunTwo()
    {
        getPlayerControllerScript.isGunTwo = true;
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddGunTree()
    {
        getPlayerControllerScript.isGunTree = true;
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void AddMoveSpeed()
    {
        getPlayerControllerScript.MoveSpeed += 0.2f;
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }

    public void OpenPortal()
    {
        leftPanelScript.isOpenPortal = true;
        rightPanelScript.isOpenPortal = true;
        getPauseGameScript.PauseAndSetActivePanelFunction(false, upgradePanel);
    }
}
