using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    
    void Update()
    {
        //�X�y�[�X�������ꂽ�Ƃ��V�[�����[�h�֐����Ăяo��
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneLoad();
        }
    }

    //�o�C�N�I���V�[�������[�h
    public void SceneLoad()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
