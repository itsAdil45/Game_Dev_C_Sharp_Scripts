using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_trafic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.4f);
         Vector3 pos =transform.position;
        if(pos.z>-130){

            pos.z=-310;
            transform.position=pos;
        }
        
    }
}
