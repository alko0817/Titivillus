﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_bullet2 : MonoBehaviour
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
        
        if (other.gameObject.tag == "Enemy"    )
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }


    }
}
