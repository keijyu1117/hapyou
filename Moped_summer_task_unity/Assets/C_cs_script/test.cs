using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //順番を制御したいときに使う
    private void Init()
    {
       
    }

    //OnEnebleより前に呼び出される（どうしても優先したいものがある場合だけここに書く）
    private void Awake()
    {
        //早くシーンの初期化

    }
    
    //Resetより前にオブジェクトが有効になるたびに呼び出される（表示（OnEnable,Start)→非表示→表示（OnEnable）)
    private void OnEnable()
    {
        //シーンが有効になった

    }

    //Startより前に呼び出される
    private void Reset()
    {
        //シーンが追加やリセットされた

    }

    //最初のフレームが更新される前に Start が呼び出されます
    void Start()
    {
        //シーンの初期化

    }

    //Update はフレームごとに 1 回呼び出されます
    void Update()
    {
        //シーンの更新
    }

    //LateUpdateはUpdateの後に呼び出されます
    void LateUpdate()
    {
     
    }
}
