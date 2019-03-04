using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger_5 : MonoBehaviour
{

    public RawImage r5;
    public bool move_it_up = false;
    public int count_hits = 0;
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
            Destroy(r5.gameObject, 4);
            count_hits += 1;
            //   Destroy(gameObject.tag = "F_m");
            //   Destroy(collision.gameObject, 15);

            // Ufo_Rotation.move  = true;
            if (count_hits == 1)
            {  
            Text_Score.Score -= 1;
                count_hits = -1;
            if (Text_Score.Score <= 0)
            {
                SceneManager.LoadScene(2);
            }

        }

            //  count_wait_for_spawn_ufo = 0;

        }
    }

}
