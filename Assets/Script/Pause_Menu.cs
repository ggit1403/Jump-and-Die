using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject X;
    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pause.SetActive(false);
    }

    public void Home()
    {
        SceneManager.LoadScene("Home");
        Time.timeScale = 1;
        pause.SetActive(true);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pause.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        pause.SetActive(true);
    }
    
}
