using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_position_spawn : MonoBehaviour
{


    public Rigidbody2D bullet;
   // public GameObject bullet_position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D bomb = Instantiate(bullet,  transform.position,  transform.rotation) as Rigidbody2D;
            bomb.velocity = transform.TransformDirection(Vector3.right * 500);
            FindObjectOfType<AudioManager>().Play("shot"); // ballSpeed * ballPower);
           
          
        }

 

    }


   
}
