using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] bool is16v9;
    [SerializeField] Toggle fullscreenToggle;
    [SerializeField] TMP_Dropdown resolutionDropdown;

    List<Resolution> resolutions;

    public int ResolutionInDex
    {
        get => PlayerPrefs.GetInt("ResolutionInDex", 0);
        set => PlayerPrefs.SetInt("ResolutionInDex", value);
    }

    public bool IsFullscreen
    {
        get => PlayerPrefs.GetInt("IsFullscreen", 1) == 1;
        set => PlayerPrefs.SetInt("IsFullscreen", value ? 1 : 0);
    }

    void Start() //유니티에디터가 아니라면 0.1초후에 SetResolution 호출
    {
#if !UNITY_EDITOR
        Invoke(nameof(SetResolution),0.1f);
#endif
    }

    void Update()
    {
        
    }

    public void SetResolution() 
    {
        resolutions = new List<Resolution>(Screen.resolutions); //모니터의 기본해상도
        resolutions.Reverse(); //가장낮은 인덱스로

        if (is16v9) //해상도 전체 비율에서 16/9인것만 가져올수있는 조건문
        {
            resolutions = resolutions.FindAll(x => (float)x.width / x.height == 16f / 9f);
        }

        // 옵션리스트 표시
        List<string> options = new List<string>();
        foreach (var resolution in resolutions)
        {
            string option = $"{resolution.width} x {resolution.height}";
            options.Add(option);
        }

        resolutionDropdown.ClearOptions(); //기존작성 옵션삭제
        resolutionDropdown.AddOptions(options); //찾은 옵션추가

        resolutionDropdown.value = ResolutionInDex; // 인덱스대입??
        fullscreenToggle.isOn = IsFullscreen; // 풀스크린

        resolutionDropdown.RefreshShownValue(); //대입한것이 표기 될수 있도록
        

    }

    public void DropdownOptionChanged(int resolutionIndex) 
    {
        ResolutionInDex = resolutionIndex;
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);        
    }

    public void FullscreenToggleChanged(bool isFull)
    { 
        IsFullscreen = isFull;
        Screen.fullScreen = isFull;
    }    
}
