using UnityEngine;

public class NamesUpgradePlayer : MonoBehaviour
{
    public static string
        AddRateOfFire = "Increase firing speed by 0.2",
        AddHP = "Increase health by 20",
        AddGunTwo = "Add a second gun",
        AddGunTree = "Add a third gun",
        AddMoveSpeed = "Increase movement speed by 0.2",
        OpenPortal = "Moving the player across the sides of the screen",
        AddFlot = "Add a ship for the flotilla",
        AddSecondShipFlot = "Add a new ship to the flotilla",
        ActivateShield = "Activate protective force field",
        AddRotation = "Add ship rotation",
        AddRocket = "Replace bullets with rockets";
    //AddDamage = "Increase damage by 20",
    //AddLaser = "Replace the current weapon with a laser one",
    //AddLaserRateOfFire = "Increase laser firing speed by 0.2",
    //AddRocketRateOfFire = "Increase the firing speed of the rocket launcher by 0.2",

    private void Start()
    {
        if (PlayerPrefs.GetString("Lang") == "ru")
        {
            AddRateOfFire = "Увеличить скорострельность на 0.2";
            AddHP = "Увеличить ХП на 20";
            AddGunTwo = "Добавить пушку";
            AddGunTree = "Добавить новую пушку";
            AddMoveSpeed = "Увеличить скорость на 0.2";
            OpenPortal = "Добавить передвижение сквозь стороны экрана";
            AddFlot = "Добавить корабль";
            AddSecondShipFlot = "Добавить новый корабль";
            ActivateShield = "Активировать силовой щит";
            AddRotation = "Добавить стик для поворота";
            AddRocket = "Заменить пули на ракеты";
        }
        else
        {
            AddRateOfFire = "Increase firing speed by 0.2";
            AddHP = "Increase health by 20";
            AddGunTwo = "Add a second gun";
            AddGunTree = "Add a third gun";
            AddMoveSpeed = "Increase movement speed by 0.2";
            OpenPortal = "Moving the player across the sides of the screen";
            AddFlot = "Add a ship for the flotilla";
            AddSecondShipFlot = "Add a new ship to the flotilla";
            ActivateShield = "Activate protective force field";
            AddRotation = "Add ship rotation";
            AddRocket = "Replace bullets with rockets";
        }

    }
}
