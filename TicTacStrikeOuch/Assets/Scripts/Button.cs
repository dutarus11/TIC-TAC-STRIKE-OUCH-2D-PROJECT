using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{

   private string level = "Level";
   private string title = "Title";
   private string exit = "Exit";
    
    //Button Functions 
    private void StartButton()
    {
        SceneManager.LoadScene(level);
    }

    private void QuitButton()
    {
        SceneManager.LoadScene(title);
    }
    private void ExitButton()
    {
        Debug.Log(exit);
        Application.Quit();
    }
}
