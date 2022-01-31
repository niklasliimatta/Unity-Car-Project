using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape) && !isPaused)
        {
            Pause();
        }
        
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        isPaused = !isPaused;
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        isPaused = !isPaused;
        Time.timeScale = 1f;
    }
}
