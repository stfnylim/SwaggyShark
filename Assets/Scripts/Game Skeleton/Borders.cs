using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Enemy"){
            Debug.Log("Border has hit enemy");
            Destroy(collision.gameObject);
        }
    }
}
