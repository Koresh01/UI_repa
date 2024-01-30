using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponCharacteristic _weaponCharacteristic;
    public static Action<WeaponCharacteristic> GetInfo;

    public void SelectWeapon()
    {
        GetInfo?.Invoke(_weaponCharacteristic);
    }
}
