using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadARScene()
    {
        SceneManager.LoadScene("AREncyclopedia");
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
