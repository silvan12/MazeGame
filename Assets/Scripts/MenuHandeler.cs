using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandeler : MonoBehaviour
{
    public void QuitGame() {
        Application.Quit ();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}