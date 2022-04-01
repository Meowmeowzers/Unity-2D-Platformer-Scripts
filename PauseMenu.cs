using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausemenu;
    public static bool isPaused = false;

    public void Start()
    {
        pausemenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
                PauseGame();
        }
    }
    public void PauseGame()
    {
        pausemenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    
    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu");
    }
}
