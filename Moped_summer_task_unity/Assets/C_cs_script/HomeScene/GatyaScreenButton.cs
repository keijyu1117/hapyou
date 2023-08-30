using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GatyaScreenButton : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        SceneManager.LoadScene("GatyaScene");
    }
}
