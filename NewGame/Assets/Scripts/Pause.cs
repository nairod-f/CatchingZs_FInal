using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    bool pause;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            DoPause();
        }
    }

    public void DoPause()
    {
        pause = !pause;
        pauseMenu.SetActive(pause);
        if (!pause)
        {
            Time.timeScale = 1;
        }
        else if (pause)
        {
            Time.timeScale = 0;
        }
    }
}
