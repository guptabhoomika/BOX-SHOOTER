﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicmover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.01f;
    public bool doSpin;
    public bool doMotion;

     void Update()
    {
        if (doSpin)
        {
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMotion)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }


        
        
    }
}
