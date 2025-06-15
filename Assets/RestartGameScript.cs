using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameScript : MonoBehaviour
{
    public GameObject GameOver;
    // Start is called before the first frame update
    public void PrintGameOver()
    {
        GameOver.SetActive(true);
    }
}
