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
    public Sprite[] sprites; //랜덤이미지저장공간
    public Image[] redSpace; //랜덤이미지 대입공간 14개
    public Image[] blueSpace; //랜덤이미지 대입공간 14개
    public bool isSame = false;

    private void Awake()
    {
        
    }

    public void randomNumber()
    {
        //14개에 저장소
        for (int i = 0; i < redSpace.Length; i++)
        {
            int randomNumber = Random.Range(1, 167);
            // 랜덤하게 i 번째 대입공간에 순서대로 랜덤이미지를 넣어줌            

            for (int j = 0; j < redSpace.Length; j++)
            {    
                if (i != j && redSpace[i].sprite == redSpace[j].sprite) // 다른저장소 같은 이미지일경우
                {
                    randomNumber = Random.Range(1, 167);                    
                    Debug.Log("레드 재랜덤 실행");               
                }
                else if (i != j && redSpace[i].sprite != redSpace[j].sprite) // 다른 저장소 다른 이미지일경우
                {                    
                    redSpace[i].sprite = sprites[randomNumber - 1];
                }
                else // 같은 저장소 기존이미지출력
                {                    
                    redSpace[i].sprite = sprites[randomNumber - 1];
                }
            }            
        }
    }
    // GetComponent<Image>().sprite = sprites[randomNumber - 1]; 이미지대입하기!<1개씩>  


    public void randomNumberA()
    {
        //14개에 저장소
        for (int i = 0; i < blueSpace.Length; i++)
        {
            int randomNumber = Random.Range(1, 167);
            // 랜덤하게 i 번째 대입공간에 순서대로 랜덤이미지를 넣어줌

            for (int j = 0; j < blueSpace.Length; j++)
            {
                if (i != j && blueSpace[i].sprite == blueSpace[j].sprite) // 다른저장소 같은 이미지일경우
                {
                    randomNumber = Random.Range(1, 167);
                    Debug.Log("블루 재랜덤 실행");
                }
                else if (i != j && blueSpace[i].sprite != blueSpace[j].sprite) // 다른 저장소 다른 이미지일경우
                {
                    blueSpace[i].sprite = sprites[randomNumber - 1];
                }
                else // 같은 저장소 기존이미지출력
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
