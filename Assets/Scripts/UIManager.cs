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
    
    private static UIManager m_instance; //�̱����� �Ҵ�� ����
    public TextMeshProUGUI CountsText;//�������ī��Ʈ ǥ�� �ؽ�Ʈ    
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
        CountsText.text = "����Ƚ�� : " + counts;        
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
