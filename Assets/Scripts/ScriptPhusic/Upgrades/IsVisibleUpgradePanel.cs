using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisibleUpgradePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject panelPause;
    private TimerText timer;

    private void Start()
    {
        timer = FindObjectOfType<TimerText>();
    }

    void Update()
    {
        if (timer.timerMin == 1)
        {
            FindObjectOfType<PauseGame>().PauseGameFunction(true, panelPause);
        }
    }
}
