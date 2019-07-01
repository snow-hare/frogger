// CarMove.cs
// Created: 6/20/19
// Owner: Ryan Steinglass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        if (transform.position.x >= 9.5 || transform.position.x < -9.5)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);
        }
    }
}
