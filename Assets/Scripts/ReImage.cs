using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReImage : MonoBehaviour
{
    public Sprite[] randomimages; // 보여주는 스프라이트 (자식 오브젝트) 173개
    //public GameObject[] spriteSpace; // 이미지를 담는 게임오브젝트 14개    

    public SpriteRenderer[] spriteRenderer;
    
    public SpriteRenderer sprites;

    List<int> spriteRendereList;// 클릭한 버튼의 이미지 담는 저장소 14개
    

    // 저장소 초기화
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


    // 출력 버튼
    public void Apply()
    {
        // 보여주는 스프라이트 렌더러를 순차적으로 접근
        // 중복없이 실행하기
        
        //int randomIndex = Random.Range(0, randomimages.Length); //173   
        

        for (int i = 0; i < spriteRenderer.Length; i++)
        {
            int ran = Random.Range(0, randomimages.Length - i); //173

            randomimages[ran] = randomimages[i];

            // spriteRendereList = randomimages[ran];

            // 클릭 이미지 저장소 비우기 (초기화)
            // spriteRendereList.Clear();

            Debug.Log(i + " 번째에" + ran +  "이미지를 출력했습니다");
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
