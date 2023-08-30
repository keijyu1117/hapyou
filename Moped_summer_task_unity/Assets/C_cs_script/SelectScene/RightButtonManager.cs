using UnityEngine;
using UnityEngine.UI;

public class RightButtonManager : MonoBehaviour
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
        Image.GetComponent<BikeImgController>().BikeChange(true);   //右ボタンだから引数はtrue
    }
}
