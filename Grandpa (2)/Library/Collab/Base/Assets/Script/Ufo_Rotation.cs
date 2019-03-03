using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_Rotation : MonoBehaviour
{
    public Rigidbody2D uf_o;
    public Transform f_m_1;
    public float speed = 100;
     
    // Start is called before the first frame update
    void Start()
    {
       // f_m_1 = GameObject.FindGameObjectWithTag("F_m").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * 2);
       
        transform.Translate(Vector3.down  );
    }



    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet1")
        {
            Destroy(gameObject , 3  );
            Destroy(other.gameObject );
        }

        




        /*  if (other.gameObject.tag == "Ufo")
          {

              Destroy(other.gameObject);
          }*/
    }

 



}
