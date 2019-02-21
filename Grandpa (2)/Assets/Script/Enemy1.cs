using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Rigidbody2D Enm1;
    public float speed = 0.5f;
    public float bulletNumbers = 0;
    public float bulletNumbers2 = 0;

    // public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Destroy(gameObject , 2);

        // Enm1.AddForce(new Vector3(Random.Range(-100, 100) * speed * Time.deltaTime,
        //    Random.Range(-100, 100) * 4 * Time.deltaTime , 0));

        // Destroy(gameObject, 15); 
    }
    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Bullet1")
        {


            Destroy(other.gameObject);
            bulletNumbers++;

            if (bulletNumbers > 2)
            {  
            Destroy(gameObject);

           }


            print("collision");
        }


      





    }

}
     
    
 
