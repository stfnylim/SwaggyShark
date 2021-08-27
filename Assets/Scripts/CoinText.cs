using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    public Text coinText;
    private GameHandler gameHandler;

    void Awake(){
        gameHandler = FindObjectOfType<GameHandler>();
    }
    void FixedUpdate(){
        coinText.text = "Coins " + gameHandler.getCoinCount().ToString();
    }
}
