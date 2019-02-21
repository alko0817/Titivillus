using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_FM : MonoBehaviour
{
    public float speedUFO;
    public GameObject[]  re_spawn;
    public GameObject respawn_prefab;


    // Start is called before the first frame update
    void Start()
    {





    }
    public void Update()
    {
            if (re_spawn == null)
            {
                re_spawn = GameObject.FindGameObjectsWithTag("Ufo");

            }

            foreach (GameObject re_spawn in re_spawn)

            {
                Instantiate(respawn_prefab, re_spawn.transform.position, re_spawn.transform.rotation);
            }
            //  Follow_Fm = GameObject.FindGameObjectWithTag("FamilyMember1").GetComponent<Transform>();
        }
    }
 
 