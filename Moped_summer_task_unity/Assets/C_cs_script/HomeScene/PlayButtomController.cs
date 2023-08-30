using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtomController : MonoBehaviour
{
    GameObject Manager;
    Button button;
    AudioSource audioSource;
    bool timerStart = false;
    float timer = 0;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (timer > 0.7f)
        {
            SceneManager.LoadScene("SelectScene");
        }


        //timer
        if (timerStart)
        {
            timer += Time.deltaTime;
        }
    }
    void ButtonClick()
    {
       audioSource.Play();
        timerStart = true;

    }
}
