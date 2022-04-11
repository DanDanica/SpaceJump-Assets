using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform astronaut;
    public Transform bgCenter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(astronaut.position.y >= transform.position.y){
	    transform.position = new Vector3(
                transform.position.x,
                astronaut.position.y,
                transform.position.z
            );
        }
        if(transform.position.y >= bgCenter.position.y + 10.56f){
            bgCenter.position = new Vector2(
                bgCenter.position.x,
                transform.position.y +10.56f
            );
        }
    }
}
