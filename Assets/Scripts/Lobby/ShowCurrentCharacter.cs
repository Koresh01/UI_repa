using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ShowCurrentCharacter : MonoBehaviour
{
    [SerializeField] private Transform spawn_area;
    public PlaneRotation _pl;
    private GameObject _currentCharacter;

    int tmp = -1;

    private void Update()
    {
        if (tmp != _pl._characterIndex) {
            Destroy(_currentCharacter);
            tmp = _pl._characterIndex;
            _currentCharacter = Instantiate(_pl.playersPrefabs[_pl._characterIndex], spawn_area.position, Quaternion.identity, spawn_area);
        }
    }
}
