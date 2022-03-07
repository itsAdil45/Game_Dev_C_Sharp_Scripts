using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResumeScript : MonoBehaviour
{

     void Awake()
    {
        Time.timeScale = 1; //hide menu in the start
    }
    
    public void PauseGame()
    {
        Time.timeScale = 0;
       
    }

  public void ResumeGame()
    {
        Time.timeScale = 1;
    }


    public void EndGame()
    {
        Application.Quit();
    }
}