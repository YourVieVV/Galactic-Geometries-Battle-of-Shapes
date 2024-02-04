using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] private UpgradeSystem UpgradesSystemScript;
    [SerializeField] private UpgradeChosen UpgradeChosenScript;

    public void Upgrade()
    {
        string Upgrade_chosen = gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text;
        UpgradeChosenScript.UpChosen(Upgrade_chosen);
        UpgradeSystem.Upgrade selectedUpgrade = new UpgradeSystem.Upgrade { Name= Upgrade_chosen };
        UpgradesSystemScript.DeleteSelectedUpgrade(selectedUpgrade);
        UpgradesSystemScript.ButtonsSet();
    }
}
