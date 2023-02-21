using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{

    string level = "Level";
    string title = "Title";
    string exit = "Exit";
    
    //Button Functions 
    public void StartButton()
    {
        SceneManager.LoadScene(level);
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(title);
    }
    public void ExitButton()
    {
        Debug.Log(exit);
        Application.Quit();
    }
}
