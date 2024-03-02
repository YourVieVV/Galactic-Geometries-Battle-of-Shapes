using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
    [SerializeField] private Button Upgrade_button1;
    [SerializeField] private Button Upgrade_button2;
    [SerializeField] private Button Upgrade_button3;
    public List<Upgrade> upgradesList = new();

    private void Start()
    {
        var updateArray = PlayerPrefs.GetString(PlayerStats.upgradeList).Split("|");
        Debug.Log($"sss={updateArray}");
        for (int i = 0; updateArray.Length - 1 > i; i++)
        {
            if (updateArray[i] != "" && updateArray[i] != null)
            {
                upgradesList.Add(new Upgrade { Name = updateArray[i] });
            }
        }
        Debug.Log($"DDD={upgradesList}");
        ButtonsSet();
    }

    public void ButtonsSet()
    {
        // CHOOSING UPGRADE FROM UPGRADE ARRAY
        List<int> availableUpgrades = new List<int>();
        for (int i = 0; i < upgradesList.Count; i++)
        {
            availableUpgrades.Add(i);
        }

        if (availableUpgrades.Count >= 3)
            ShuffleList(availableUpgrades);

        // Setting text
        Upgrade Upgrade_1;
        Upgrade Upgrade_2;
        Upgrade Upgrade_3;
        if (availableUpgrades.Count > 0)
        {
            Upgrade_1 = upgradesList[availableUpgrades[0]];
            Upgrade_button1.transform.GetChild(0).GetComponent<Text>().text = Upgrade_1.Name;
            Upgrade_button2.transform.GetChild(0).GetComponent<Text>().text = "";
        }
        if (availableUpgrades.Count > 1)
        {
            Upgrade_2 = upgradesList[availableUpgrades[1]];
            Upgrade_button2.transform.GetChild(0).GetComponent<Text>().text = Upgrade_2.Name;
            Upgrade_button3.transform.GetChild(0).GetComponent<Text>().text = "";
        }
        if (availableUpgrades.Count > 2)
        {
            Upgrade_3 = upgradesList[availableUpgrades[2]];
            Upgrade_button3.transform.GetChild(0).GetComponent<Text>().text = Upgrade_3.Name;
        }
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

    public void DeleteSelectedUpgrade(Upgrade upgradeName)
    {
        Debug.Log($"upgradeName={upgradeName}");
        int indx = upgradesList.FindIndex(item => item.Name == upgradeName.Name);
        Debug.Log($"indx={indx}");
        upgradesList.RemoveAt(indx);
        Debug.Log($"upgradesList={upgradesList}");
        SetUpgradeList(upgradesList);
    }

    public void SetUpgradeList(List<Upgrade> upgradeList)
    {
        string stingUpgrade = "";
        upgradeList.ForEach(item => stingUpgrade = stingUpgrade + item.Name + "|");
        PlayerPrefs.SetString(PlayerStats.upgradeList, stingUpgrade);
        Debug.Log($"stingUpgrade={stingUpgrade}");
    }

    public class Upgrade
    {
        public string Name { get; set; }
    }
}
