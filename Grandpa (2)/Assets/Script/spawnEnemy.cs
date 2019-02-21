using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spawnEnemy : MonoBehaviour
{
    public Text t_1;
    public int reapeat ;
    public int time_start_spawn;
    public Transform[] SpawnPoints;
    public Transform[] SpawnPoints_ufo;
    public Transform[] light_positions_;
    public float time_spawninig = 30f;
   // public float time_spawninig2 = 3f;
    public GameObject Enemy ;
    public GameObject ufo_1;
    public GameObject lights; 

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnEnemies" , time_start_spawn, reapeat);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }


    void SpawnEnemies ()
    {

         

        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(Enemy, SpawnPoints[spawnIndex].position,
            SpawnPoints[spawnIndex].rotation);
         Instantiate(ufo_1, SpawnPoints_ufo[spawnIndex].position,
            SpawnPoints[spawnIndex].rotation)  ;
 
        Instantiate(lights, light_positions_[spawnIndex].position,
           light_positions_[spawnIndex].rotation);
        

    }
}
