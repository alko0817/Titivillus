using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons2Following : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playersMove1;
    public Transform weapons2Position;
    public float distance = 0.5f;

    // Start is called before the first frame update

    // Update is called once per frame


    private void Start()
    {
        weapons2Position = playersMove1.transform;
    }
    void Update()
    {
        transform.position = new Vector3(weapons2Position.position.x - 10 + distance, transform.position.y,
             transform.position.z);
    }
}