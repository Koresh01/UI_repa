using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnterFileNamePlease", menuName = "Game Session Characteristics", order = 51)]
public class GameSessionCharacteristics : ScriptableObject
{
    [SerializeField] private int _level;
    public int Level  => _level;

    [SerializeField] private int _difficulty;
    public int Difficulty => _difficulty;
}
