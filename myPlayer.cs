using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class myPlayer : MonoBehaviour
{
    public myController controller;
     public TMP_Text ScoreText;
     public static float Score=0;
     
    public float runSpeed;
    public float boostTimer;
    public bool boosting;

    Animator anim;
    public GameObject redClock;
    public GameObject blueClock;
    public GameObject cheese;
    public GameObject mygrid;
    private GameObject jerry;
    [SerializeField] GameObject panelGameOverMenu;
    [SerializeField] GameObject  endGamePanel;
    private Rigidbody2D jerryRb;
   
    void Start(){

        for(int i=0; i<1;i++){
        Vector3 pos = new Vector3(Random.Range(50,170), 3 ,-1);
        Instantiate(redClock, pos , Quaternion.identity);
        }
          for(int i=0; i<1;i++){
        Vector3 pos = new Vector3(Random.Range(10,140), 2 ,-1);
        Instantiate(blueClock, pos , Quaternion.identity);
        }

        for(int i=0; i<12;i++){
        Vector3 pos = new Vector3(Random.Range(1,190), 4 ,-1);
        Instantiate(cheese, pos , Quaternion.identity);
        }
        
        runSpeed =0.31f;
        boostTimer = 0;
        boosting =false;
        anim = GetComponent<Animator>();
        jerry = GameObject.Find("Jerry");
        ScoreText.text="Score " + 0;
        jerryRb = GetComponent<Rigidbody2D>();
          endGamePanel.SetActive(false); 
      
    }
  


private void FixedUpdate(){
  transform.Translate(runSpeed,0,0);
}

    // Update is called once per frame
    void Update()
    {

        if(boosting){

            boostTimer += Time.deltaTime;
            if(boostTimer>=3){

                runSpeed = 0.31f;
                boostTimer =0;
                boosting =false;
            }}
    }



        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("fire"))
        {
          
             anim.SetBool("jerryDead", true);
            Time.timeScale = 0; 
            panelGameOverMenu.SetActive(true); 
           
        }

        if (collision.gameObject.name.StartsWith("trap"))
        {
          
             anim.SetBool("jerryDead", true);
            Time.timeScale = 0; 
            panelGameOverMenu.SetActive(true); 
           
        }
    
        if (collision.gameObject.name.StartsWith("Tom"))
        {  
            
            anim.SetBool("jerryDead", true);
            Time.timeScale = 0; 
            panelGameOverMenu.SetActive(true); 
           
        }
         if (collision.gameObject.name.StartsWith("mouseTrap"))
        { 
            anim.SetBool("jerryDead", true);
            Time.timeScale = 0; 
            panelGameOverMenu.SetActive(true);   
        }
        else{

        anim.SetBool("jerryDead", false);
        anim.SetBool("jerryRun", false);

        }


    }

 

    private void OnTriggerEnter2D(Collider2D col){
         if (col.gameObject.name.StartsWith("blueClock"))
        {
            print("blue");
            boosting =true;
            runSpeed =0.39f;

            Destroy(col.gameObject);
        }
         if ( col.gameObject.name.StartsWith("redClock"))
        {
        
            print("red");
            boosting =true;
            runSpeed =0.26f;
            Destroy(col.gameObject);
        }


              if (col.gameObject.name.StartsWith("cheese"))
        {
        
            Score+=10;
            print("blue");
            Destroy(col.gameObject);
        }
        ScoreText.text="score " + Score.ToString();

       if (col.gameObject.name.StartsWith("Home"))
        {
        
          SceneManager.LoadScene("level2");
        }

          if (col.gameObject.name.StartsWith("endHome"))
        {
            endGamePanel.SetActive(true);  
             Time.timeScale = 0;
          
        }
    }



 
}