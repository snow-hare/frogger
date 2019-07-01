// play.cs
// Created: 7/1/19
// Owner: Ryan Steinglass

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string scene)
    {
        Debug.Log("play");
        SceneManager.LoadScene(scene);
    }
}
