using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReloadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //    if (Input.GetKey(KeyCode.S)) //forward
        // {
        //     SceneManager.LoadScene("StartingScene");
        // }
        
    }

    public void myClick(){
        SceneManager.LoadScene("LevelMenu");

    }

}
