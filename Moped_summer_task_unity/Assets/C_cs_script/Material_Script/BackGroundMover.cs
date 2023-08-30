using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BackGroundMover : MonoBehaviour
{

    private const float k_maxLength = 1f;
    private const string k_propName = "_MainTex";

    [SerializeField]
    private Vector2 m_offsetSpeed;
    private Material m_material;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        if (GetComponent<Image>() is Image i)
        { 
            m_material = i.material;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            m_offsetSpeed = new Vector2(0.1f, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            m_offsetSpeed = new Vector2(0.0001f,0); 
        }
        if (m_material)
        {
            //ｘとｙの値が0～1でリピートするようにする
            var x = Mathf.Repeat(Time.time * m_offsetSpeed.x, k_maxLength);
            var y = Mathf.Repeat(Time.time * m_offsetSpeed.y, k_maxLength);
            var offset = new Vector2(x, y);
            m_material.SetTextureOffset(k_propName, offset);
        }
    }

    private void OnDestroy()
    {
        //ゲームを辞めた後マテリアルのOffsetを戻しておく
        if (m_material)
        {
            m_material.SetTextureOffset(k_propName, Vector2.zero);
        }
    }
}
