using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject Player;
    Component PlayerCompornent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        PlayerCompornent = Player.GetComponent<Transform>();
        this.transform.position = new Vector3(PlayerCompornent.transform.position.x + 6, 0, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(PlayerCompornent.transform.position.x + 6, 0, this.transform.position.z);
    }
}
