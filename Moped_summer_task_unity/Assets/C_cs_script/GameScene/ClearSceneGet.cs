using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneGet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("ClearScene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
               

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
