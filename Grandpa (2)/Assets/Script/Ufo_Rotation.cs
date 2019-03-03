using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo_Rotation : MonoBehaviour
{
    public Rigidbody2D uf_o;
    public Transform f_m_1;
    public float speed = 100;
    public bool stop_moving = false ;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {
       // f_m_1 = GameObject.FindGameObjectWithTag("F_m").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (move==false )
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * 2);
            transform.Translate(Vector3.right * 2);
            transform.Translate(Vector3.down / 4);
        }
        

       
       // Destroy(gameObject, 35);

        if (stop_moving)
        {
            transform.Translate(Vector3.down * 0 );
        }

        StartCoroutine(fly());
       

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
         

            if (other.gameObject.tag == "Bullet1")
        {
            Destroy(gameObject , 3  );
            Destroy(other.gameObject );
        }

        if (other.gameObject.tag == "player_")
        {
            Destroy(gameObject );
          //  Destroy(other.gameObject);
        }


        if (other.gameObject.tag == "Beem_position")
        {
         //   Destroy(gameObject);
            stop_moving = true;
            move = true;
            //  Destroy(other.gameObject);
        }




        /*  if (other.gameObject.tag == "Ufo")
          {

              Destroy(other.gameObject);
          }*/
    }
    IEnumerator fly()
    {
        yield return new WaitForSeconds(20);
        if (stop_moving)
        {
            transform.Translate(Vector3.up * 2);
        }
    }
 



}
