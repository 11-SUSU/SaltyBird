using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MiddlePipe : MonoBehaviour
{
    public MainGameLogic mainGameLogic;
    // Start is called before the first frame update
    void Start()
    {
        mainGameLogic = GameObject.FindGameObjectWithTag("MainGameLogic").GetComponent<MainGameLogic>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        mainGameLogic.addScore();
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
