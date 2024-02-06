using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponCharacteristic[] _characteristics;
    [SerializeField] private GameObject _weaponInfo;
    public static Action<WeaponCharacteristic> GetInfo;
    public static Action<WeaponCharacteristic[]> GetLevels;

    public void SelectWeapon()
    {
        PlayerPrefs.SetInt($"Level{_characteristics[0].Name}", 0);
        _weaponInfo.SetActive(true);
        GetInfo?.Invoke(_characteristics[PlayerPrefs.GetInt($"Level{_characteristics[0].Name}")]);
        GetLevels?.Invoke(_characteristics);
    }
}
