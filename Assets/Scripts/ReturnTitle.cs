using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitAndReturnToTitle());
    }

    IEnumerator WaitAndReturnToTitle()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Title");
    }

}
