﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Move : MonoBehaviour
{
    public float carSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * carSpeed); 
    }

}
