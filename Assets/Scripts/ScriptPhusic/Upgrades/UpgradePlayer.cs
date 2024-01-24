using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePlayer : MonoBehaviour
{
    public GameObject upgrade2min;
    private PauseGame getPauseGame;
    private PlayerController getPlayerController;
    private TimerText timer;
    private float currentShutDelay;
    private bool isVisible = false;
    private bool isTodoName = false;
    
    private void Start()
    {
        getPauseGame = FindObjectOfType<PauseGame>();
        timer = FindObjectOfType<TimerText>();
        getPlayerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (timer.timerMin == 1 && !isTodoName)
        {
            isVisible = true;
            isTodoName = true;
        }
        if (isVisible)
        {
            getPauseGame.PauseGameFunction(true, upgrade2min);
        }
    }

    public void AddRateOfFire()
    {
        currentShutDelay = getPlayerController.shootDelay;
        getPlayerController.shootDelay = currentShutDelay - 0.2f;
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }

    public void AddHP()
    {
        FindObjectOfType<PlayerHP>().UpgradeAddHP(20);
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }

    public void AddGunTwo()
    {
        getPlayerController.isGunTwo = true;
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }

    public void AddGunTree()
    {
        getPlayerController.isGunTree = true;
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }

    public void AddMoveSpeed()
    {
        getPlayerController.MoveSpeed += 0.2f;
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }

    public void OpenPortal()
    {
        FindObjectOfType<PortalForPlayer>().isOpenPortal = true;
        getPauseGame.PauseGameFunction(false, upgrade2min);
        isVisible = false;
    }
}
