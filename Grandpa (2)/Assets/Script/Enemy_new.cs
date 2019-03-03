using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_new : MonoBehaviour
{

     
    public bool increase_score = false;
    public int Score_number = 0;
     // Start is called before the first frame update
    void Start()
    {
       // t1.text = "Score is :" + Score_number.ToString();
        Set_score();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 12);
      //  transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * 2);
        Set_score();
        
       // t1.text = "Score is :" + Score_number;

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
      /*  if (other.gameObject.tag == "Bullet1")
        {
            
           Score_number += 1;
            Destroy(gameObject , 1);

            Destroy(other.gameObject);
            Score_number++;
            Set_score();

            //t1.text = "Score is :" + Score_number;



        }*/
    }
    public void Set_score()
    {
     //   t1.text = "Score is :" + Score_number.ToString();

    }


}
