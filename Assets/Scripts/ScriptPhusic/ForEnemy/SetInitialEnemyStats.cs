using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialEnemyStats : MonoBehaviour
{
    public void SetInitialValuesEnemy()
    {
        if (PlayerPrefs.HasKey("isSetStartValuesEnemy") == false)
        {
            PlayerPrefs.SetFloat(EmenyStats.hpIsometric, EmenyStats.initHpIsometric);
            PlayerPrefs.SetFloat(EmenyStats.hpRectangle, EmenyStats.initHpRectangle);
            PlayerPrefs.SetFloat(EmenyStats.hpOval, EmenyStats.initHpOval);
            PlayerPrefs.SetFloat(EmenyStats.hpCircle, EmenyStats.initHpCircle);
            PlayerPrefs.SetFloat(EmenyStats.hpHexagon, EmenyStats.initHpHexagon);
            PlayerPrefs.SetFloat(EmenyStats.hpCapsule, EmenyStats.initHpCapsule);

            PlayerPrefs.SetFloat(EmenyStats.shootDelayCapsule, EmenyStats.initShootDelayCapsule);
            PlayerPrefs.SetFloat(EmenyStats.shootDelayCircle, EmenyStats.initShootDelayCircle);
            PlayerPrefs.SetFloat(EmenyStats.shootDelayHexagon, EmenyStats.initShootDelayHexagon);
            PlayerPrefs.SetFloat(EmenyStats.shootDelayOval, EmenyStats.initShootDelayOval);
            PlayerPrefs.SetFloat(EmenyStats.shootDelayRectangle, EmenyStats.initShootDelayRectangle);
            PlayerPrefs.SetFloat(EmenyStats.shootDelayIsometric, EmenyStats.initShootDelayIsometric);

            PlayerPrefs.SetInt("isSetStartValuesEnemy", 1);
        }
    }

    private void Start()
    {
        SetInitialValuesEnemy();
    }
}
