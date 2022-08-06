using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBall : MonoBehaviour
{
    void OnBecameInvisible(){
        Destroy(this.gameObject);
    }
}
