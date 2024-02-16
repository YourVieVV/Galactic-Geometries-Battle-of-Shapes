using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public const string
        shootDelayGun = "shootDelayGun",
        moveSpeed = "moveSpeed",
        hpPlayer = "hpPlayer",
        //shootDelayLaser = "shootDelayLaser",
        //shootDelayRocket = "shootDelayRocket",
        isGunTwo = "isGunTwo",
        isGunTree = "isGunTree",
        isRocket = "isRocket",
        isPalyerRotate = "isPalyerRotate",
        isFirstShipFlot = "isFirstShipFlot",
        isSecondShipFlot = "isSecondShipFlot",
        isOpenPortal = "isOpenPortal",
        isShield = "isShield",
        upgradeList = "upgradeList";

    public const float
        initShootDelayGun = 1f,
        initMoveSpeed = 2f,
        initHpPlayer = 100f;
        //initShootDelayLaser = 0.6f,
        //initShootDelayRocket = 2f;

    public const int initIsGunTwo = 0,
        initIsGunTree = 0,
        initIsRocket = 0,
        initIsPalyerRotate = 0,
        initIsShield = 0,
        initIsFirstShipFlot = 0,
        initIsSecondShipFlot = 0,
        initIsOpenPortal = 0,
        isSetStartValuesPlayer = 0;

    public const float
        incShootDelayGun = 0.2f,
        incMoveSpeed = 0.2f,
        incHpPlayer = 20f;
        //incShootDelayLaser = 0.2f,
        //incShootDelayRocket = 0.2f;   
}
