using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButtonController : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
