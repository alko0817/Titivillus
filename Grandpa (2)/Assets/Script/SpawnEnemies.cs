using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public Rigidbody2D Alians1;
    public float AlianSpeed = 2.0f;
    public float waitTime;
    public float time;
    public float count_Alians = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0.0f)
        {
            time -= Time.deltaTime;
        }
        if (time < 2)
        {

            SpawnAlians1();
        }
        void SpawnAlians1()
        {
            // count_Alians += 1;
            count_Alians = 1;
            if (count_Alians > 0)
            { 

            Rigidbody2D alians1 = Instantiate(Alians1, transform.position, Quaternion.identity) as Rigidbody2D;
            count_Alians = 0;
            // Alians1.velocity = transform.TransformDirection(Vector3.left * AlianSpeed * Time.deltaTime);

            /*  alians1.AddForce(new Vector3(Random.Range(-100, 100) * Time.deltaTime * AlianSpeed,
             Random.Range(-100, 100) * Time.deltaTime * AlianSpeed, 0));*/

            time = waitTime;
        }
            //    count_Alians = 0;

        }

    



            //  bulletCounterEnemies++;*/
        }
    }
 
