using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beem_position : MonoBehaviour
{
    public int reapeat = 10;
    public int time_start_spawn = 1;
    public GameObject beem; 
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies2", time_start_spawn, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemies()
    {





    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ufo")
        {

            
            Instantiate(beem, transform.position,
                transform.rotation);
          //   Destroy(other.gameObject , 8); 

        }
    }
}
  
