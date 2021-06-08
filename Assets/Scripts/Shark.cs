using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;



public class Shark : MonoBehaviour
{
    private Rigidbody2D sharkRigidbody2D;
    public float MOVE_AMOUNT = 100f;

    [SerializeField]
    public PolygonCollider2D[] colliders;
    public int currentColliderIndex = 0;
    
    
    private void Awake(){
        sharkRigidbody2D = GetComponent <Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            Move(1);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            Move(-1);
        }
    }
    private void Move(float direction) {
            sharkRigidbody2D.AddForce(transform.up * MOVE_AMOUNT * direction);
        }
    
    private void SetColliderForSprite(int spriteNum){
        colliders[currentColliderIndex].enabled = false;
        currentColliderIndex = spriteNum;
        colliders[currentColliderIndex].enabled = true;

    }

    private void OnCollisionEnter2D(Collision2D collision){
        CMDebug.TextPopupMouse("Dead!");
        Debug.Log("Dead");
    }
}
