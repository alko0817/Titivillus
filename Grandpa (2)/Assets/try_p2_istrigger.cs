using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class try_p2_istrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag== "Beem")
        {
            Destroy(gameObject);
            Destroy(other.gameObject); 

        }
    }
}
