using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    public enum ItemType
    {
        NOTHING,
        COIN,
        MUSHROOM,
        STAR
    }
    public ItemType item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item == ItemType.COIN)
        {

        }
        else if (item == ItemType.MUSHROOM)
        {

        }
    }
}
