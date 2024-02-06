using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableUpgrades : MonoBehaviour
{
    [SerializeField] private Button _level1;
    [SerializeField] private Button _level2;
    [SerializeField] private Button _level3;

    private void OnEnable() {
        Weapon.GetInfo += ChekcUpgrades;
        Upgrade.SetLevel += ChekcUpgrades;
        BuyUpgrade.SucsecfulBuy += ChekcUpgrades;
    }
    private void OnDisable() {
        Weapon.GetInfo -= ChekcUpgrades;
        Upgrade.SetLevel -= ChekcUpgrades;
        BuyUpgrade.SucsecfulBuy -= ChekcUpgrades;
    }


    private void ChekcUpgrades(WeaponCharacteristic weaponCharacteristic)
    {
        switch(PlayerPrefs.GetInt($"Level{weaponCharacteristic.Name}"))
        {
            case 0:
                _level1.enabled = true;
                _level2.enabled = true;
                _level3.enabled = false;
                break;
            case 1:
                _level1.enabled = true;
                _level2.enabled = true;
                _level3.enabled = true;
                break;
        }
    }
}
