using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UpgradeSystem;

public class UpgradeList : MonoBehaviour
{
    // DEFINE LIST WITH UPGRADES
    public List<Upgrade> _Upgrades = new()
    {
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        new Upgrade { Name = NamesUpgradePlayer.AddFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddSecondShipFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTwo },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTree },
        new Upgrade { Name = NamesUpgradePlayer.AddRotation },
        new Upgrade { Name = NamesUpgradePlayer.ActivateShield },
        new Upgrade { Name = NamesUpgradePlayer.AddRocket },
        new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.OpenPortal },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaser },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire }
    };
}
