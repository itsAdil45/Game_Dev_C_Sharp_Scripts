using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
          for(int i=0; i<4;i++){
        Vector3 pos = new Vector3(Random.Range(490,550), -17, Random.Range(365,400));
        Instantiate(enemy, pos , Quaternion.identity);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
