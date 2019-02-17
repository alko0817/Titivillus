using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family_m1 : MonoBehaviour
{

    public GameObject uf_o1;
    public Rigidbody2D ali_ans1;
    public Transform f_m2;

    public bool moveAlians = false;
   


     
    // Start is called before the first frame update
    void Start()
    {
        f_m2 = GameObject.FindGameObjectWithTag("F_m1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ali_ans1.transform.position = Vector2.MoveTowards(ali_ans1.transform.position, f_m2.transform.position, 4);
    }

    public void check_position ()
    {
        if ( transform.position.x - uf_o1.transform.position.x > 20)
        {
            print("soso");
            moveAlians = true;
        }

    }

}
