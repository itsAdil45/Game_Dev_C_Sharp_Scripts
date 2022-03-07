// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DinoScript : MonoBehaviour
// {
//     Animator anim;
//     private Rigidbody2D r;
//     private bool m_FacingRight = true;
//     // Start is called before the first frame update
//     void Start()
//     {
//         anim = GetComponent<Animator>();
//          anim.SetBool("isdead", false);
//         anim.SetBool("iswalk", false);
//         anim.SetBool("isjump", false);
//         anim.SetBool("isrun", false);
       
//         anim.SetBool("isidle", true);

//         r = GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.RightArrow))
//         {
//             anim.SetBool("iswalk", true);
//             transform.Translate(0.02f, 0, 0);
//         }

//         if (Input.GetKey(KeyCode.LeftArrow))
//         {
//             anim.SetBool("iswalk", true);
//             transform.Translate(-0.05f, 0, 0);
//             Flip();
//         }

//         if (Input.GetKey(KeyCode.Space))
//         {
//             transform.Translate(Vector2.up*Time.deltaTime*50, Space.World);
//             // r.AddForce(Vector2.up * 20);
//             // anim.SetBool("isjump", true);
//         }

//         if (Input.GetKey(KeyCode.R))
//         {
           
//             anim.SetBool("isrun", true);
//         }

//         Vector2 pos = transform.position;

//         if (pos.x >= 36)
//         {
//             pos.x = 0;
//             transform.position = pos;
//         }

//     }

//     private void Flip()
//     {
//         // Switch the way the player is labelled as facing.
//         m_FacingRight = !m_FacingRight;

//         // Multiply the player's x local scale by -1.
//         Vector3 theScale = transform.localScale;
//         theScale.x *= -1;
//         transform.localScale = theScale;
//     }


// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DinoScript : MonoBehaviour
// {
//     Animator anim;
//     // Start is called before the first frame update
//     void Start()
//     {
//         anim = GetComponent<Animator>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        // if(Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     transform.Translate(Vector2.right * 45 * Time.fixedDeltaTime);
        //     anim.SetBool("iswalk", true);
        // }

        // if (Input.GetKeyUp(KeyCode.RightArrow))
        // {
        //     anim.SetBool("iswalk", false);
        // }

        // if(Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     transform.Translate(Vector2.left * 45 * Time.fixedDeltaTime);
        //     anim.SetBool("iswalk", true);
        // }

        // if (Input.GetKeyUp(KeyCode.LeftArrow))
        // {
        //     anim.SetBool("iswalk", false);
        // }

     

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     transform.Translate(Vector2.up * 180 * Time.fixedDeltaTime);
            
        // }

    //     Vector2 pos = transform.position;
    //     if(pos.x>=50)
    //     {
    //         pos.x = -6;
    //         transform.position = pos;
    //     }
    // }
//     }
//     private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.name.StartsWith("Saw"))
//         {
//             print("collisionDino");
//             anim.SetTrigger("deadTrigger");
//         }
//     }
// }
