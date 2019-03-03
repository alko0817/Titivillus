using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger_5 : MonoBehaviour
{

    public RawImage r5;
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
         if (other.gameObject.tag == "Beem")
        {

            // if (count_wait_for_spawn_ufo > 20)
            // {  

            // Text_Score.Score -= 1;

            Destroy(gameObject);
            Destroy(other.gameObject);
            Destroy(r5.gameObject);
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
