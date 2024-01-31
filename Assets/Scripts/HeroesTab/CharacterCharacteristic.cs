using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnterFileNamePlease", menuName = "Character Characteristic", order = 51)]
public class CharacterCharacteristic : ScriptableObject
{
    [SerializeField] private CharacterTypes _type;
    public CharacterTypes Type => _type;


    [SerializeField] private Sprite _icon;
    public Sprite Icon => _icon;



    [SerializeField] private float _speed;
    public float Speed => _speed;


    [SerializeField] private float _heath;
    public float Heath => _heath;
}
