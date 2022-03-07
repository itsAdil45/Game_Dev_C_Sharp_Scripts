using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomMovement : MonoBehaviour
{
    Animator anim;
    public GameObject rayObj;
    public GameObject rayObj2;
    public GameObject enemy; //  hurldes

    public Transform jerry;
    public float speed = 7f;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    [SerializeField]float rayDistance;
     float characterDirection;

    void Start()
    {
    anim = GetComponent<Animator>();
     characterDirection =0f;  
     rb=this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        characterDirection= 1f;
        Vector3 direction = jerry.position - transform.position;
        
        direction.Normalize();
        movement = direction*5;
 
        RaycastHit2D hitHurdle = Physics2D.Raycast(rayObj.transform.position, Vector2.right* new Vector2(characterDirection,0f),rayDistance);
        RaycastHit2D hitHurdle2 = Physics2D.Raycast(rayObj2.transform.position, Vector2.right* new Vector2(characterDirection,0f),rayDistance);

        if(hitHurdle.collider!=null || hitHurdle2.collider!=null){
            anim.SetBool("tomJump" , true);
           
            transform.Translate(Vector2.up*Time.deltaTime*40);
          
        }
        else{
            anim.SetBool("tomRun" , true);
            anim.SetBool("tomJump" , false);
      
            Debug.DrawRay(rayObj.transform.position, Vector2.right* hitHurdle.distance * new Vector2(characterDirection,0f),Color.green);
        }

    }

private void FixedUpdate(){
moveTom(movement);
}

void moveTom(Vector2 direction){

    rb. MovePosition((Vector2)transform.position + (direction*speed*Time.deltaTime));
}

    
}
