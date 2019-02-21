using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Collections;
public class FollowPlayer : MonoBehaviour
{

     public GameObject playersMove;
    public Transform playerPosition  ;
    public static  int Score_1 = 0;
   // public float Camera_Distance = 0;
    // Start is called before the first frame update

    // Update is called once per frame


    public void Start()
    {
        playerPosition = playersMove.transform;
        
    }
    private void Awake()
    {
       // GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.width / 14));
    }
    void  Update()
    {
       
        transform.position = new Vector3(playerPosition.position.x, transform.position.y,
             transform.position.y);

          
    }
}
 