using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    //Button Functions 
    public void StartButton()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Title");
    }
    public void ExitButton()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
