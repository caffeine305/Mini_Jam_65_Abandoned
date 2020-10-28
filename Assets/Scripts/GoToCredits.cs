using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitAndReturnToTitle());
    }

    IEnumerator WaitAndReturnToTitle()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Credits");
    }

}
