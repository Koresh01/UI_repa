using System;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public static Action<WeaponCharacteristic> SetLevel;
    private WeaponCharacteristic[] _weaponCharacteristics;

    public void SetCurrentLevel(int level)
    {
        SetLevel?.Invoke(_weaponCharacteristics[level]);
    }

    private void GetCharacteristics(WeaponCharacteristic[] weaponCharacteristics)
    {
        _weaponCharacteristics = weaponCharacteristics;
    }
    private void OnEnable() {
        Weapon.GetLevels += GetCharacteristics;
    }
    private void OnDisable() {
        Weapon.GetLevels -= GetCharacteristics;
    }
}
