using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class ChangeImages : MonoBehaviour
{
    [SerializeField] private Image _level1Image;
    [SerializeField] private Image _level2Image;
    [SerializeField] private Image _level3Image;
    

    private void OnEnable() {
        Weapon.GetInfo += LoadImages;
    }
    private void OnDisable() {
        Weapon.GetInfo -= LoadImages;
    }

    private void LoadImages(WeaponCharacteristic weaponCharacteristic)
    {
        _level1Image.sprite = weaponCharacteristic.Sprites[0];
        _level2Image.sprite = weaponCharacteristic.Sprites[1];
        _level3Image.sprite = weaponCharacteristic.Sprites[2];
    }
}
