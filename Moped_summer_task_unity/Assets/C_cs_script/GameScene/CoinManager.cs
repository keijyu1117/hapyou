using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text CoinText;

    void Start()
    {
        CoinText.text = "Coin:" + BikeDataSprict.CoinNum.ToString();
    }

    //�R�C���̐����ꑫ����text��ҏW����
    public void CoinEdit()
    {
        BikeDataSprict.CoinNum += 1;
        CoinText.text = "Coin:" + BikeDataSprict.CoinNum.ToString();
    }
}