using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text _typeText;
    [SerializeField] private TMP_Text _speedText;
    [SerializeField] private TMP_Text _healthText;


    [SerializeField] private GameObject _healthField;
    [SerializeField] private GameObject _speedField;

    private void OnEnable()
    {
        Character.GetInfo += DisplayInfo;
    }
    private void OnDisable()
    {
        Character.GetInfo -= DisplayInfo;
    }

    public void DisplayInfo(CharacterCharacteristic characterCharacteristic)
    {
        _healthField.SetActive(false);
        _speedField.SetActive(false);
        
        _typeText.text = Convert.ToString(characterCharacteristic.Type);
        _healthText.text = Convert.ToString(characterCharacteristic.Heath);


        if (characterCharacteristic.Type != CharacterTypes.Melee)
        {
            DisplayOptionalField(characterCharacteristic);
        }
    }
    private void DisplayOptionalField(CharacterCharacteristic characterCharacteristic)
    {
        switch (characterCharacteristic.Type)
        {
            case CharacterTypes.Mage:
                DisplayHealth(characterCharacteristic);
                DisplaySpeed(characterCharacteristic);
                break;
            case CharacterTypes.archer:
                DisplayHealth(characterCharacteristic);
                DisplaySpeed(characterCharacteristic);
                break;
            case CharacterTypes.knight:
                DisplayHealth(characterCharacteristic);
                DisplaySpeed(characterCharacteristic);
                break;
            case CharacterTypes.robot:
                DisplayHealth(characterCharacteristic);
                DisplaySpeed(characterCharacteristic);
                break;
        }

    }
    private void DisplayHealth(CharacterCharacteristic characterCharacteristic)
    {
        _healthField.SetActive(true);
        _healthText.text = Convert.ToString(characterCharacteristic.Heath);
    }
    private void DisplaySpeed(CharacterCharacteristic characterCharacteristic)
    {
        _speedField.SetActive(true);
        _speedText.text = Convert.ToString(characterCharacteristic.Speed);
    }
}
