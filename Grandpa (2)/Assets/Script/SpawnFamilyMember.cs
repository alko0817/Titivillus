using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFamilyMember : MonoBehaviour
{



    public Rigidbody2D FamilyMember;
    public Rigidbody2D ufo;
    public Rigidbody2D ufoShooter;

    public float count_f_member = 0;
    public float FamilyMemberSpeed = 9.0f;
    public float waitTime;
    public float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * 2);


        if (time >= 0.0f)
        {
            time -= Time.deltaTime;
        }
        if (time <= 4)
        {

            SpawnAlians1();
 
        }
        if (time <= 2)
        {

            SpawnAlians2();
        }


        void SpawnAlians1()
        {

            count_f_member += 1;
            if (count_f_member < 3)
            {  
            Rigidbody2D f_m = Instantiate(FamilyMember, transform.position, Quaternion.identity) as Rigidbody2D;
            f_m.velocity = transform.TransformDirection(Vector2.left * 1);

            // f_m.AddForce(new Vector2(Random.Range(-100, 100) *Time.deltaTime * FamilyMemberSpeed,
            //  Random.Range(-100, 100) * Time.deltaTime * FamilyMemberSpeed));

            time -= 2;
        }

        }
        void SpawnAlians2()
        {
         /*   Rigidbody2D u_f_o = Instantiate(ufo, ufoShooter.transform.position, Quaternion.identity) as Rigidbody2D;
            ufo.velocity = transform.TransformDirection(Vector2.left * FamilyMemberSpeed * Time.deltaTime);

            u_f_o.AddForce(new Vector3(Random.Range(-100, 100) * FamilyMemberSpeed,
           Random.Range(-100, 100) * Time.deltaTime * FamilyMemberSpeed )); */
            time = waitTime;
             

        }





    }
}
