﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_new : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet1")
        {


            Destroy(gameObject , 1);

            Destroy(other.gameObject);


        }
    }


}
