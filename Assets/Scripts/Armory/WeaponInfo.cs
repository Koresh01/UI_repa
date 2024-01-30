using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class WeaponInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private TMP_Text _typeText;
    [SerializeField] private TMP_Text _damageText;
    [SerializeField] private TMP_Text _fireRateText;
    [SerializeField] private TMP_Text _cooldownText;
    [SerializeField] private TMP_Text _distanceText;
    [SerializeField] private TMP_Text _spreadText;
    [SerializeField] private TMP_Text _bulletCountText;
    [SerializeField] private TMP_Text _explosionAreaText;
    [SerializeField] private GameObject _spreadField;
    [SerializeField] private GameObject _bulletCountField;
    [SerializeField] private GameObject _explosionAreaField;

    private void OnEnable() {
        Weapon.GetInfo += DisplayInfo;
    }
    private void OnDisable() {
        Weapon.GetInfo -= DisplayInfo;
    }

    public void DisplayInfo(WeaponCharacteristic weaponCharacteristic)
    {
        _spreadField.SetActive(false);
        _bulletCountField.SetActive(false);
        _explosionAreaField.SetActive(false);
        _nameText.text = weaponCharacteristic.Name;
        _typeText.text = Convert.ToString(weaponCharacteristic.Type);
        _damageText.text = Convert.ToString(weaponCharacteristic.Damage);
        _fireRateText.text = Convert.ToString(weaponCharacteristic.FireRate);
        _cooldownText.text = Convert.ToString(weaponCharacteristic.Cooldown);
        _distanceText.text = Convert.ToString(weaponCharacteristic.Distance);
        if(weaponCharacteristic.Type != WeaponTypes.Melee)
        {
            DisplayOptionalField(weaponCharacteristic);
        }
    }
    private void DisplayOptionalField(WeaponCharacteristic weaponCharacteristic)
    {
        switch (weaponCharacteristic.Type)
        {
            case WeaponTypes.Rifle:
                DisplaySpread(weaponCharacteristic);
                break;
            case WeaponTypes.MachineGun:
                DisplaySpread(weaponCharacteristic);
                break;
            case WeaponTypes.SubmachineGun:
                DisplaySpread(weaponCharacteristic);
                break;
            case WeaponTypes.Shotgun:
                DisplaySpread(weaponCharacteristic);
                DisplayBulletCount(weaponCharacteristic);
                break;
            case WeaponTypes.Exposion:
                DisplayExplosionArea(weaponCharacteristic);
                break;

        }

    }
    private void DisplaySpread(WeaponCharacteristic weaponCharacteristic)
    {
        _spreadField.SetActive(true);
        _spreadText.text = Convert.ToString(weaponCharacteristic.Spread);
    }
    private void DisplayBulletCount(WeaponCharacteristic weaponCharacteristic)
    {
        _bulletCountField.SetActive(true);
        _bulletCountText.text = Convert.ToString(weaponCharacteristic.BulletCount);
    }
    private void DisplayExplosionArea(WeaponCharacteristic weaponCharacteristic)
    {
        _explosionAreaField.SetActive(true);
        _explosionAreaText.text = Convert.ToString(weaponCharacteristic.ExplosionArea);
    }
}
