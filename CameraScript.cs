using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject jerry;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - jerry.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jerry.transform.position + offset;
    }
}
