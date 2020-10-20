using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float speed;
    float angle = 0;
    int side = 1;
    float calcAngle;

    int ControlSide()
    {
        calcAngle =  transform.eulerAngles.y;
        if (transform.eulerAngles.y > 20 && transform.eulerAngles.y < 315)
            side = -1;

        if (transform.eulerAngles.y < 316 && transform.eulerAngles.y > 315)
            side = 1;
        return side;
    }

    //-40 a 20
    void Update()
    {
        //angle = speed * Time.deltaTime * side;

        side = ControlSide();

        angle = speed * Time.deltaTime * side;
        
        transform.Rotate(0, angle, 0);
        Debug.Log(calcAngle);
    }
}
