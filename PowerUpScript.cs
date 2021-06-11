﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float speed;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(new Vector2(0f, -1f) * Time.deltaTime * speed);
        
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
