using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject helicopter;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position- helicopter.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = helicopter.transform.position + offset;
        
    }
}
