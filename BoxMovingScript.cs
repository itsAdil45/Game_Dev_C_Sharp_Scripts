using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKey(KeyCode.R)){
            
        transform.Rotate(0,50,0);     

        }
          if(Input.GetKey(KeyCode.U)){
            transform.Translate(0,0.01f,0);

        }

         if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.01f,0,0);

        }

         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.01f,0,0);

        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0,-0.01f,0);

        }
    }
}
