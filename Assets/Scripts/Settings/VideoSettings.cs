using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class VideoSettings : MonoBehaviour
{
    private static readonly string SettingPref  = "QualitySettingPreference";
    private static readonly string ResolutionPref = "ResolutionPreference";
    private static readonly string FullscreenPref = "FullscreenPreference";
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown qualityDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRateRatio + "Hz";
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);

    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt(SettingPref, qualityDropdown.value);
        PlayerPrefs.SetInt(ResolutionPref, resolutionDropdown.value);
        PlayerPrefs.SetInt(FullscreenPref, System.Convert.ToInt32(Screen.fullScreen));
    }
    public void ExitSettings()
    {
        SaveSettings();
        Debug.Log("Successful saved settings");
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveSettings();
        }
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey(SettingPref))
            qualityDropdown.value = PlayerPrefs.GetInt(SettingPref);
        else
            qualityDropdown.value = 6; //number of menu items graphics quality

        if (PlayerPrefs.HasKey(ResolutionPref))
            resolutionDropdown.value = PlayerPrefs.GetInt(ResolutionPref);
        else
            resolutionDropdown.value = currentResolutionIndex;

        if (PlayerPrefs.HasKey(FullscreenPref))
            Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt(FullscreenPref));
        else
            Screen.fullScreen = true;
    }
}
