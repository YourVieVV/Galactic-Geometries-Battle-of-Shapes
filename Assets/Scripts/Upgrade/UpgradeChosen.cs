using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeChosen : MonoBehaviour
{
    private UpgradesForPlayer _NameUpgradesPlayer;

    private void Awake()
    {
        _NameUpgradesPlayer = GetComponent<UpgradesForPlayer>();
    }

    public void UpChosen(string Upgrade_chosen)
    {   
        switch (Upgrade_chosen)
        {
            case NamesUpgradePlayer.AddHP:
                _NameUpgradesPlayer.AddHP();
                break;
            case NamesUpgradePlayer.AddMoveSpeed:
                _NameUpgradesPlayer.AddMoveSpeed();
                break;
            case NamesUpgradePlayer.AddRateOfFire:
                _NameUpgradesPlayer.AddRateOfFire();
                break;
            case NamesUpgradePlayer.AddGunTwo:
                _NameUpgradesPlayer.AddGunTwo();
                break;
            case NamesUpgradePlayer.AddGunTree:
                _NameUpgradesPlayer.AddGunTree();
                break;
            case NamesUpgradePlayer.OpenPortal:
                _NameUpgradesPlayer.OpenPortal();
                break;
            case NamesUpgradePlayer.AddRotation:
                //_NameUpgradesPlayer.AddHP();
                break;
            case NamesUpgradePlayer.AddFlot:
                //_NameUpgradesPlayer.AddHP();
                break;
            default: break;

        }
       
    }
}
