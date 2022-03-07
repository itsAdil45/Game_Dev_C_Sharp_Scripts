using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafic_script : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
             transform.Translate(0,0,0.3f);

            Vector3 pos =transform.position;           
            if(pos.z>80){
            
            pos.z=-218;
            transform.position=pos;
        }
               
      
  
    }

  
}
