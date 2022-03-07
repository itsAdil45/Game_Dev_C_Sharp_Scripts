using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apple;
    void Start()
    {
        for(int i=0; i<3;i++){
        Vector3 pos = new Vector3(Random.Range(-19,18), 6 ,-1);
        Instantiate(apple, pos , Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
