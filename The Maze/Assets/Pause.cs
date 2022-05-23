using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pause;

    public void pauseMenu()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void exit()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
