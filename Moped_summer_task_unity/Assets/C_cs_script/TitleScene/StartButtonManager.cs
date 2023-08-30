using UnityEngine;
using UnityEngine.UI;

public class StartButtonManager : MonoBehaviour
{ 
    GameObject Manager;
    Button button;
    AudioSource audioSource;
    bool timerStart = false;
    float timer = 0;


    void Start()
    {
        Manager = GameObject.Find("SceneManager");
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();


    }
    private void Update()
    {
        if (timer > 0.5f)
        {
            Manager.GetComponent<TitleSceneManager>().SceneLoad();
        }


        //timer
        if (timerStart)
        {
            timer += Time.deltaTime;
        }
    }

    //ボタンがクリックされたときシーンマネージャーのロードシーンを呼び出す
    void ButtonClick()
    {
        audioSource.Play();
        timerStart = true;
    }
}
