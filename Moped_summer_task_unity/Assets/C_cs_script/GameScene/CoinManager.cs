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

    //ƒRƒCƒ“‚Ì”‚ğˆê‘«‚µ‚Ätext‚ğ•ÒW‚·‚é
    public void CoinEdit()
    {
        BikeDataSprict.CoinNum += 1;
        CoinText.text = "Coin:" + BikeDataSprict.CoinNum.ToString();
    }
}