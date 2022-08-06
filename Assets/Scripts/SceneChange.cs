using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);
    }

    public void goToSettings(){
        SceneManager.LoadScene("SettingsMenu", LoadSceneMode.Single);
    }

    public void Quit(){
        Application.Quit();
    }

}
