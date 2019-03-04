using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Is_Trigger : MonoBehaviour
{

    public Rigidbody2D ufo_instantiate;
    public GameObject ufo_position ;
    public float count_wait_for_spawn_ufo = 0;
    public int count = 5;
    bool kill_f_m_all_f = false;
    public RawImage r1;
    public bool move_it_up = false;
    /*public RawImage r1;
    public RawImage r2;
    public RawImage r3;
    public RawImage r4;
    public RawImage r5;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (move_it_up)
        {

            transform.Translate(Vector3.up * 2);
        }
        // transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * 1);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
         

            if (other.gameObject.tag == "Beem")
        {
            count_wait_for_spawn_ufo += 1;

            // if (count_wait_for_spawn_ufo > 20)
            // {  

            // Text_Score.Score -= 1;

            move_it_up = true;
            Destroy(gameObject, 4);
            Destroy(other.gameObject);
            Destroy(r1.gameObject , 4 );



            Text_Score.Score -= 1;
            
            //  Destroy(gameObject.tag = "F_m");
            //  Destroy(collision.gameObject, 15);


           


            if (Text_Score.Score <=0)
            {
                SceneManager.LoadScene(2);
            }

            //  count_wait_for_spawn_ufo = 0;

        }
    }

    
     
}
  
