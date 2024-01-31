using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] CharacterCharacteristic _characterCharacteristic;
    public static Action<CharacterCharacteristic> GetInfo;

    public void SelectCharacter()
    {
        GetInfo?.Invoke(_characterCharacteristic);
    }
}
