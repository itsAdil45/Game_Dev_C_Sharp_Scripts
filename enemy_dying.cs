using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_dying : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public Text scoreText;
    public static float score=0;
    private GameObject me;
    public AudioClip zombie_audio;
    public GameObject smoke;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("iswalk",true);
        anim.SetBool("isdead",false);
        scoreText.text="Score " + 0;
        me = GameObject.Find("Player");
        GetComponent<AudioSource>().playOnAwake =false;
        GetComponent<AudioSource>().clip =zombie_audio;

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.003f);
        transform.LookAt(me.transform);
        smoke.SetActive(false);
        
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name.StartsWith("Bullet")){
            print("hello");
            anim.SetBool("iswalk",false);
            anim.SetBool("isdead",true);
            score+=10;
            GetComponent<AudioSource>().Play();
        }
         scoreText.text="Score " + score.ToString();
         smoke.SetActive(true);
         Instantiate(smoke,transform.position,transform.rotation);

    }
}
