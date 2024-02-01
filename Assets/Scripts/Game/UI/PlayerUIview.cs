using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIview : MonoBehaviour
{
    [SerializeField] private Text _goldValue;
    [SerializeField] private Slider _hpSlider;


    [SerializeField] private Image _levelProgressBar;
    [SerializeField] private TextMeshProUGUI _levelProgressText;


    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {

    }

    public void SetGoldValue(int value)
    {
        _goldValue.text = value.ToString();
    }
    public void SetHpValue(float value)
    {
        _hpSlider.value = value;
    }
    public void SetLevelProgress(float value)
    {
        _levelProgressBar.fillAmount = value;
        _levelProgressText.text = value.ToString();
    }
}
