using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReImage : MonoBehaviour
{
    public Sprite[] randomimages; // �����ִ� ��������Ʈ (�ڽ� ������Ʈ) 173��
    //public GameObject[] spriteSpace; // �̹����� ��� ���ӿ�����Ʈ 14��    

    public SpriteRenderer[] spriteRenderer;
    
    public SpriteRenderer sprites;

    List<int> spriteRendereList;// Ŭ���� ��ư�� �̹��� ��� ����� 14��
    

    // ����� �ʱ�ȭ
    void Awake()
    {
        randomimages = GetComponentsInChildren<Sprite>();
        // spriteSpace = GetComponentsInChildren<GameObject>();
        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();
            
            //GetComponentsInChildren<SpriteRenderer>();
        spriteRendereList = new List<int>();        
        
    }

    public void AddRandomImage()
    {
        for (int sp = 0; sp < spriteRenderer.Length; sp++)
        {
            spriteRendereList.Add(sp);
        }

        //return Randomimages[Random.Range(0, spriteList.Count)];
    }


    // ��� ��ư
    public void Apply()
    {
        // �����ִ� ��������Ʈ �������� ���������� ����
        // �ߺ����� �����ϱ�
        
        //int randomIndex = Random.Range(0, randomimages.Length); //173   
        

        for (int i = 0; i < spriteRenderer.Length; i++)
        {
            int ran = Random.Range(0, randomimages.Length - i); //173

            randomimages[ran] = randomimages[i];

            // spriteRendereList = randomimages[ran];

            // Ŭ�� �̹��� ����� ���� (�ʱ�ȭ)
            // spriteRendereList.Clear();

            Debug.Log(i + " ��°��" + ran +  "�̹����� ����߽��ϴ�");
        }

        

        //SpriteSprites.sprite = Randomimages[randomIndex];
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
