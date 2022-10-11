using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float offsetX = 0, offsetY = 0, offsetZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player
        transform.position = player.transform.position + new Vector3(offsetX, offsetY, offsetZ);
    }
}
