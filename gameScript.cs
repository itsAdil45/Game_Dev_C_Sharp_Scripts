using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{
     [SerializeField] GameObject panelMenu;
    // Start is called before the first frame update
     void Awake()
    {
        panelMenu.SetActive(false);
      
        Time.timeScale = 1;//hide menu in the start
    
    }
        public void PauseGame()
    {
        Time.timeScale = 0;
        panelMenu.SetActive(true);
       
    }

  public void ResumeGame()
    {
        Time.timeScale = 1;
         panelMenu.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
