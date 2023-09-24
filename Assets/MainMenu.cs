using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public SceneManager scenemanager;



    

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
  

   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }


    public void LinkToWebsite()
    {
        Application.OpenURL("https://uppbeat.io/t/michael-grubb/floating-cat");
    }



    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }


    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
