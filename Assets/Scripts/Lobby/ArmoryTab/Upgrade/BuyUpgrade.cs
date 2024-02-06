using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyUpgrade : MonoBehaviour
{
    [SerializeField] private Text _currentMoneyText;
    [SerializeField] private Animator _buttonAnimation;
    private WeaponCharacteristic _weaponCharacteristic;
    public static Action<WeaponCharacteristic> SucsecfulBuy;
    public void Buy()
    {
        int currentMoney = Int32.Parse(_currentMoneyText.text);
        int currentLevel = PlayerPrefs.GetInt($"Level{_weaponCharacteristic.Name}");
        if(currentMoney >= _weaponCharacteristic.Cost)
        {
            currentMoney -= _weaponCharacteristic.Cost;
            _currentMoneyText.text = Convert.ToString(currentMoney);
            currentLevel += 1;
            PlayerPrefs.SetInt($"Level{_weaponCharacteristic.Name}", currentLevel);
            SucsecfulBuy?.Invoke(_weaponCharacteristic);
        }
        else
        {
            _buttonAnimation.Play("UpgradeFail");
        }
    }

    private void SetWeaponCharcteristic(WeaponCharacteristic weaponCharacteristic)
    {
        _weaponCharacteristic = weaponCharacteristic;
    }
    private void OnEnable() {
        WeaponInfo.GetUpgradeInfo += SetWeaponCharcteristic;
    }
    private void OnDisable() {
        WeaponInfo.GetUpgradeInfo -= SetWeaponCharcteristic;
    }

}
