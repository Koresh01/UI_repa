using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopCanvasView : MonoBehaviour
{
    [SerializeField] private Button _heroesBtn;
    [SerializeField] private Button _levelsBtn;
    [SerializeField] private Button _lobbyBtn;
    [SerializeField] private Button _armoryBtn;

    [SerializeField] private Button _settingsBtn;
    [SerializeField] private Button _exitBtn;
    [SerializeField] private Button _startBtn;

    [SerializeField] private GameObject _heroesTab;
    [SerializeField] private GameObject _levelsTab;
    [SerializeField] private GameObject _lobbyTab;
    [SerializeField] private GameObject _armoryTab;
    [SerializeField] private GameObject _exitTab;

    [SerializeField] private GameObject _settingsTab;

    private void OnEnable()
    {
        _heroesBtn.onClick.AddListener(heroesBtnDown);
        _levelsBtn.onClick.AddListener(levelsBtnDown);
        _lobbyBtn.onClick.AddListener(lobbyBtnDown);
        _armoryBtn.onClick.AddListener(armoryBtnDown);

        _settingsBtn.onClick.AddListener(settingsBtnDown);
        _exitBtn.onClick.AddListener(exitBtnDown);
        _startBtn.onClick.AddListener(startBtnDown);
    }

    private void OnDisable()
    {
        _heroesBtn.onClick.RemoveListener(heroesBtnDown);
        _levelsBtn.onClick.RemoveListener(levelsBtnDown);
        _lobbyBtn.onClick.RemoveListener(lobbyBtnDown);
        _armoryBtn.onClick.RemoveListener(armoryBtnDown);

        _settingsBtn.onClick.RemoveListener(settingsBtnDown);
        _exitBtn.onClick.RemoveListener(exitBtnDown);
        _startBtn.onClick.RemoveListener(startBtnDown);
    }

    void heroesBtnDown()
    {
        _heroesTab.SetActive(true);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(false);
        
        
        _startBtn.gameObject.SetActive(false);
    }
    void levelsBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(true);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(false);

        _startBtn.gameObject.SetActive(false);
    }
    void lobbyBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(true);
        _armoryTab.SetActive(false);

        _startBtn.gameObject.SetActive(true);
    }
    void armoryBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(true);

        _startBtn.gameObject.SetActive(false);
    }

    void settingsBtnDown()
    {
        _settingsTab.SetActive(true);
    }
    void exitBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(false);
        _settingsTab.SetActive(false);
        _exitTab.SetActive(true);
    }

    void startBtnDown()
    {
        // Передаем GameSessionCharacteristics на другую сцену:
        //GameManager.Instance.SetGameSessionCharacteristics(_gameSessionCharacteristics);

        // Загружаем другую сцену:
        SceneManager.LoadScene("Level1");
    }
}
