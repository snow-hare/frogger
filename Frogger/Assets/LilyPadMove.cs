// LilyPadMove
// Created: 7/1/19
// Owner: Ryan Steinglass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyPadMove : MonoBehaviour
{
    public bool sink;
    public float speed;
    int time = 0;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        time++;

        transform.position = new Vector3(transform.position.x + speed, y, z);
        if (Mathf.Abs(transform.position.x) >= 10)
        {
            transform.position = new Vector3(transform.position.x * -1, y, z);
        }
        if (sink && time == 150)
        {
            time = 0;
            if (transform.position.z != 50)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 50);
                z = 50;
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -1);
                z = -1;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.transform.GetComponent<PlayerControl>() && transform.position.z == 50) || Input.GetKey("9"))
        {
            collision.transform.GetComponent<PlayerControl>().Die();
        }
    }
}
