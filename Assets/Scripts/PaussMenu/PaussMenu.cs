using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaussMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausseMenu;
    [SerializeField] private GameObject settings;

    [SerializeField] private Button continueButton;
    [SerializeField] private Button restartLevelButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button mainMenuButton;



    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && pausseMenu.activeSelf)
        {
            pausseMenu.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else if (Input.GetKeyUp(KeyCode.Escape))
        {
            pausseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnEnable()
    {
        continueButton.onClick.AddListener(ContinueGame);
        restartLevelButton.onClick.AddListener(ResetLevel);
        settingsButton.onClick.AddListener(Settings);
        mainMenuButton.onClick.AddListener(MainMenu);
    }
    private void OnDisable()
    {
        continueButton.onClick.RemoveListener(ContinueGame);
        restartLevelButton.onClick.RemoveListener(ResetLevel);
        settingsButton.onClick.RemoveListener(Settings);
        mainMenuButton.onClick.RemoveListener(MainMenu);
    }
   
    private void ContinueGame()
    {
        pausseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    private void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Settings()
    {
        settings.SetActive(true);
    }
    private void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

}
