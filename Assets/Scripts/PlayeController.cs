using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle foward
        transform.Translate(Vector3.forward);
        
    }

    
}
