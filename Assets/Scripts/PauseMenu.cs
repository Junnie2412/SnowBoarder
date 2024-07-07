using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
        Time.timeScale = 1;
    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
