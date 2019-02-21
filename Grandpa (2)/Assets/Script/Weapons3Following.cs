using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons3Following : MonoBehaviour
{
    public GameObject playersMoves;
    public Transform weapons2Position3;
    public float distance = 3f;

    // Start is called before the first frame update

    // Update is called once per frame


    private void Start()
    {
        weapons2Position3 = playersMoves.transform;
    }
    void Update()
    {
        transform.position = new Vector3(weapons2Position3.position.x -12 + distance, transform.position.y,
             transform.position.z);
    }
}