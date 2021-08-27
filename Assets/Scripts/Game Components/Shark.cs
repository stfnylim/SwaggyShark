using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shark : MonoBehaviour
{
    // reference to the rigidbody of shark
    private Rigidbody2D sharkRigidbody2D;
    public float MOVE_AMOUNT = 100f; // amount of force for the shark to move

    // To animate the polygon colliders
    [SerializeField]
    public PolygonCollider2D[] colliders;
    public int currentColliderIndex = 0;
    
    
    private void Awake(){
        sharkRigidbody2D = GetComponent <Rigidbody2D>();
        sharkRigidbody2D.drag = 3;
    }
    private void Update(){
        //transform.rotation = Quaternion.LookRotation(sharkRigidbody2D.velocity);
        //transform.eulerAngles = new Vector3(0,0, sharkRigidbody2D.velocity.y*.10f);
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
            if(sharkRigidbody2D.velocity.magnitude < 150) // set max velocity
            sharkRigidbody2D.AddForce(transform.up * MOVE_AMOUNT * direction);
    }
    
    private void SetColliderForSprite(int spriteNum){
        colliders[currentColliderIndex].enabled = false;
        currentColliderIndex = spriteNum;
        colliders[currentColliderIndex].enabled = true;

    }
}
