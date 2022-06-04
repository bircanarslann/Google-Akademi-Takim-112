using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInGame : MonoBehaviour
{
    public GameObject gameMenu, pauseMenu;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PauseButton(){
        Time.timeScale=0; //oyunu durdurma
        gameMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void PlayButton(){
        Time.timeScale=1; 
        gameMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void RestartButton(){
        Time.timeScale=1; 
        SceneManager.LoadScene(1); //devam edecek sahne
    }

    public void MenuButton(){
        Time.timeScale=1; 
        SceneManager.LoadScene(0); //ana menü
    }

}
