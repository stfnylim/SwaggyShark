using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private void Start(){
        CreateBomb(0f,0f, true);
        CreateBomb(0f,10f, false);
    }
    private void CreateBomb(float height, float xPosition, bool createBottom){

        Transform bombHead = Instantiate(GameAssets.GetInstance().pfBombHead);
        Transform bombChain = Instantiate(GameAssets.GetInstance().pfBombChain);
        Transform jellyFish = Instantiate(GameAssets.GetInstance().pfJellyFish);
        
        if(createBottom){ // if create bottom, then we create the bomb
            // Bomb head
            
            bombHead.position = new Vector3(xPosition, height);
            // Bomb chain
            
            bombChain.position = new Vector3(xPosition, height);
        } else { // if create top, then we create the jelly fish
            
            jellyFish.position = new Vector3(xPosition, height);
        }

        
        //bombHeadSpriteRenderer.size = new Vectror2()SpriteRenderer bombHeadSpriteRenderer = bombHead.GetComponent<SpriteRenderer>();

    }
}
