using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelConfig : MonoBehaviour
{
    [Header("Основная информация(перед запуском сцены с уровнем):")]
    [SerializeField] private GameObject _gun;
    [SerializeField] private GameObject _hero;
    [SerializeField] private int _level;
    [SerializeField] private string _difficulty;


    private void Start()
    {
        _hero = LevelsParametrs._hero;
        //_gun = armory_panel_info.curGun
        _level = LevelsParametrs._level;
        _difficulty = LevelsParametrs._difficulty;
    }
}
