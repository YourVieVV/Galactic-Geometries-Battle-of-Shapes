using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
    // DEFINE LIST WITH UPGRADES
    Upgrade[] _Upgrades = new Upgrade[]
    {
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddHP },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddMoveSpeed },
        new Upgrade { Name = NamesUpgradePlayer.AddRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        new Upgrade { Name = NamesUpgradePlayer.AddDamage },
        new Upgrade { Name = NamesUpgradePlayer.AddFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddFlot },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTwo },
        new Upgrade { Name = NamesUpgradePlayer.AddGunTree },
        new Upgrade { Name = NamesUpgradePlayer.AddRotation },
        new Upgrade { Name = NamesUpgradePlayer.ActivateShid },
        new Upgrade { Name = NamesUpgradePlayer.AddLaser },
        new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddLaserRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRocket },
        new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.AddRocketRateOfFire },
        new Upgrade { Name = NamesUpgradePlayer.OpenPortal }
    };


    [SerializeField] private Button Upgrade_button1;
    [SerializeField] private Button Upgrade_button2;
    [SerializeField] private Button Upgrade_button3;

    private void Start()
    {
        ButtonsSet();
    }

    public void ButtonsSet()
    {
        // CHOOSING UPGRADE FROM UPGRADE ARRAY
        List<int> availableUpgrades = new List<int>();
        for (int i = 0; i < _Upgrades.Length; i++)
        {
            availableUpgrades.Add(i);
        }

        ShuffleList(availableUpgrades);
        Upgrade Upgrade_1 = _Upgrades[availableUpgrades[0]];
        Upgrade Upgrade_2 = _Upgrades[availableUpgrades[1]];
        Upgrade Upgrade_3 = _Upgrades[availableUpgrades[2]];

        // Setting text
        Upgrade_button1.transform.GetChild(0).GetComponent<Text>().text = Upgrade_1.Name;
        Upgrade_button2.transform.GetChild(0).GetComponent<Text>().text = Upgrade_2.Name;
        Upgrade_button3.transform.GetChild(0).GetComponent<Text>().text = Upgrade_3.Name;
    }

    // SHUFFLE LIST
    public void ShuffleList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(i, list.Count);
            int temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    public class Upgrade
    {
        public string Name { get; set; }
    }
}
