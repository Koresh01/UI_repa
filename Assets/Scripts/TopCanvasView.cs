using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopCanvasView : MonoBehaviour
{
    [SerializeField] private Button _heroesBtn;
    [SerializeField] private Button _levelsBtn;
    [SerializeField] private Button _lobbyBtn;
    [SerializeField] private Button _armoryBtn;

    [SerializeField] private GameObject _heroesTab;
    [SerializeField] private GameObject _levelsTab;
    [SerializeField] private GameObject _lobbyTab;
    [SerializeField] private GameObject _armoryTab;


    private void OnEnable()
    {
        _heroesBtn.onClick.AddListener(heroesBtnDown);
        _levelsBtn.onClick.AddListener(levelsBtnDown);
        _lobbyBtn.onClick.AddListener(lobbyBtnDown);
        _armoryBtn.onClick.AddListener(armoryBtnDown);
    }

    private void OnDisable()
    {
        _heroesBtn.onClick.RemoveListener(heroesBtnDown);
    }

    void heroesBtnDown()
    {
        _heroesTab.SetActive(true);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(false);
    }
    void levelsBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(true);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(false);
    }
    void lobbyBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(true);
        _armoryTab.SetActive(false);
    }
    void armoryBtnDown()
    {
        _heroesTab.SetActive(false);
        _levelsTab.SetActive(false);
        _lobbyTab.SetActive(false);
        _armoryTab.SetActive(true);
    }
}
