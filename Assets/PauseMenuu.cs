﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void update (){
        if (Input.GetKeyDown(KeyCode.Space)){
            if (GameIsPaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume (){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    
    public void Pause (){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void QuitMenu(){
        Application.Quit();
    }
}
