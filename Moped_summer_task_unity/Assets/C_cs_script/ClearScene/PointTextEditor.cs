using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTextEditor : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "Point:" + BikeDataSprict.CoinNum.ToString();
    }
}
