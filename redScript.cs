using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
            anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            
            anim.SetTrigger("makeRed");


        }
        
    }
}
