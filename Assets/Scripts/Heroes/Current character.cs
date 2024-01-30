using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currentcharacter : MonoBehaviour
{
    [SerializeField] private PlaneRotation pr;

    [SerializeField] private GameObject character;
    [SerializeField] private float speed;
    [SerializeField] private float health;

    private void Start()
    {
        
    }
    private void Update()
    {
        character = pr.playersPrefabs[pr._characterIndex];
        speed = character.GetComponent<Character_parameters>().speed;
        health = character.GetComponent<Character_parameters>().helth;
    }
}
