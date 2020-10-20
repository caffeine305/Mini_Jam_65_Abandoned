using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour
{
    //private  CharacterController characterController;

    public float speed = 6.0f;
    
    //public Animator Animar;

    private Vector3 moveDirection = Vector3.zero;
    private Rigidbody body;

    private GameObject[] gameOb;
    public Transform cam;
    public GameController gameController;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        gameOb = GameObject.FindGameObjectsWithTag("MainCamera");

        foreach (GameObject obj in gameOb)
        {
            cam = obj.transform;
        }
        
    }

    void FixedUpdate()
    {
        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0f;
        camR.y = 0f;
        camF = camF.normalized;
        camR = camR.normalized;

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        
        transform.position +=(camR*moveDirection.x + camF*moveDirection.z ) * speed * Time.deltaTime;

        transform.LookAt(transform.position + (camR*moveDirection.x + camF*moveDirection.z ) , Vector3.up);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {   
            this.gameObject.transform.position = gameController.transf.position;
            //this.gameObject.SetActive(false) ;
            gameController.alive = false;
        }
    }


}