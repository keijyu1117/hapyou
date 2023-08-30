using UnityEngine;
using UnityEngine.UI;

public class LeftButtonManager : MonoBehaviour
{
    GameObject Image;
    Button button;

    void Start()
    {
        Image = GameObject.Find("BikeImage");
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    //ボタンがクリックされたときバイクイメージのバイクチェンジ関数を呼び出す
    void ButtonClick()
    {
        Image.GetComponent<BikeImgController>().BikeChange(false);  //左ボタンだから引数はfalse
    }
}
