using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject panelGameOverMenu;
    [SerializeField] GameObject panelAd;
  

    void Awake()
    {
        panelMenu.SetActive(false);
        panelGameOverMenu.SetActive(false); //hide menu in the start
    
    }

    public void ShowMenu()
    {
        panelMenu.SetActive(true);
      
    }

    public void HideMenu()
    {
       
        panelMenu.SetActive(false);
    }

    public void ShowPanelAd()
    {
        panelAd.SetActive(true);
    }

    public void LevelMenu(){

        SceneManager.LoadScene("LevelMenu");
    }

       public void restartLevel2(){
         SceneManager.LoadScene("level2");
    }
          public void restartLevel1(){
         SceneManager.LoadScene("level1");
    }

             public void restartLevel3(){
         SceneManager.LoadScene("level3");
    }


}