using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Destroy(gameObject, 4);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet1")
        {
          //  Destroy(gameObject  );
            Destroy(collision.gameObject);
        }
    }


}
