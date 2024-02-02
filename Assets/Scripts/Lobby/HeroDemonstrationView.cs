using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDemonstrationView : MonoBehaviour
{
    public GameObject _hero;
    [SerializeField] private Transform _spawn;

    public void ChangeHeroModel(GameObject hero)
    {
        Destroy(_hero);
        _hero = Instantiate(hero, _spawn.position, Quaternion.identity);
    }
}
