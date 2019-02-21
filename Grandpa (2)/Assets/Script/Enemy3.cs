using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public Rigidbody2D Enm3;
    public float speed3 = 2f;
    public float bulletNumbersEnemy3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enm3.AddForce(new Vector3(Random.Range(-100, 100) * speed3 ,
           Random.Range(-100, 100) * 4 * Time.deltaTime, 0));
        Destroy(gameObject, 6);
    }


    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Bullet1")
        {
            Destroy(other.gameObject);
            bulletNumbersEnemy3++;
            if (bulletNumbersEnemy3 == 2)
            {

                Destroy(gameObject);

            }
 
        }







    }
}
