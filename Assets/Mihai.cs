using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public Rigidbody2D bird;
    public float flapStrength = 13;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {

            bird.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
    }



}
