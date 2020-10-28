using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    void Start () 
    {
           StartCoroutine(Blinker());
    }
    
        IEnumerator Blinker() { 
    
        while (true){

            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.6f);
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.6f);
            }
        }
}
