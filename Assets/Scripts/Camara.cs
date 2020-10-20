using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speed;
    private float angle;
    
    // Update is called once per frame
    void Update()
    {
        float rtaxisX = Input.GetAxis("Mouse X");
        
        if(Input.GetKey("j"))
        {
            angle = (0.5f) * speed * Time.deltaTime;
            angle = angle*(-1);
        }   
        if(Input.GetKey("k"))
        {
            angle = (0.5f) * speed * Time.deltaTime;
        }
        else
        {
        angle = rtaxisX * speed * Time.deltaTime;
        }

        transform.Rotate(0f, angle, 0f);
    }
}
