using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public CameraMovement camera;
    private bool gameHasEnded = false;
    private int coins = 0;
    public float delay = 1f;

    public bool getGameHasEnded(){return gameHasEnded;}
    public void EndGame(){
        if(gameHasEnded == false){ // so that the end game function will only be called once.
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", delay);
        }
    }

    public void IncrementCoin(){
        coins += 1;
    }

    public int getCoinCount(){
        return coins;
    }
    
    void Restart(){
        DeleteAll();
        SceneManager.LoadScene("Main Menu");
    }
    void DeleteAll(){
         foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
             Debug.Log("Deleted: " + o.tag);
             Destroy(o);
         }
     }
}
