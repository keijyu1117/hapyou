using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTxtEditor : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "Coin:" + PlayerController.point.ToString();
        
    }
}
