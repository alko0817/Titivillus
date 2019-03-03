using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outbound : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("collsios!! fds = " + col.gameObject.name);
        if (col.gameObject.tag == "Bullet1")
        {
            Destroy(col.gameObject);
        }
    }
}
