using UnityEngine;
using UnityEngine.UI;

public class LeftButtonManager : MonoBehaviour
{
    GameObject Image;
    Button button;

    void Start()
    {
        Image = GameObject.Find("BikeImage");
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    //�{�^�����N���b�N���ꂽ�Ƃ��o�C�N�C���[�W�̃o�C�N�`�F���W�֐����Ăяo��
    void ButtonClick()
    {
        Image.GetComponent<BikeImgController>().BikeChange(false);  //���{�^�������������false
    }
}
