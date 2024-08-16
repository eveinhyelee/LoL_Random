using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class RandomImg : MonoBehaviour
{
    public Sprite[] sprites; //�����̹����������
    public Image[] redSpace; //�����̹��� ���԰��� 14��
    public Image[] blueSpace; //�����̹��� ���԰��� 14��
    public bool isSame = false;

    private void Awake()
    {
        
    }

    public void randomNumber()
    {
        //14���� �����
        for (int i = 0; i < redSpace.Length; i++)
        {
            int randomNumber = Random.Range(1, 167);
            // �����ϰ� i ��° ���԰����� ������� �����̹����� �־���            

            for (int j = 0; j < redSpace.Length; j++)
            {    
                if (i != j && redSpace[i].sprite == redSpace[j].sprite) // �ٸ������ ���� �̹����ϰ��
                {
                    randomNumber = Random.Range(1, 167);                    
                    Debug.Log("���� �緣�� ����");               
                }
                else if (i != j && redSpace[i].sprite != redSpace[j].sprite) // �ٸ� ����� �ٸ� �̹����ϰ��
                {                    
                    redSpace[i].sprite = sprites[randomNumber - 1];
                }
                else // ���� ����� �����̹������
                {                    
                    redSpace[i].sprite = sprites[randomNumber - 1];
                }
            }            
        }
    }
    // GetComponent<Image>().sprite = sprites[randomNumber - 1]; �̹��������ϱ�!<1����>  


    public void randomNumberA()
    {
        //14���� �����
        for (int i = 0; i < blueSpace.Length; i++)
        {
            int randomNumber = Random.Range(1, 167);
            // �����ϰ� i ��° ���԰����� ������� �����̹����� �־���

            for (int j = 0; j < blueSpace.Length; j++)
            {
                if (i != j && blueSpace[i].sprite == blueSpace[j].sprite) // �ٸ������ ���� �̹����ϰ��
                {
                    randomNumber = Random.Range(1, 167);
                    Debug.Log("��� �緣�� ����");
                }
                else if (i != j && blueSpace[i].sprite != blueSpace[j].sprite) // �ٸ� ����� �ٸ� �̹����ϰ��
                {
                    blueSpace[i].sprite = sprites[randomNumber - 1];
                }
                else // ���� ����� �����̹������
                {
                    blueSpace[i].sprite = sprites[randomNumber - 1];
                }
            }            
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }
}
