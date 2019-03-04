using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{



    public float playerSpeed = 1000f;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public static float bulletCounter = 0;
    public Rigidbody2D bullet;
    public Rigidbody2D rigidbody2D;
    public Rigidbody2D bullet2;
    public bool left_true = false;
    public bool right_true = false;
    public float scale = 0;
    public float cooldownTime = 10;
    private float nextcooldownTime = 0;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    IEnumerator PowerUpTimer()
    {
        yield return new WaitForSeconds(5);
        playerSpeed = 2.0f;
    }

  

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && speed > 5)
        {
            Destroy(other.gameObject);
        }
    }

    void Update()
    {


        float h = Input.GetAxis("Horizontal") * playerSpeed;
        float v = Input.GetAxis("Vertical") * playerSpeed;
        transform.Translate(h, v, 0);


        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector2(scale , scale);
            
        }

        if (Time.time > nextcooldownTime)
        {
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                FindObjectOfType<AudioManager>().Play("boost");
                playerSpeed = 4.0f;
                StartCoroutine("PowerUpTimer");
                nextcooldownTime = Time.time + cooldownTime;
            }
        }



            if (Input.GetKey("right"))
        {


            right_true = true;
             
            transform.localScale = new Vector2(scale, scale);


        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector2(-scale, scale);
        }

        if (Input.GetKey("left"))
        {
            transform.localScale = new Vector2(-scale, scale);
            left_true = true;

        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            speed = 10;
            StartCoroutine("PowerUpTimer");
        }


        // if (Input.GetTouch("space")) { 
        /*
                    if (Input.GetButtonDown("Fire1"))
                    {
                        Rigidbody2D bomb = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                        bomb.velocity = transform.TransformDirection(Vector3.left * 100);  // ballSpeed * ballPower);
                        bulletCounter++;
                        print(bulletCounter);
                    }




                // if (Input.GetTouch("space")) { 

                        if (Input.GetButtonDown("Fire1"))
                        {

                            Rigidbody2D bomb = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                        bomb.velocity = transform.TransformDirection(Vector3.right * 100);  // ballSpeed * ballPower);
                        bulletCounter++;
                        print(bulletCounter);

                    }
                    */
      
        // make speed slowly
        if (Text_Score.Score == 4)
        {
              
        }



    }
         void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }
    }
 
/*
public SpriteRenderer FLIP_PLAYER;
public  float playerSpeed = 2.0f;
public float ballSpeed = 2.0f;
public float ballPower = 4; 
public Rigidbody2D bullet;
public static float bulletCounter = 0; 
// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    float h = Input.GetAxis("Horizontal")  / playerSpeed;
    float v = Input.GetAxis("Vertical") / playerSpeed ;
    transform.Translate(h, v, 0);





     if (Input.GetButtonDown("Fire1"))
    {
       // if (Input.GetTouch("space")) { 
             Rigidbody2D bomb = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
        bomb.velocity = transform.TransformDirection(Vector3.right * 100);  // ballSpeed * ballPower);
            bulletCounter++;
            print(bulletCounter);

     }



}

}*/
