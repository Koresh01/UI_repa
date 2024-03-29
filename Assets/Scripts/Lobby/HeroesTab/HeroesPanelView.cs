using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeroesPanelView : MonoBehaviour
{
    [SerializeField] private GameObject _heroDemonstration;
    [SerializeField] private GameObject[] _heroModels;

    [SerializeField] private TMP_Text _typeText;
    [SerializeField] private TMP_Text _speedText;
    [SerializeField] private TMP_Text _healthText;


    [SerializeField] private GameObject _healthField;
    [SerializeField] private GameObject _speedField;

    private void OnEnable()
    {
        _heroDemonstration.SetActive(true);
        Character.GetInfo += DisplayInfo;
        Character.GetInfo += DisplayHeroModel;
    }
    private void OnDisable()
    {
        _heroDemonstration.SetActive(false);
        Character.GetInfo -= DisplayInfo;
        Character.GetInfo -= DisplayHeroModel;
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


    public void DisplayHeroModel(CharacterCharacteristic characterCharacteristic)
    {
        switch (characterCharacteristic.Type)
        {
            case CharacterTypes.Mage:
                GameObject mag = _heroModels[0];
                _heroDemonstration.GetComponentInChildren<HeroDemonstrationView>().ChangeHeroModel(mag);
                break;
            case CharacterTypes.archer:
                GameObject archer = _heroModels[1];
                _heroDemonstration.GetComponentInChildren<HeroDemonstrationView>().ChangeHeroModel(archer);
                break;
            case CharacterTypes.knight:
                GameObject knight = _heroModels[2];
                _heroDemonstration.GetComponentInChildren<HeroDemonstrationView>().ChangeHeroModel(knight);
                break;
            case CharacterTypes.robot:
                GameObject robot = _heroModels[3];
                _heroDemonstration.GetComponentInChildren<HeroDemonstrationView>().ChangeHeroModel(robot);
                break;
            case CharacterTypes.Melee:
                GameObject Melee = _heroModels[4];
                _heroDemonstration.GetComponentInChildren<HeroDemonstrationView>().ChangeHeroModel(Melee);
                break;
        }
    }

}

