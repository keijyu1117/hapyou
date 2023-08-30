using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class BikeImgController : MonoBehaviour
{
    public GameObject Batu;
    public Sprite[] BikeImg;
    public string[] text;
    static public int BikeKey;  //選択するバイクのキー
    public Text TextUI;
    UnityEngine.UI.Image image; 

    void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>();
        BikeKey = 0;
        Batu.SetActive(false);
        TextUI.text = text[0];
    }

    //描画するバイクを変更する
    public void BikeChange(bool isRight)
    {
        if(isRight)         //右ボタンをクリックしたらこっち
        {
            if (BikeKey == BikeImg.Length - 1)
            {
                BikeKey = 0;
            }
            
            else
            {
                BikeKey++;
            }
        }
        else if (!isRight)  //左ボタンをクリックしたらこっち
        {
            if(BikeKey == 0)
            {
                BikeKey = BikeImg.Length - 1;
            }
            else
            {
                BikeKey--;
            }
        }
        image.sprite= BikeImg[BikeKey];
        TextUI.text = text[BikeKey];
        if (BikeDataSprict.bikeData.isGetBike[BikeKey])
        {
            Batu.SetActive(false);
        }
        else
        {
            Batu.SetActive(true);
        }
    }
}
