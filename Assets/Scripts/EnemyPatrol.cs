using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody enemyRB;
    public int moveLenght = 5;
    public float enSpeed = 200;
    public bool isFacingForward;
    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 direccion;

    private bool moveForward = true;

    public void Awake()
    {
        enemyRB = GetComponent<Rigidbody>();
        startPos = transform.position;
        endPos = startPos * moveLenght;
        
        isFacingForward = transform.localScale.magnitude > 0;
        direccion = transform.TransformDirection(Vector3.forward);
    }

    public void Flip()
    {
        //Vector3 direction = velocity.normalized;
        //Vector3 desiredDirection = new Vector3.forward; // set this to the direction you want.
        //Vector3 newVelocity = desiredDirection.normalized * currentVelocity.magnitude;
        
        if(moveForward)
        {
            direccion = transform.TransformDirection(Vector3.forward) *(-1);
            moveForward = false;
        }
        else
        {
            direccion = transform.TransformDirection(Vector3.forward);
            moveForward = true;
        }

    }

    void Update()
    {        
        enemyRB.AddForce(direccion * enSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        Flip();
    }
}
