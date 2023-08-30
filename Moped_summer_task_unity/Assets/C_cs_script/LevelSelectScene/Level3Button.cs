using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3Button : MonoBehaviour
{
    Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        SceneManager.LoadScene("GameScene3");
    }
}
