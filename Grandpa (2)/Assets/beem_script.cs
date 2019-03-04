using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beem_script : MonoBehaviour
{
    public float speed  ;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down /  speed);
        Destroy(gameObject, 15);
    }



    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "player2")
        {
           // Destroy(other.gameObject  );
           // Destroy(gameObject);
        }
        

        
        if (other.gameObject.tag == "player_")
        {
            Destroy(gameObject  );

        } 
         
    }

    
}

