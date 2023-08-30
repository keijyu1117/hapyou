using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    
    void Update()
    {
        //スペースが押されたときシーンロード関数を呼び出す
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneLoad();
        }
    }

    //バイク選択シーンをロード
    public void SceneLoad()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
