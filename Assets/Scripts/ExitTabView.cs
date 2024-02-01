using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitTabView : MonoBehaviour
{
    [SerializeField] private Button _yesBtn;
    [SerializeField] private Button _noBtn;


    private void OnEnable()
    {
        _yesBtn.onClick.AddListener(yesBtnDown);
        _noBtn.onClick.AddListener(noBtnDown);
    }


    private void yesBtnDown()
    {
        Application.Quit();    // закрыть приложение
    }

    private void noBtnDown()
    {
        transform.gameObject.SetActive(false);
    }
}
