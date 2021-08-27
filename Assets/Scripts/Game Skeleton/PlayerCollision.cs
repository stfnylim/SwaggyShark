using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Shark movement;
    private GameHandler gameHandler;
    private RandomEnemySpawner enemySpawner;
    private bool dead = false;
    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("We hit a " + collision.gameObject.tag);
        if( collision.gameObject.tag == "Enemy"){
            movement.enabled = false;
            dead = true;
            enemySpawner.enabled = false;
            gameHandler.EndGame();
            
        }
        else if(collision.gameObject.tag == "DiscoBall"){
            enemySpawner.discoTime = true;
        }
        
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Coin"){
            gameHandler.IncrementCoin();
            Destroy(other.gameObject);
            Debug.Log("We hit a coin");
        }
        else if(other.transform.tag == "DiscoBall"){
            Destroy(other.gameObject);
        }
    }

    void Awake(){
        gameHandler = FindObjectOfType<GameHandler>();
        enemySpawner = FindObjectOfType<RandomEnemySpawner>();
    }

    void Update(){
        if(dead){
            stopCamera();
        }
    }

    private void stopCamera(){
        if(gameHandler.camera.cameraSpeed > 0){
            gameHandler.camera.cameraSpeed -= 1;
        }
        else if (gameHandler.camera.cameraSpeed < 0){
            gameHandler.camera.cameraSpeed += 1;
        }
    }



}
