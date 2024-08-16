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

    void Start() //����Ƽ�����Ͱ� �ƴ϶�� 0.1���Ŀ� SetResolution ȣ��
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
        resolutions = new List<Resolution>(Screen.resolutions); //������� �⺻�ػ�
        resolutions.Reverse(); //���峷�� �ε�����

        if (is16v9) //�ػ� ��ü �������� 16/9�ΰ͸� �����ü��ִ� ���ǹ�
        {
            resolutions = resolutions.FindAll(x => (float)x.width / x.height == 16f / 9f);
        }

        // �ɼǸ���Ʈ ǥ��
        List<string> options = new List<string>();
        foreach (var resolution in resolutions)
        {
            string option = $"{resolution.width} x {resolution.height}";
            options.Add(option);
        }

        resolutionDropdown.ClearOptions(); //�����ۼ� �ɼǻ���
        resolutionDropdown.AddOptions(options); //ã�� �ɼ��߰�

        resolutionDropdown.value = ResolutionInDex; // �ε�������??
        fullscreenToggle.isOn = IsFullscreen; // Ǯ��ũ��

        resolutionDropdown.RefreshShownValue(); //�����Ѱ��� ǥ�� �ɼ� �ֵ���
        

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
