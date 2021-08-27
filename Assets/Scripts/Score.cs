using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Transform startingPoint;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((player.position.x - startingPoint.position.x)/20).ToString("0");
    }
}
