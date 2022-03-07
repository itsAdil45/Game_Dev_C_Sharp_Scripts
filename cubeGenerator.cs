using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    void Start()
    {
         for(int i=0; i<10;i++){
        Vector3 pos = new Vector3(Random.Range(2.0f,10.0f), 5f, Random.Range(1.0f,10.0f));
        Instantiate(box, pos , Quaternion.identity);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
