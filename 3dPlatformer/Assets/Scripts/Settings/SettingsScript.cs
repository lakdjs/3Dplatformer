using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Dropdown _resolutionDropdown;
    [SerializeField] private TMPro.TMP_Dropdown _qualityDropdown;

    Resolution[] resolutions;
    public sbyte audioMixer;
    
    void Start()
    {
        _resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width
                  && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }

        _resolutionDropdown.AddOptions(options);
        _resolutionDropdown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
        
    }
   

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,
                  resolution.height, Screen.fullScreen);
    }


    public void SetQuality(int qualityIndex)
    {

        QualitySettings.SetQualityLevel(qualityIndex);

    }

    public void ExitGame()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference",
                   _qualityDropdown.value);
        PlayerPrefs.SetInt("ResolutionPreference",
                   _resolutionDropdown.value);
        PlayerPrefs.SetInt("FullscreenPreference",
                   System.Convert.ToInt32(Screen.fullScreen));
     
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        if (PlayerPrefs.HasKey("QualitySettingPreference"))
           _qualityDropdown.value =
                         PlayerPrefs.GetInt("QualitySettingPreference");
        else
            _qualityDropdown.value = 3;
        if (PlayerPrefs.HasKey("ResolutionPreference"))
            _resolutionDropdown.value =
                         PlayerPrefs.GetInt("ResolutionPreference");
        else
            _resolutionDropdown.value = currentResolutionIndex;
        if (PlayerPrefs.HasKey("FullscreenPreference"))
            Screen.fullScreen =
            System.Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference"));
        else
            Screen.fullScreen = true;
        
          
    }
}
