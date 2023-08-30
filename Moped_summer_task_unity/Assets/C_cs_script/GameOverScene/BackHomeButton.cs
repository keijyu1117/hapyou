using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackHomeButton : MonoBehaviour
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
        SceneManager.LoadScene("HomeScene");
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
