using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyPanelVew : MonoBehaviour
{
    [Header("Кнопки:")]
    [SerializeField] private Button _startBtn;

    [Header("Для сбора информации с остальных вкладок:")]
    [SerializeField] HeroesPanelView hero_panel_info;   // on Hero Tab => know current hero...
    [SerializeField] LevelPanelViev level_panel_info;
    [SerializeField] ArmoryPanelView armory_panel_info;

    [Header("Основная информация(перед запуском сцены с уровнем):")]
    [SerializeField] private GameObject _gun;
    [SerializeField] private GameObject _hero;
    [SerializeField] private int _level;
    [SerializeField] private string _difficulty;

    private void OnEnable()
    {
        _startBtn.onClick.AddListener(startBtnDown);
    }
    private void OnDisable()
    {
        _startBtn.onClick.RemoveListener(startBtnDown);
    }
    void startBtnDown()
    {
        CollectParams();
        SaveParams();

        // Загружаем другую сцену:
        SceneManager.LoadScene("Level1");
    }
    private void CollectParams()
    {
        _hero = hero_panel_info.curHero;
        //_gun = armory_panel_info.curGun
        _level = level_panel_info.levelСounter;
        _difficulty = level_panel_info.difficulty;
    }
    private void SaveParams()
    {
        LevelsParametrs._hero = _hero;
        //_gun = armory_panel_info.curGun
        LevelsParametrs._level = _level;
        LevelsParametrs._difficulty = _difficulty;
    }
}
