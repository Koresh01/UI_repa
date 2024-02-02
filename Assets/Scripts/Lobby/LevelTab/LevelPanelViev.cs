using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelPanelViev : MonoBehaviour
{
    [Header("Кнопки этой панели:")]
    [SerializeField] private Button _lvl1Button;
    [SerializeField] private Button _lvl2Button;
    [SerializeField] private Button _lvl3Button;
    [SerializeField] private Button _lvl4Button;
    [SerializeField] private Button _easyLevelButton;
    [SerializeField] private Button _ordinaryLevelButton;
    [SerializeField] private Button _hardLevelButton;
    [SerializeField] private Button _yesButton;
    [SerializeField] private Button _noButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _exitLevelConirmationBatton;

    [Header("Вкладки уточнения сложности:")]
    [SerializeField] private GameObject _difficultyLevel;
    [SerializeField] private GameObject _levelConfirmation;

    [Header("Текстовые поля:")]
    [SerializeField] private TMP_Text _selectedLevel;
    [SerializeField] private TMP_Text _selectedLevelConfirmation;

    [Header("Собранная скриптом инфомация:")]
    public int levelСounter;
    public string difficulty;


    private void OnEnable()
    {
        _lvl1Button.onClick.AddListener(Lvl1ButtonDown);
        _lvl2Button.onClick.AddListener(Lvl2ButtonDown);
        _lvl3Button.onClick.AddListener(Lvl3ButtonDown);
        _lvl4Button.onClick.AddListener(Lvl4ButtonDown);
        _easyLevelButton.onClick.AddListener(EasyLevelButtonDown);
        _ordinaryLevelButton.onClick.AddListener(OrdinaryLevelButtonDown);
        _hardLevelButton.onClick.AddListener(HardLevelButtonDown);
        _yesButton.onClick.AddListener(YesButtonDown);
        _noButton.onClick.AddListener(NoButtonDown);
        _exitButton.onClick.AddListener(ExitButtonDown);
        _exitLevelConirmationBatton.onClick.AddListener(ExitLevelConirmationBattonDown);
    }

    private void OnDisable()
    {
        _lvl1Button.onClick.RemoveListener(Lvl1ButtonDown);
        _lvl2Button.onClick.RemoveListener(Lvl2ButtonDown);
        _lvl3Button.onClick.RemoveListener(Lvl3ButtonDown);
        _lvl4Button.onClick.RemoveListener(Lvl4ButtonDown);
        _easyLevelButton.onClick.RemoveListener(EasyLevelButtonDown);
        _ordinaryLevelButton.onClick.RemoveListener(OrdinaryLevelButtonDown);
        _hardLevelButton.onClick.RemoveListener(HardLevelButtonDown);
        _yesButton.onClick.RemoveListener(YesButtonDown);
        _noButton.onClick.RemoveListener(NoButtonDown);
        _exitButton.onClick.RemoveListener(ExitButtonDown);
        _exitLevelConirmationBatton.onClick.RemoveListener(ExitLevelConirmationBattonDown);
    }
    private void Lvl1ButtonDown()
    {
        _difficultyLevel.SetActive(true);
        _selectedLevel.text = "1";
        levelСounter = 1;
    }
    private void Lvl2ButtonDown()
    {
        _difficultyLevel.SetActive(true);
        _selectedLevel.text = "2";
        levelСounter = 2;
    }
    private void Lvl3ButtonDown()
    {
        _difficultyLevel.SetActive(true);
        _selectedLevel.text = "3";
        levelСounter = 3;
    }
    private void Lvl4ButtonDown()
    {
        _difficultyLevel.SetActive(true);
        _selectedLevel.text = "4";
        levelСounter = 4;
    }
    private void EasyLevelButtonDown()
    {
        _levelConfirmation.SetActive(true);
        difficulty = _selectedLevelConfirmation.text = "легкий";
    }
    private void OrdinaryLevelButtonDown()
    {
        _levelConfirmation.SetActive(true);
        difficulty = _selectedLevelConfirmation.text = "средний";
    }
    private void HardLevelButtonDown()
    {
        _levelConfirmation.SetActive(true);
        difficulty = _selectedLevelConfirmation.text = "сложный";
    }
    private void YesButtonDown()
    {
        _levelConfirmation.SetActive(false);    // пока что так. Главное что она запоминает уровень и сложность и отправляет в скрипт lobby_panel_view.
        // SceneManager.LoadScene(levelСounter);
    }
    private void NoButtonDown()
    {
        _levelConfirmation.SetActive(false);
    }
    private void ExitButtonDown()
    {
        _difficultyLevel.SetActive(false);
    }
    private void ExitLevelConirmationBattonDown()
    {
        _levelConfirmation.SetActive(false);
    }
}
