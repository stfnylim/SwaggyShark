using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameHandler gameHandler;
    AudioSource coinAudio;

    void Awake(){
        gameHandler = FindObjectOfType<GameHandler>();
    }


    /**
    void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
        
        Debug.Log("Destroyed a coin.");
    }
    */
    void OnBecameInvisible(){
        Destroy(this.gameObject);
    }
}
