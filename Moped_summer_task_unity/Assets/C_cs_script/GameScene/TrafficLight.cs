using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrafficLight : MonoBehaviour
{
    public GameObject[] Lights;//色ごとのライトを格納する配列

    public float redLightDuration = 5.0f;//赤信号の表示時間

    public float yellowLightDuration = 2.0f;//黄信号の表示時間

    public float greenLightDuration = 5.0f;//青信号の表示時間

    private int currentLightIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLightCycle());
    }

    private IEnumerator TrafficLightCycle()
    {
        while (true)
        {
            SetTrafficLightColor(0);//赤信号
            yield return new WaitForSeconds(redLightDuration);

            SetTrafficLightColor(1);//黄信号
            yield return new WaitForSeconds(yellowLightDuration);

            SetTrafficLightColor(2);//青信号
            yield return new WaitForSeconds(greenLightDuration);

        }
    }

    public void SetTrafficLightColor(int index)
    {
        for (int i = 0; i < Lights.Length; i++)
        {
            Lights[i].SetActive(i == index);
        }

        currentLightIndex = index;
    }

}
