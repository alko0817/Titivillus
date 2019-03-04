using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger_3 : MonoBehaviour
{
    public RawImage r3;
    public bool move_it_up = false;
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
    }







    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Beem")
        {
            // if (count_wait_for_spawn_ufo > 20)
            // {  

            // Text_Score.Score -= 1;


            move_it_up = true;
            Destroy(gameObject, 4);
            Destroy(other.gameObject);
            Destroy(r3.gameObject ,4);

            
            //  Destroy(gameObject.tag = "F_m");
            //  Destroy(collision.gameObject, 15);


            Text_Score.Score -= 1;

            if (Text_Score.Score <= 0)
            {
                SceneManager.LoadScene(2);
            }


            //  count_wait_for_spawn_ufo = 0;

        }
    }

}
