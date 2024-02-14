using UnityEngine;

public class UpgradeChosen : MonoBehaviour
{
    [SerializeField]
    private UpgradesForPlayer _NameUpgradesPlayerScript;

    public void UpChosen(string Upgrade_chosen)
    {
        /* if (Upgrade_chosen == NamesUpgradePlayer.AddHP)
         {
             _NameUpgradesPlayerScript.AddHP();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddMoveSpeed)
         {

             _NameUpgradesPlayerScript.AddMoveSpeed();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddRateOfFire)
         {

             _NameUpgradesPlayerScript.AddRateOfFire();

         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddGunTwo)
         {

             _NameUpgradesPlayerScript.AddGunTwo();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddGunTree)
         {

             _NameUpgradesPlayerScript.AddGunTree();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.OpenPortal)
         {

             _NameUpgradesPlayerScript.OpenPortal();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddRotation)
         {

             _NameUpgradesPlayerScript.AddRotation();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddFlot)
         {

             _NameUpgradesPlayerScript.AddFlot();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddSecondShipFlot)
         {

             _NameUpgradesPlayerScript.AddSecondShipFlot();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.ActivateShield)
         {

             _NameUpgradesPlayerScript.ActivateShield();
         }
         if (Upgrade_chosen == NamesUpgradePlayer.AddRocket)
         {

             _NameUpgradesPlayerScript.AddRocket();
         }*/
        if (PlayerPrefs.GetString("Lang") == "ru")
        {
            switch (Upgrade_chosen)
            {
                case RusNameUpgrades.AddHP:
                    _NameUpgradesPlayerScript.AddHP();
                    break;
                case RusNameUpgrades.AddMoveSpeed:
                    _NameUpgradesPlayerScript.AddMoveSpeed();
                    break;
                case RusNameUpgrades.AddRateOfFire:
                    _NameUpgradesPlayerScript.AddRateOfFire();
                    break;
                case RusNameUpgrades.AddGunTwo:
                    _NameUpgradesPlayerScript.AddGunTwo();
                    break;
                case RusNameUpgrades.AddGunTree:
                    _NameUpgradesPlayerScript.AddGunTree();
                    break;
                case RusNameUpgrades.OpenPortal:
                    _NameUpgradesPlayerScript.OpenPortal();
                    break;
                case RusNameUpgrades.AddRotation:
                    _NameUpgradesPlayerScript.AddRotation();
                    break;
                case RusNameUpgrades.AddFlot:
                    _NameUpgradesPlayerScript.AddFlot();
                    break;
                case RusNameUpgrades.AddSecondShipFlot:
                    _NameUpgradesPlayerScript.AddSecondShipFlot();
                    break;
                case RusNameUpgrades.ActivateShield:
                    _NameUpgradesPlayerScript.ActivateShield();
                    break;
                case RusNameUpgrades.AddRocket:
                    _NameUpgradesPlayerScript.AddRocket();
                    break;
                default: break;
            }
        }
        else
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
                case NamesUpgradePlayer.ActivateShield:
                    _NameUpgradesPlayerScript.ActivateShield();
                    break;
                case NamesUpgradePlayer.AddRocket:
                    _NameUpgradesPlayerScript.AddRocket();
                    break;
                /*case NamesUpgradePlayer.AddRocketRateOfFire:
                    _NameUpgradesPlayerScript.AddRocketRateOfFire();
                    break;*/
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
