using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject banner;
    private Vector3 bannerPos;

    void Start()
    {
        bannerPos = new Vector3(1.5f, 17.0f, -14.0f);
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End");
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Instantiate(banner,bannerPos,transform.rotation);
            StartCoroutine(ChangeScene());
        }
    }

}
