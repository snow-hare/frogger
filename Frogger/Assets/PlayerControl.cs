using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newVel = transform.position;

        if (Input.GetKey("w"))
        {
            newVel.y += speed;
        }
        if (Input.GetKey("a"))
        {
            newVel.x += -speed;
        }
        if (Input.GetKey("s"))
        {
            newVel.y += -speed;
        }
        if (Input.GetKey("d"))
        {
            newVel.x += speed;
        }
        transform.position = newVel;
    }
}
