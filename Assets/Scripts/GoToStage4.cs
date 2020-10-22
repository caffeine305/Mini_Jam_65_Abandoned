﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage4 : MonoBehaviour
{
    public GameObject banner;
    public Transform camera;
    private Vector3 bannerPos;
    private Quaternion bannerRot;

    void Start()
    {
        bannerPos = new Vector3(0.0f, 3.0f, 0.0f);
        bannerRot = Quaternion.Euler(45, 200, 0);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scene4");
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Instantiate(banner,transform.position+bannerPos,bannerRot);  
            StartCoroutine(ChangeScene());
        }
    }

    void LateUpdate()
    {
        banner.transform.LookAt(banner.transform.position + camera.forward);
    }



}
