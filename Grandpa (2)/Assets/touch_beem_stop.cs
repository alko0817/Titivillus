using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_beem_stop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Beem")
        {

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
