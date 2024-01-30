using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCharacter : MonoBehaviour
{
    [SerializeField] private PlaneRotation _planeRotation;

    [SerializeField] private GameObject character;
    public float speed;
    public float health;

    private void Start()
    {
        
    }
    private void Update()
    {
        int indx = _planeRotation._characterIndex;
        character = _planeRotation.playersPrefabs[indx];
        speed = character.GetComponent<Character_parameters>().speed;
        health = character.GetComponent<Character_parameters>().helth;
    }
}
