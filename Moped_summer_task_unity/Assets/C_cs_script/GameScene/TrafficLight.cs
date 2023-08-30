using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrafficLight : MonoBehaviour
{
    public GameObject[] Lights;//�F���Ƃ̃��C�g���i�[����z��

    public float redLightDuration = 5.0f;//�ԐM���̕\������

    public float yellowLightDuration = 2.0f;//���M���̕\������

    public float greenLightDuration = 5.0f;//�M���̕\������

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
            SetTrafficLightColor(0);//�ԐM��
            yield return new WaitForSeconds(redLightDuration);

            SetTrafficLightColor(1);//���M��
            yield return new WaitForSeconds(yellowLightDuration);

            SetTrafficLightColor(2);//�M��
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
