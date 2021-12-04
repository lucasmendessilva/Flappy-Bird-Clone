using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D colisor)//OnTriggerEnter2D
    {
        controller.Score++;  
        controller.scoreText.text = controller.Score.ToString();      
    }


}
