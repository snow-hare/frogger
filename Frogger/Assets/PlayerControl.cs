using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int speed = 1;
    bool moving = false;
    int move = 10;
    public int moveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newVel = transform.position;

        if (Input.GetKey("w") && !moving)
        {
            newVel.y += speed;
            moving = true;
        }
        else if (Input.GetKey("a") && !moving)
        {
            newVel.x += -speed;
            moving = true;
        }
        else if (Input.GetKey("s") && !moving)
        {
            newVel.y += -speed;
            moving = true;
        }
        else if (Input.GetKey("d") && !moving)
        {
            newVel.x += speed;
            moving = true;
        }
        else if (!(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) && moving)
        {
            moving = false;
        }
        else
        {
            if (move >= moveTime)
            {
                moving = false;
                move = 0;
            }
            else
            {
                move++;
            }
        }
        transform.position = newVel;
    }
}
