using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{


    public float speedTime = 0.5f;

    public float EnemySpeed1 = 2;
    public float waitTime;
    public float time;
    public float bulletCounterEnemies = 0;
    public Rigidbody2D Enemy1;
    public Rigidbody2D Enemy2;
    public Rigidbody2D Enemy3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0.0f)
        {
            time -= Time.deltaTime;
        }
        if (time <= 10)
        {
            SpawnEnemy1();
        }


        if (time <= 5)
        {
            SpawnEnemy2();
        }

        if (time <= 2)
        {
            SpawnEnemy3();
        }



        void SpawnEnemy1()
        {

            Rigidbody2D bomb1 = Instantiate(Enemy1, transform.position, Quaternion.identity) 
                as Rigidbody2D;
            bomb1.velocity = transform.TransformDirection
                (Vector3.left * speedTime * Time.deltaTime);

            
          //  Destroy(bomb1, 7);
          //  bomb1.tag = "Enemy1";
          // ..............................

          //  bomb1.AddForce(new Vector3(Random.Range(-100, 100) * Time.deltaTime * 2,
           //     Random.Range(-100, 100) * Time.deltaTime * 3, 0));

            //  bulletCounterEnemies++;
            time -= 5;


        }
        void SpawnEnemy2()
        {


            Rigidbody2D bomb2 = Instantiate(Enemy2, transform.position, Quaternion.identity)
                as Rigidbody2D;
            bomb2.velocity = transform.TransformDirection(Vector3.left * 3 * Time.deltaTime);

           // bomb2.AddForce(new Vector3(Random.Range(-100, 100) * Time.deltaTime * 3,
             //   Random.Range(-100, 100) * Time.deltaTime * 3, 0));

            //  bulletCounterEnemies++;
            time -= 2;



        }


        void SpawnEnemy3()
        {  
        Rigidbody2D bomb3 = Instantiate(Enemy3, transform.position, Quaternion.identity) as Rigidbody2D;
        bomb3.velocity = transform.TransformDirection(Vector3.left * 3 *Time.deltaTime);

       // bomb3.AddForce(new Vector3(Random.Range(-30, 30) * Time.deltaTime * 3, 0, 0));

       // bulletCounterEnemies++;
        time = waitTime;

    }
    }
}
 
