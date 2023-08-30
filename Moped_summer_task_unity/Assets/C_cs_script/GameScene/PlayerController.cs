using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Sprite[] BikeSprite; //インスペクターから編集できるバイクの画像変数

    static public int point = 20;//プレイヤーのポイント数を保持する変数
    public int redSignalPointDecrease = 2;
    public Text pointsText;//テキストオブジェクトをUnityエディタからアタッチ

    GameObject CoinMane;
    new Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    int WalkForce;
    float MaxSpeed;
    int JumpForce;
    bool isStopSign;
    bool isStop;

    void Start()
    {
        isStopSign = false;
        isStop = false;
        point = 20;
        spriteRenderer= GetComponent<SpriteRenderer>();
        this.rigidbody2D = GetComponent<Rigidbody2D>();
        WalkForce = 100;
        MaxSpeed = 1;
        JumpForce = 1000;
        spriteRenderer.sprite = BikeSprite[BikeImgController.BikeKey];
        CoinMane = GameObject.Find("CoinMane");

        if(BikeImgController.BikeKey == 0) 
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(-0.33f, -0.85f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(9.85f, 6.51f);
        }
        else if (BikeImgController.BikeKey == 1)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.18f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(10.49f, 6.51f);
        }
        else if (BikeImgController.BikeKey == 2)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.14f, -0.9f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(11.8f, 6.51f);
        }
        else if (BikeImgController.BikeKey == 3)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.65f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(10.47f, 6.24f);
        }
        else if (BikeImgController.BikeKey == 4)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.41f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(12.16f, 6.24f);
        }
        else if (BikeImgController.BikeKey == 5)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.41f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(11.65f, 6.24f);
        }
        else if (BikeImgController.BikeKey == 6)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.48f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(12.04f, 5.6f);
        }
        else if (BikeImgController.BikeKey == 7)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.48f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(11.77f, 4.91f);
        }
        else if (BikeImgController.BikeKey == 8)
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0.0f, -0.8f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(12.56f, 4.91f);
        }
    }

    void Update()
    {
        //Dキーでアクセル
        if (Input.GetKey(KeyCode.D) && rigidbody2D.velocity.y == 0)
        {
            if(MaxSpeed > rigidbody2D.velocity.x)
            {
                this.rigidbody2D.AddForce(transform.right * WalkForce);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            }
        }

        //スペースキーでジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(rigidbody2D.velocity.y == 0)
            {
                rigidbody2D.AddForce(transform.up * JumpForce);
            }
        }
        //一時停止の処理
        if (isStopSign)
        {
            if(Input.GetKeyUp(KeyCode.D))
            {
                isStop = true;
            }

        }
    }

    //他のオブジェクトに重なったとき
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //コインと衝突したとき
        if (collision.gameObject.CompareTag("Coin"))
        {
            CoinMane.GetComponent<CoinManager>().CoinEdit();
            Destroy(collision.gameObject);
        }

        //信号機と衝突した際ポイントを減らす
        if (collision.CompareTag("TrafficLight"))
        {
            TrafficLight trafficLight = collision.GetComponent<TrafficLight>();

            if (trafficLight != null && trafficLight)
            {
                DecreasePoints(redSignalPointDecrease);

                Debug.Log(point);
            }
        }

        //ClearFlagにぶつかったらクリアシーンに移行
        if (collision.CompareTag("Flag"))
        {
            SceneManager.LoadScene("ClearScene");
        }

        //歩行者にぶつかったらゲームオーバーシーンに移行
        if (collision.CompareTag("Pedestrian"))
        {
            SceneManager.LoadScene("GameOverScene_001");
        }

        //水たまりに入ったら減速
        if (collision.CompareTag("puddle"))
        {
            WalkForce = 5;
        }

        //マイナスオブジェクトに当たった場合
        if (collision.CompareTag("mainasu"))
        {
            DecreasePoints(2);
        }

        //一時停止標識
        if (collision.CompareTag("stopsign"))
        {
            isStopSign = true;
        }
        
        if (collision.gameObject.CompareTag("enemysika"))
         {
            Debug.Log("aaa");
                SceneManager.LoadScene("GameOverScene_001");
        }
       
    }

    //オブジェクトから離れたとき
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("puddle"))
        {
            WalkForce = 10;
        }
        if (collision.CompareTag("stopsign"))
        {
            isStopSign = false;
            if (!isStop)
            {
                DecreasePoints(2);
            }
            isStop = false;
        }
    }




    //ポイント増減アドミニストレータ
    public void InCreasePoints(int amount)
    {
        point += amount;

        //ポイントリフレクション
        pointsText.text = point.ToString(); //ポイント数をテキストに反映
    }

    public void DecreasePoints(int amount)
    {
        point -= amount;

        //ポイントリフレクション
        pointsText.text =  point.ToString(); //ポイント数をテキストに反映
    }
}
