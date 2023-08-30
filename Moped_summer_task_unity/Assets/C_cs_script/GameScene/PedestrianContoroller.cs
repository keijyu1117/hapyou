using UnityEngine;
using UnityEngine.SceneManagement;

public class PedestrianContoroller : MonoBehaviour
{
    public float speed;
    public float gravity;
    public bool nonVisibleAct;
   
    private Rigidbody2D rb = null;
    private SpriteRenderer sr= null;
    private bool rightTleftF = false;

    private bool aaa;

    // Start is called before the first frame update
    void Start()
    {
        aaa = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        int xVector = 1;

        if (sr.isVisible || nonVisibleAct)
        {
            aaa = true;

            if (rightTleftF)
            {
                xVector = 1;
                //transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                //transform.localScale = new Vector3(1, 1, 1);
            }
            rb.velocity = new Vector2(xVector * speed, -gravity);
        }
        else
        {
            rb.Sleep();
            if (aaa)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOverScene_001");
        }
    }
}
