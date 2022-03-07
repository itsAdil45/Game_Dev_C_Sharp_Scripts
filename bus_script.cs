using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bus_script : MonoBehaviour
{
     public AudioClip horn;
    
    // Start is called before the first frame update
      
    void Start()
    {

       
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,0.8f);

        }

         if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,1,0);

        }

         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,-1,0);

        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-0.5f);

        }
         if(Input.GetKey(KeyCode.H)){
        GetComponent<AudioSource>().Play();

        }
   
    }


}
