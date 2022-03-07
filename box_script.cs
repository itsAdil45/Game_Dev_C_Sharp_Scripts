using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_script : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Up;
    public AudioSource Down;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      

         if(Input.GetKey(KeyCode.R)){
            
        transform.Translate(0,0.01f,0);  
        transform.Rotate(0,5,0);
        Up.Play();

        }
    
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0,-0.01f,0);
             transform.Rotate(0,5,0);
            Down.Play();

        }
    }
    
}
