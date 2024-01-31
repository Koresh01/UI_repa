using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_panel_view : MonoBehaviour
{
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _effectsVolumeSlider;

    [SerializeField] private AudioSource musicAudio;
    [SerializeField] private AudioSource soundEffectAudio;

    private void OnEnable()
    {
        _musicVolumeSlider.onValueChanged.AddListener(musicSliderValueChanged);
        _effectsVolumeSlider.onValueChanged.AddListener(effectsSliderValueChanged);
    }
    private void OnDisable()
    {
        _musicVolumeSlider.onValueChanged.RemoveListener(musicSliderValueChanged);
        _effectsVolumeSlider.onValueChanged.RemoveListener(musicSliderValueChanged);
    }

    void musicSliderValueChanged(float arg)
    {
        musicAudio.volume = arg;
    }
    void effectsSliderValueChanged(float arg)
    {
        musicAudio.volume = arg;
    }

}
