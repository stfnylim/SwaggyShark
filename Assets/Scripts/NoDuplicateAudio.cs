using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDuplicateAudio : MonoBehaviour
{
    static Object instance = null;
    void Awake(){
        if(instance != null){
            Destroy(this.gameObject);
            return;
        }
        else{
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        
    }
    void OnDestroy(){
        if (instance == this){
            instance = null;
        }
    }
}
