// PlayerControl.cs
// Created: 6/20/19
// Owner: Ryan Steinglass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int speed = 1;
    bool moving = false;
    int move = 10;
    public int moveTime;
    public Vector3 respawn;
    public bool floating = false;
    public GameObject following;

    // Start is called before the first frame update
    void Start()
    {
        respawn = transform.position;
        following = null;
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newVel = transform.position;
        Vector3 newRot = transform.eulerAngles;

        if (Input.GetKey("w") && !moving)
        {
            newVel.y += speed;
            newRot.z = 0;
            moving = true;
            move = 0;
            following = null;
        }
        else if (Input.GetKey("a") && !moving)
        {
            newVel.x += -speed;
            newRot.z = 90;
            moving = true;
            move = 0;
            following = null;
        }
        else if (Input.GetKey("s") && !moving)
        {
            newVel.y += -speed;
            newRot.z = 180;
            moving = true;
            move = 0;
            following = null;
        }
        else if (Input.GetKey("d") && !moving)
        {
            newVel.x += speed;
            newRot.z = 270;
            moving = true;
            move = 0;
            following = null;
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
        if (following)
        {
            transform.position = following.transform.position;
        }
        transform.eulerAngles = newRot;

        if (transform.position.x < -8.5 || transform.position.x > 8.5)
        {
            transform.position = respawn;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("0"))
        {
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.GetComponent<CarMove>())
        {
            transform.position = respawn;
            transform.eulerAngles = new Vector3(0, 0, 0);
            GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<LilyPadMove>())
        {
            following = collision.gameObject;
        }
    }
}
