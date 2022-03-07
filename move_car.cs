using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_car : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip crash_audio;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake =false;
        GetComponent<AudioSource>().clip =crash_audio;
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,0.5f);

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
        
        Vector3 pos =transform.position;
        if(pos.z>-130){

            pos.z=-310;
            transform.position=pos;
        }

            if(Input.GetKey(KeyCode.Space)){
        Rigidbody r = GetComponent<Rigidbody>();
        r.AddForce(0,10,0);
            
        }

     
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Bus_1" || collision.gameObject.name == "Bus_2" || collision.gameObject.name == "Car_4" || collision.gameObject.name == "Police_car")
        {
            GetComponent<AudioSource>().Play();


        }
    }
}
