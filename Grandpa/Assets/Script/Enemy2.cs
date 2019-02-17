using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public Rigidbody2D Enm2;
    public float speed2 = 0.5f;

    public float bulletNumbersEnemy2 = 0;

    // public string tagName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Enm2.AddForce(new Vector3(Random.Range(-100, 100) * speed2 * Time.deltaTime,
           Random.Range(-100, 100) * 4 * Time.deltaTime, 0));

        Destroy(gameObject, 4);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "Bullet1"  )
        {
          //  Destroy(other.gameObject);
            bulletNumbersEnemy2++;
            if (bulletNumbersEnemy2 == 10)
            {

                Destroy(gameObject);

            }


         }


      




    }

}



