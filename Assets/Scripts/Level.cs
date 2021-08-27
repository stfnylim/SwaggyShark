using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public float SPEED = 10f; // speed of the player movement

    private enum Difficulty {
        Easy, Medium, Hard, Impossible
    }

    private void Awake(){
        

    }

    private void Update(){
       
    }

    private void Start(){
        
    }

 

//----------------------------------------------------OLD IMPLEMENTATION OF ENEMY GENERATION-------------------//

/**
    private void CreateBomb(float height, float xPosition, bool createBottom){
        Transform bombHead;
        Transform bombChain;
        Transform jellyFish;


        

        if(createBottom){ // if create bottom, then we create the bomb
            // Bomb head
            bombHead = Instantiate(GameAssets.GetInstance().pfBombHead);
            bombChain = Instantiate(GameAssets.GetInstance().pfBombChain);
            bombHead.position = new Vector3(xPosition, height);
            // Bomb chain
            
            bombChain.position = new Vector3(xPosition, height);
            bombList.Add(bombHead);
            bombList.Add(bombChain);

        } else { // if create top, then we create the jelly fish
            jellyFish = Instantiate(GameAssets.GetInstance().pfJellyFish);
            jellyFish.position = new Vector3(xPosition, height);
            bombList.Add(jellyFish);
            
        }

        
        //bombHeadSpriteRenderer.size = new Vectror2()SpriteRenderer bombHeadSpriteRenderer = bombHead.GetComponent<SpriteRenderer>();

    }

    private void CreateCoin(float height, float xPosition){
        Transform coin = Instantiate(GameAssets.GetInstance().pfCoin);
    }

    private void CreateDiscoBall(float height, float xPosition){
        Transform discoBall = Instantiate(GameAssets.GetInstance().pfDiscoBall);
    }
*/
}
