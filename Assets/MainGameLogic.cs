using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGameLogic : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public BirdScript bird;
    //public RestartGameLogic RSGame;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        score.text = playerScore.ToString();
    }
    void Start()
    {
        //SceneManager.LoadScene("RestartGame");
        //Debug.Log("LoadScene called with 'RestartGame'.");
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        
        //RSGame = GameObject.FindGameObjectWithTag("RestartGameScr").GetComponent<RestartGameLogic>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bird.birdIsAlive = false;


        //SceneManager.LoadScene("RestartGame");
        //Debug.Log("LoadScene called with 'RestartGame'.");

        //RSGame.PrintGameOver();
        //Debug.Log("PrintGameOver called.");
    }
}
