using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1Following : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject playersMove;
    public Transform weaponsPosition;

    // Start is called before the first frame update

    // Update is called once per frame


    private void Start()
    {
        weaponsPosition = playersMove.transform;
    }
    void Update()
    {
        transform.position = new Vector3(weaponsPosition.position.x - 5, transform.position.y,
             transform.position.z);
    }
}