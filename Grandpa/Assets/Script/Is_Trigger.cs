using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_Trigger : MonoBehaviour
{

    public Rigidbody2D ufo_instantiate;
    public GameObject ufo_position ;
    public float count_wait_for_spawn_ufo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            count_wait_for_spawn_ufo += 1;
            print("rr");
           // if (count_wait_for_spawn_ufo > 20)
           // {  
            Rigidbody2D ufo_1 = Instantiate(ufo_instantiate,
                ufo_position.transform.position
                , Quaternion.identity);

            Destroy(gameObject,8);
            Destroy(ufo_1.gameObject, 5);

            //  count_wait_for_spawn_ufo = 0;
        }
        }
    }
  
