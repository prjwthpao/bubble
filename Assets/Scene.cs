using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadNextScene(){
      int currentScceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(currentScceneIndex +1);
    }

    public void LoadStartScene(){
      SceneManager.LoadScene(0);
    }

    public void LoadPrevScene(){
      int currentScceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(currentScceneIndex -1);
    }

    public void LoadGame(){
      SceneManager.LoadScene("Game");
    }

    public void LoadLogin(){
      SceneManager.LoadScene("Login");
    }

    public void LoadWin(){
      SceneManager.LoadScene("Win");
    }

    public void LoadGameOver(){
      SceneManager.LoadScene("GameOver");
    }

    public void LoadMenu(){
      SceneManager.LoadScene("Menu");
    }

    public void LoadExit(){
      SceneManager.LoadScene("Exit");
    }

    public void LoadRegister(){
      SceneManager.LoadScene("Register");
    }

    public void LoadForgotten(){
      SceneManager.LoadScene("Forgotten password");
    }

    public void LoadSetting(){
      SceneManager.LoadScene("Setting");
    }
}
