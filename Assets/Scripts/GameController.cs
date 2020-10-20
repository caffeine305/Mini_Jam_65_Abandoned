using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool winState = false;
    public bool alive = true;
    public int lives = 5;
    public GameObject jugador;
    public Transform transf;

    void Start()
    {
        winState = false;
        alive = true;
        lives = 5;

        //StartCoroutine(GameControl());
        Debug.Log("Start");
    }

    public void Respawn()
    {
        Debug.Log("Respawning");
        //Instantiate(jugador,transf.position,transf.rotation);
        Debug.Log("Lives: "+lives);
        alive = true;
    }


    //IEnumerator GameControl()
    public void Update()
    {
        Debug.Log("Running");
        //while(lives > 0)
        if(lives > 0)
        {
            if(!alive)
            {
                lives--;
                Respawn();
            }

            if(winState)
            {
                Debug.Log("Complete!");
            }

        }
        //el Yield evitaba el uso del Else....
        else
        {
        //yield return new WaitForSeconds(2f);
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver");
        
        //Aquí debe brincar a la escena de Game Over, y de ahí a la pantalla de título.
        }

    }
}
