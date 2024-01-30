using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidersController : MonoBehaviour
{
    [SerializeField] private CurrentCharacter _currentCharacter;

    public Slider health;
    public Slider speed;


    private void Update()
    {
        health.value = _currentCharacter.health;
        speed.value = _currentCharacter.speed;
    }
}
