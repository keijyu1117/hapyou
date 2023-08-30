using System;
using UnityEngine;

public struct BikeData
{
    public String[] BikeName;
    public bool[] isGetBike;
}

public class BikeDataSprict : MonoBehaviour
{
    static public BikeData bikeData = new BikeData();
    static public int CoinNum;
    void Start()
    {
        CoinNum = 0;

        bikeData.BikeName = new String[9];
        bikeData.BikeName[0] = "Cyoinori";
        bikeData.BikeName[1] = "GIORNO";
        bikeData.BikeName[2] = "zoomer";
        bikeData.BikeName[3] = "YB50";
        bikeData.BikeName[4] = "cb125r";
        bikeData.BikeName[5] = "CB250T_HAWK";
        bikeData.BikeName[6] = "cbr1000r";
        bikeData.BikeName[7] = "DragStar400";
        bikeData.BikeName[8] = "RoadKingSpecial";

        bikeData.isGetBike = new bool[9];
        bikeData.isGetBike[0] = true;
        bikeData.isGetBike[1] = false;
        bikeData.isGetBike[2] = false;
        bikeData.isGetBike[3] = false;
        bikeData.isGetBike[4] = false;
        bikeData.isGetBike[5] = false;
        bikeData.isGetBike[6] = false;
        bikeData.isGetBike[7] = false;
        bikeData.isGetBike[8] = false;
    }
}
