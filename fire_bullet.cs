using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire_bullet : MonoBehaviour
{   
    public GameObject explosion;
    public Text scoreText;
    public static float score=0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text="Score " + 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.9f);
        explosion.SetActive(false);

        
    }
    private void OnCollisionEnter(Collision collision){
        if(!collision.gameObject.name.StartsWith("Terrain")){

            Destroy(collision.gameObject);
            score+=10;

        }

          print(score);
          scoreText.text="Score " + score.ToString();
          Destroy(transform.gameObject);
          explosion.SetActive(true);
          Instantiate(explosion,transform.position,transform.rotation);
        }
       
        
}
