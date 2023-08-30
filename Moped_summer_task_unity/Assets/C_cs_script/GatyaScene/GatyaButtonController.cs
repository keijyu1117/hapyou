using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GatyaButtonController : MonoBehaviour
{
    GameObject GatyaSystem;
    Button button;

    void Start()
    {
        GatyaSystem = GameObject.Find("GatyaSystem");
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    //ボタンがクリックされたとき
    void ButtonClick()
    {
        if(BikeDataSprict.CoinNum >= 10)
        {
            GatyaSystem.GetComponent<GatyaSystemScript>().PlayGatya();
            BikeDataSprict.CoinNum -= 10;
            Debug.Log("dekita");
        }
        else
        {
            Debug.Log("dekinakatta");
        }
    }
}
