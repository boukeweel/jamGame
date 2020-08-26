using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool ispaused;

    public GameObject pausemenu;

    public GameObject Doors_open;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            unpause();
        }

        
        pausemenu.SetActive(ispaused);
        Doors_open.SetActive(!ispaused);
        
    }
    public void unpause()
    {
        ispaused = !ispaused;
        Time.timeScale = ispaused ? 0 : 1;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
    
}
