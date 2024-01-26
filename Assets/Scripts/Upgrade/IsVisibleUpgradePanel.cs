using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisibleUpgradePanel : MonoBehaviour
{
    public GameObject upgrades;
    private PauseGame getPauseGame;


    private void Awake()
    {
        getPauseGame = FindObjectOfType<PauseGame>();
    }

    public void SetIsVisibleUpgradePlayer()
    {
        getPauseGame.PauseAndSetActivePanelFunction(true, upgrades);
    }
}
