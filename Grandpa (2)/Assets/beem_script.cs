using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beem_script : MonoBehaviour
{
    public float speed = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(blip());
        transform.Translate(Vector3.down * Time.deltaTime * speed);
      //  Destroy(gameObject, 30);
    }




    public void OnCollisionEnter2D(Collision2D other)
    {
         if  (other.gameObject.tag == "f_solution" )
            {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("abd");

        }
        if (other.gameObject.tag == "player2")
        {
            Destroy(other.gameObject  );
            FindObjectOfType<AudioManager>().Play("abd");

        }


         if (other.gameObject.tag == "beem_position6")
        {
            Destroy(gameObject );

        } 

    }
    IEnumerator blip()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject , 10);
    }

    
}

