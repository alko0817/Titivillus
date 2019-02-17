using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{

    public Transform[] SpawnPoints;
    public Transform[] SpawnPoints_ufo;
    public float time_spawninig = 30f;
   // public float time_spawninig2 = 3f;
    public GameObject Enemy ;
    public GameObject ufo_1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies" ,1 ,5);
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
            SpawnPoints[spawnIndex].rotation);
    }
}
