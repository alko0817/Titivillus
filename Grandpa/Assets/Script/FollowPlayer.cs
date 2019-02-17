using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playersMove;
    public Transform playerPosition  ;

    // Start is called before the first frame update

    // Update is called once per frame


    private void Start()
    {
        playerPosition = playersMove.transform;
    }
    void  Update()
    {
        transform.position = new Vector3(playerPosition.position.x, transform.position.y,
             transform.position.y);
    }
}
