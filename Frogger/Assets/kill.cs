// kill.cs
// Created: 6/20/19
// Owner: Ryan Steinglass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerControl>())
        {
            if (!other.GetComponent<PlayerControl>().following)
                other.transform.position = other.GetComponent<PlayerControl>().respawn;
        }
    }
}
