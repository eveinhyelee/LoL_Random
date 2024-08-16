using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance
    {
        get 
        {
            if (m_instance == null)
            { 
                m_instance =FindObjectOfType<UIManager>();
            }
            return m_instance;
        }
    }
    
    private static UIManager m_instance; //싱글턴이 할당될 변수
    public TextMeshProUGUI CountsText;//랜덤재생카운트 표시 텍스트    
    private int counts = 0;  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        

    }

    public void AddCounts()
    {       
        counts ++;
        CountsText.text = "랜덤횟수 : " + counts;        
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(1);       
    }
    public void BeforeGame()
    {
        SceneManager.LoadScene(0);        
    }
}
