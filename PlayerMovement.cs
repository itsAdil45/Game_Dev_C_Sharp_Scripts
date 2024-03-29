// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;



// public class PlayerMovement : MonoBehaviour
// {
//     public controller controller;
//      public Text healthText;
//     public float runSpeed = 40f;

//     float horizontalMove = 0f;
//     bool jump = false;
//     bool crouch = false;
//     Animator anim;
//     public static float health=50;
   
//     void Start(){

//         anim = GetComponent<Animator>();
//         healthText.text="Health " + 0;
//     }
  


//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.RightArrow)){
//             anim.SetBool("iswalk" , true);
//         }

//         if(Input.GetKeyUp(KeyCode.RightArrow)){
//             anim.SetBool("iswalk" , false);

//         }

//         if(Input.GetKeyDown(KeyCode.LeftArrow)){
//             anim.SetBool("iswalk" , true);
//         }

//         if(Input.GetKeyUp(KeyCode.LeftArrow)){
//             anim.SetBool("iswalk" , false);

//         }

//         horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
//         print(horizontalMove);

//             if(Input.touchCount>0){
//                 var touch = Input.GetTouch(0);
//                 if(touch.position.x<Screen.width/2){
//                    transform.Translate(Vector2.right * 45 * Time.fixedDeltaTime);
//                     anim.SetBool("iswalk", true);
//                 }
//                 else if(touch.position.x>Screen.width/2){
//                      transform.Translate(Vector2.left * 45 * Time.fixedDeltaTime);
//                     anim.SetBool("iswalk", true);
//                 }
//             }





//         if (Input.GetKey(KeyCode.Space))
//         {
//             transform.Translate(Vector2.up*Time.deltaTime*20, Space.World);
//         }

//         //if (Input.GetButtonDown("Crouch"))
//         //{
//         //    crouch = true;
//         //}
//         //else if (Input.GetButtonUp("Crouch"))
//         //{
//         //    crouch = false;
//         //}

//     }

//     void FixedUpdate()
//     {
//         // Move our character
//         controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
//         jump = false;
//     }

//      private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.name.StartsWith("enemy"))
//         {
          
//             anim.SetBool("deadBool", true);
//             anim.SetBool("iswalk", false);
//             health-=10;
//         }
//         if (collision.gameObject.name.StartsWith("apple"))
//         {
        
//             health+=10;
//             Destroy(collision.gameObject);
//         }
//         healthText.text="health " + health.ToString();
//     } 
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;

    public controller controller;

    public float runSpeed = 40f;
    private float startTouchPosition, endTouchPosition;
    private Rigidbody2D rb;
    public float m_JumpForce;
    float speed = 0.05f;
    public GameObject cloud;

    private float health =50;
    // private float score = 0;

    public Text HealthText;
    // public Text ScoreText;




    float move = 0f;
    float righthorizontalMove = 40f;
    float lefthorizontalMove = -40f;
    //private bool jumpAllowed = false;

    bool jump = false;
    bool crouch = false;

    void Start()
    {
        HealthText.text = "Health:" + health.ToString();
        // ScoreText.text = "Score:" + score.ToString();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            var touch = Input.GetTouch(i);
            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position.y;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position.y;
                if (endTouchPosition > startTouchPosition)
                {
                    transform.Translate(Vector2.up * 150 * Time.fixedDeltaTime);
                }

            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                controller.Move(lefthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("iswalk", true);
            }
            if (touch.position.x > Screen.width / 2)
            {
                controller.Move(righthorizontalMove * Time.fixedDeltaTime, crouch, jump);
                anim.SetBool("iswalk", true);
            }
        }
        
        else
        {
            anim.SetBool("iswalk", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.StartsWith("cloud"))
        {
            print("coll");

            transform.gameObject.transform.parent = cloud.transform;
        }

        if (collision.gameObject.name.StartsWith("enemy"))
        {
            health -= 10;
            HealthText.text = "Health:" + health.ToString();
            if(health <= 0)
            {
                 anim.SetBool("deadBool", true);
            }
        }

        if (collision.gameObject.name.StartsWith("apple"))
        {
            // score += 10;
            // ScoreText.text = "Score:" + score.ToString();
            Destroy(collision.gameObject);
        }

        
    }
}