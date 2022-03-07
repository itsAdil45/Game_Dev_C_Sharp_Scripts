using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullet_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Rigidbody>().AddForce(transform.forward*1000);
     
    }

    // Update is called once per frame
    void Update()
    {
    //   transform.Translate(0,0,1);
    
    }
      private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name.StartsWith("enemy")){

            Destroy(collision.gameObject);
           
        }

          
          Destroy(transform.gameObject);
       

        //   Instantiate(explosion,transform.position,transform.rotation);
        }

}
