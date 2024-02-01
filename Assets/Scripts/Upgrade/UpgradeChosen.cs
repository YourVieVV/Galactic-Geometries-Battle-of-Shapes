using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeChosen : MonoBehaviour
{
    [SerializeField]
    private UpgradesForPlayer _NameUpgradesPlayerScript;

    public void UpChosen(string Upgrade_chosen)
    {   
        switch (Upgrade_chosen)
        {
            case NamesUpgradePlayer.AddHP:
                _NameUpgradesPlayerScript.AddHP();
                break;
            case NamesUpgradePlayer.AddMoveSpeed:
                _NameUpgradesPlayerScript.AddMoveSpeed();
                break;
            case NamesUpgradePlayer.AddRateOfFire:
                _NameUpgradesPlayerScript.AddRateOfFire();
                break;
            case NamesUpgradePlayer.AddGunTwo:
                _NameUpgradesPlayerScript.AddGunTwo();
                break;
            case NamesUpgradePlayer.AddGunTree:
                _NameUpgradesPlayerScript.AddGunTree();
                break;
            case NamesUpgradePlayer.OpenPortal:
                _NameUpgradesPlayerScript.OpenPortal();
                break;
            case NamesUpgradePlayer.AddRotation:
                _NameUpgradesPlayerScript.AddRotation();
                break;
            case NamesUpgradePlayer.AddFlot:
                _NameUpgradesPlayerScript.AddFlot();
                break;
            case NamesUpgradePlayer.AddSecondShipFlot:
                _NameUpgradesPlayerScript.AddSecondShipFlot();
                break;
            case NamesUpgradePlayer.ActivateShid:
                //_NameUpgradesPlayer.AddHP();
                break;
            case NamesUpgradePlayer.AddRocket:
                _NameUpgradesPlayerScript.AddRocket();
                break;
            case NamesUpgradePlayer.AddRocketRateOfFire:
                _NameUpgradesPlayerScript.AddRocketRateOfFire();
                break;
            //case NamesUpgradePlayer.AddDamage:
            //_NameUpgradesPlayer.AddHP();
            //break;
            //case NamesUpgradePlayer.AddLaser:
            //_NameUpgradesPlayer.AddHP();
            //break;
            //case NamesUpgradePlayer.AddLaserRateOfFire:
            //_NameUpgradesPlayer.AddHP();
            //break;
            default: break;
        }
       
    }
}
