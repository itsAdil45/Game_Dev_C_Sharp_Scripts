using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject upBtn;
    [SerializeField] GameObject downBtn;
    public AudioSource myaudio;

      void Awake()
    {
        upBtn.SetActive(true); //hide menu in the start
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Up(){
        myaudio.mute = false;
        downBtn.SetActive(true);
        upBtn.SetActive(false);
    }

    public void Down(){
          myaudio.mute = true;
           downBtn.SetActive(false);
           upBtn.SetActive(true);

    }


}
