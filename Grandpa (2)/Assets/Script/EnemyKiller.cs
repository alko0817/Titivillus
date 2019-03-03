using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyKiller : MonoBehaviour
{
   
     public float bulletBlueNumbers = 0;
    public float bulletRedNumbers = 0;
    public float bulletGreenNumbers = 0;
    public Text t1;


    // Start is called before the first frame update
    void Start()
    {
       // t1.text = "Score is :" + FollowPlayer.Score_1.ToString();

       
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
        
    }


    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

             
            Destroy(gameObject);

            Destroy(other.gameObject);
            Text_kill.Score+=1;
             

            //t1.text = "Score is :" + Score_number;



        }







        if (other.gameObject.tag == "Beem")
        {
            Destroy( gameObject);

 
        }

    }

    

}
  /*  private void OnCollisionEnter2D(Collision2D other)
    {
        
        for (int i = 0; i < 30; i++)
        {
            if (other.gameObject.tag == "Enemy1")
            {


                Destroy(gameObject);
                bulletRedNumbers++;

                if (bulletRedNumbers == 30)
                {
                    Destroy(other.gameObject);

                }



            }
        }
    }
}
           /* if (other.gameObject.tag == "GreenBullet")
            {
                bulletGreenNumbers++;
                Destroy(gameObject);

                if (bulletGreenNumbers == 6)
                {

                    Destroy(other.gameObject);

                }

                 
            }


            if (other.gameObject.tag == "blueBullet")
            {
                bulletBlueNumbers++;
                Destroy(gameObject);


                if (bulletBlueNumbers == 12)
                {

                    Destroy(other.gameObject);

                }

            }

        }
        }
    */
 
