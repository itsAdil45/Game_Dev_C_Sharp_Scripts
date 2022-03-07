using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_heli : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow)) //forward
        {
            transform.Translate(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.DownArrow)) //backward
        {
            transform.Translate(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {

            Vector3 myposition = transform.position;
            myposition.y -= 5;
            Instantiate(bullet,myposition,transform.rotation);
        }
    }

     private void OnCollisionEnter(Collision collision){
         SceneManager.LoadScene("abc");

     }
}
