using UnityEngine;
using UnityEngine.SceneManagement;
public class GatyaSystemScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("HomeScene");
        }
    }

    public void PlayGatya()
    {
        int rnd = 0;
        rnd = Random.Range(0, 9);
        BikeDataSprict.bikeData.isGetBike[rnd] = true;
        Debug.Log(rnd);
    }
}
