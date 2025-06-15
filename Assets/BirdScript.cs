using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D bird;
    public float flapStrength = 13;
    public bool birdIsAlive = true;
    public RestartGameLogicScript RSGame;

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject.DontDestroyOnLoad(this.gameObject);

        if (bird == null)
        {
            bird = GetComponent<Rigidbody2D>();
            if (bird == null)
            {
                Debug.LogError("Rigidbody2D component not found on the GameObject.");
            }
        }

        GameObject restartGameObj = GameObject.FindGameObjectWithTag("RestartGameScr");
        if (restartGameObj != null)
        {
            Debug.Log("GameObject with tag 'RestartGameScr' found.");
            RSGame = restartGameObj.GetComponent<RestartGameLogicScript>();
            if (RSGame != null)
            {
                Debug.Log("RestartGameLogic component found on the GameObject.");
            }
            else
            {
                Debug.LogError("RestartGameLogic component not found on the GameObject with tag 'RestartGameScr'.");
            }
        }
        else
        {
            Debug.LogError("GameObject with tag 'RestartGameScr' not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            if (bird != null)
            {
                bird.velocity = Vector2.up * flapStrength;
            }
            else
            {
                Debug.LogError("bird is null when trying to apply velocity.");
            }
        }

        if (!birdIsAlive)
        {
            //SceneManager.LoadScene("RestartGame");
            //Debug.Log("LoadScene called with 'RestartGame'.");

                RSGame.PrintGameOver();
                Debug.Log("PrintGameOver called.");
   

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
    }
}
