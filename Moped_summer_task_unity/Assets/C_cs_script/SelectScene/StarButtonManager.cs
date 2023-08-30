using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarButtonManager : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        if (BikeDataSprict.bikeData.isGetBike[BikeImgController.BikeKey])
        {
            SceneManager.LoadScene("LevelSelectScene");
        }
    }
}
