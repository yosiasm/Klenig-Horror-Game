﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layer_follow : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = target.GetComponent<SpriteRenderer>().sortingLayerName;
    }
}