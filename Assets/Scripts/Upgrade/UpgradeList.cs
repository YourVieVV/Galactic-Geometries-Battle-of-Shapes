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
        new Upgrade { Name = NamesUpgradePlayer.AddFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddSecondShipFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTwo },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTree },
        new Upgrade { Name = NamesUpgradePlayer.AddRotation },
        new Upgrade { Name = NamesUpgradePlayer.ActivateShield },
        new Upgrade { Name = NamesUpgradePlayer.AddRocket },
        new Upgrade { Name = NamesUpgradePlayer.OpenPortal }
        //new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        //new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        //new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        //new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        //new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaser },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire },
        //new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire }
    };

    public List<Upgrade> _RusUpgrades = new()
    {
        new Upgrade { Name = RusNameUpgrades.AddHP },
        new Upgrade { Name = RusNameUpgrades.AddHP },
        new Upgrade { Name = RusNameUpgrades.AddHP },
        new Upgrade { Name = RusNameUpgrades.AddMoveSpeed },
        new Upgrade { Name = RusNameUpgrades.AddMoveSpeed },
        new Upgrade { Name = RusNameUpgrades.AddMoveSpeed },
        new Upgrade { Name = RusNameUpgrades.AddRateOfFire },
        new Upgrade { Name = RusNameUpgrades.AddRateOfFire },
        new Upgrade { Name = RusNameUpgrades.AddRateOfFire },
        new Upgrade { Name = RusNameUpgrades.AddFlot },
        new Upgrade { Name = RusNameUpgrades.AddSecondShipFlot },
        new Upgrade { Name = RusNameUpgrades.AddGunTwo },
        new Upgrade { Name = RusNameUpgrades.AddGunTree },
        new Upgrade { Name = RusNameUpgrades.AddRotation },
        new Upgrade { Name = RusNameUpgrades.ActivateShield },
        new Upgrade { Name = RusNameUpgrades.AddRocket },
        new Upgrade { Name = RusNameUpgrades.OpenPortal }
    };
}
