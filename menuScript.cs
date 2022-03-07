using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void myClicklevel1(){
        SceneManager.LoadScene("level1");

    }

      public void myClicklevel2(){
        SceneManager.LoadScene("level2");

    }

      public void myClicklevel3(){
        SceneManager.LoadScene("level3");

    }
}
