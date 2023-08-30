using UnityEngine;
using UnityEngine.SceneManagement;

public class aaaaaaa : MonoBehaviour
{
    public float speed;
    public bool nonVisibleAct;

    private Rigidbody2D rb = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity= new Vector2(speed,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOverScene_001");
        }
    }
}
