using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//public class Alians1 : MonoBehaviour
 
  //  public Text Score_number = "dd";
 /*   public Rigidbody2D NewpositionForFamilyMember;
    public Rigidbody2D ufb;
    public float waitTime;
    public float times;
    public float newTime;
    public Rigidbody2D Alians;
    public Rigidbody2D Ufo_Spawn;
    public Rigidbody2D Ufo_Spawener;
    public GameObject SpawnEnemies1;
    public float Count_ufo = 1;
    // public float speed2 = 0.5f;
    public float bulletNumbersEnemy2 = 0;
    public float UfoNumbers = 1;
    public bool rotation_Alians = false;
    
     public Transform enemys;
    public Transform enemys2;
    public Transform enemys3;
    public Transform enemys4;
    public bool change_alians_position = false;
    public float count_hit_fm = 0 ;
    public bool print_sos = false;
    public bool change_alians_position_3 = false;
    public Text Score_Text;
    public int Score_number = 0;
    public bool increasing_Score = false;

    public bool go_to_first_f_m = true;
    public int count_stay_with_f_m = 0;
    public bool Go_to_next_f_m1 = false ;

    public int count_stay_with_f_m1 = 0;
    public bool Go_to_next_f_m2 = false;

    public bool go_to_f_m3 = false;
    public bool Go_to_next_f_m3 = false;


    // public   var  seconds = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(myMethod);
        Score_Text.text = "Score is :" + Score_number;
        enemys = GameObject.FindGameObjectWithTag("F_m").GetComponent<Transform>();

        enemys2 = GameObject.FindGameObjectWithTag("F_m1").GetComponent<Transform>();
        enemys3= GameObject.FindGameObjectWithTag("F_m2").GetComponent<Transform>();
       // enemys4 = GameObject.FindGameObjectWithTag("F_m3").GetComponent<Transform>();

        //   transform.position = Vector2.MoveTowards(transform.position, enemys.transform.position, 2 * Time.deltaTime);

        //  transform.position = Vector2.MoveTowards(transform.position, f_m1.transform.position, 2 * Time.deltaTime);

        // NewpositionForFamilyMember.transform.position = ufb.position;
        // NewpositionForFamilyMember.transform.rotation = ufb.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        //  hand = GameObject.Find("FamilyMember");
        
        Score_Text.text = "Score is :" + Score_number;*/
         /* Alians.AddForce(new Vector3(Random.Range(-100, 100) * 3 * Time.deltaTime,
          Random.Range(-100, 100) * 4 * Time.deltaTime, 0));  */
        //  transform.position = Vector2.MoveTowards(transform.position, f_m1.position, 2*Time.deltaTime);

        // Destroy(gameObject, 5);

    /*
        if (go_to_first_f_m)
        {
       transform.position = Vector2.MoveTowards(transform.position,
           enemys.position, 2*Time.deltaTime);

        }
        if (times <= 0)
        {
          //  transform.position = Vector2.MoveTowards(transform.position, enemys.transform.position, 2 * Time.deltaTime);

        }
        if (times > 0.0f )
         {
            times -= Time.deltaTime;

        }

        if (times < 7)
        {

            spawnUfo();
            Count_ufo = 1;
           // OnCollisionEnter2D(ufb);
        }

         if (rotation_Alians == true)
        {
            transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * 1);

        }


       if ( Go_to_next_f_m2)
        {
      transform.position = Vector2.MoveTowards(transform.position,
          enemys3.transform.position, 2 * Time.deltaTime);


        }*/
        /*  if (change_alians_position == true )
         {
           //   transform.position = Vector2.MoveTowards(transform.position, enemys2.position, 2*Time.deltaTime);

         }*/
        /*  if (print_sos == true )
         {
             transform.position = Vector2.MoveTowards(transform.position, enemys2.position, 2 * Time.deltaTime);
             transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * 1);

             print("sosss");
         }*/
        /*  if (change_alians_position_3)
         {

             transform.position = Vector2.MoveTowards(transform.position, enemys3.position, 2 * Time.deltaTime);
             transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime * 1);

         }*/
     /*   if ( Go_to_next_f_m1)
        {
      transform.position = Vector2.MoveTowards(transform.position, enemys2.position,
          2 * Time.deltaTime);

        }*/

        /* if (increasing_Score == true)
         {
             Score_Text.text = "Score is :" + Score_number;

         }*/
        // transform.position = Vector2.MoveTowards(transform.position, enemy.position, 17 * Time.deltaTime);
 //   }
 

    /*void DestroyObject ()
    {
        yield WaitForSeconds(sec);
        Destoy(gameObject);
    }*/

  //      public void spawnUfo ()
  //  {

       // StartCoroutine(myMethod);

       /* Rigidbody2D bomb2 = Instantiate(Ufo_Spawn,
               Ufo_Spawener.transform.position, Quaternion.identity)
                 as Rigidbody2D;
        times = waitTime; */
   // }

  /*  public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "F_m")
        {
            go_to_first_f_m = false;
            count_stay_with_f_m += 1;
            Go_to_next_f_m1 = true;
            // if (newTime == 2)
            // {  */
            // Destroy(other.gameObject , 6);

            // yield return new WaitForSeconds(3) ;


            // Destroy(other.gameObject, 10);

         /*   rotation_Alians = true;

            Destroy(other.gameObject, 10);


            if (Count_ufo > 0)
            {
                Rigidbody2D bomb2 = Instantiate(Ufo_Spawn,
                   other.transform.position, Quaternion.identity)
                     as Rigidbody2D;
                // bomb2.gameObject.SetActive(false);
                times = waitTime;
                Count_ufo = 0;
                Destroy(bomb2.gameObject, 10);


            }*/

            /*if (count_stay_with_f_m > 5)
            {
                go_to_first_f_m = false;
               

             }*/
       // }
        /*   if (other.transform.position.x - bomb2.transform.position.x < 100)
           {

               print_sos = true;
               print("soso");
               //change_alians_position = true;

           }*/

        //  count_hit_fm += 1;
        //  print(count_hit_fm);




        /*  if (UfoNumbers == 1)
            {
                Rigidbody2D bomb2 = Instantiate(Ufo_Spawn, Ufo_Spawener.transform.position, Quaternion.identity)
                   as Rigidbody2D;
             //  Ufo_Spawn.velocity = transform.TransformDirection(Vector3.down  * 3 * Time.deltaTime);
                UfoNumbers = 0;
            }*/
        // Rigidbody2D bombs = Instantiate( ufb , NewpositionForFamilyMember.transform.position, Quaternion.identity)
        //  as Rigidbody2D;

        // Rigidbody2D bombs2 = Instantiate(NewpositionForFamilyMember, fb.transform.position, Quaternion.identity)
        //    as Rigidbody2D;

        //   Rigidbody2D bombs2 = Instantiate(fb, NewpositionForFamilyMember.transform.position, Quaternion.identity)
        //     as Rigidbody2D;
        // bombs.velocity = transform.TransformDirection
        //  (Vector3.left * 3 * Time.deltaTime);

        // }




     /*   if (other.gameObject.tag == "F_m1")
        {
            Go_to_next_f_m1 = false;
           Go_to_next_f_m2 = true;
            count_stay_with_f_m1 += 1;*/
            // if (newTime == 2)
            // {  
            // Destroy(other.gameObject , 6);

            // yield return new WaitForSeconds(3) ;


            // Destroy(other.gameObject, 10);
         /*   Destroy(other.gameObject, 10);
            rotation_Alians = true;

            if (Count_ufo > 0)
            {
                Rigidbody2D bomb2 = Instantiate(Ufo_Spawn,
                   other.transform.position, Quaternion.identity)
                     as Rigidbody2D;
                // bomb2.gameObject.SetActive(false);
                times = waitTime;
                Count_ufo = 0;
                Destroy(bomb2.gameObject, 10);
            }


            if (count_stay_with_f_m1 > 5)
            {


            }
        }*/
    
             /*   if (other.transform.position.x - bomb2.transform.position.x < 100)
                {

                    //print_sos = true;
                    print("soso");
                    change_alians_position = true;

                }
            }*/






    /*

            if (other.gameObject.tag == "F_m2")
              {
            Go_to_next_f_m2 = false;
            Go_to_next_f_m1 = false;
            // if (newTime == 2)
            // {  
            // Destroy(other.gameObject , 6);

            // yield return new WaitForSeconds(3) ;


            // Destroy(other.gameObject, 10);

            rotation_Alians = true;

                  if (Count_ufo > 0)
                  {
                      Rigidbody2D bomb2 = Instantiate(Ufo_Spawn,
                         other.transform.position, Quaternion.identity)
                           as Rigidbody2D;
                      // bomb2.gameObject.SetActive(false);
                      times = waitTime;
                      Count_ufo = 0;*/

                   /*   if (other.transform.position.x - bomb2.transform.position.x < 100)
                      {

                         // print_sos = true;
                          print("soso");
                          change_alians_position_3 = true;

                      }*/
            /*      }
                  count_hit_fm += 1;
                  print(count_hit_fm);



              }*/
        /*  if (UfoNumbers == 1)
            {
                Rigidbody2D bomb2 = Instantiate(Ufo_Spawn, Ufo_Spawener.transform.position, Quaternion.identity)
                   as Rigidbody2D;
             //  Ufo_Spawn.velocity = transform.TransformDirection(Vector3.down  * 3 * Time.deltaTime);
                UfoNumbers = 0;
            }*/
        // Rigidbody2D bombs = Instantiate( ufb , NewpositionForFamilyMember.transform.position, Quaternion.identity)
        //  as Rigidbody2D;

        // Rigidbody2D bombs2 = Instantiate(NewpositionForFamilyMember, fb.transform.position, Quaternion.identity)
        //    as Rigidbody2D;

        //   Rigidbody2D bombs2 = Instantiate(fb, NewpositionForFamilyMember.transform.position, Quaternion.identity)
        //     as Rigidbody2D;
        // bombs.velocity = transform.TransformDirection
        //  (Vector3.left * 3 * Time.deltaTime);

        // }



      /*  if (other.gameObject.tag == "F_m2")
        {
            Go_to_next_f_m2 = false;
            count_stay_with_f_m += 1;
            Go_to_next_f_m1 = true;
            // if (newTime == 2)
            // {  
            // Destroy(other.gameObject , 6);

            // yield return new WaitForSeconds(3) ;


            // Destroy(other.gameObject, 10);

            rotation_Alians = true;

            Destroy(other.gameObject, 7);
            Destroy(gameObject, 5);

            if (Count_ufo > 0)
            {
                Rigidbody2D bomb2 = Instantiate(Ufo_Spawn,
                   other.transform.position, Quaternion.identity)
                     as Rigidbody2D;
                // bomb2.gameObject.SetActive(false);
                times = waitTime;
                Count_ufo = 0;
                Destroy(bomb2.gameObject, 8);


            }
            




            if (other.gameObject.tag == "Bullet1")
            {
                //  Destroy(other.gameObject);
                bulletNumbersEnemy2++;

                if (bulletNumbersEnemy2 == 10)
                {

                    Destroy(gameObject);
                    Destroy(other.gameObject);
                    Score_number += 1;
                    Score_Text.text = "Score is :" + Score_number;
                    increasing_Score = true; */
                    /*   Rigidbody2D new_Alians  = Instantiate(Alians , 
                           SpawnEnemies1.transform.position, Quaternion.identity) as Rigidbody2D;*/
              /*  }


            }
        }
    } 
}
*/

     

 