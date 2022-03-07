using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    Animator anim;
    private bool m_FacingRight = true;
    // Start is called before the first frame update
    private Rigidbody2D rb;
    void Start()
    {
         anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D> ();
        anim.SetBool("slide", false);
        anim.SetBool("jump", false);
        anim.SetBool("run", false);
       
        anim.SetBool("idle", true);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          if (Input.GetKey(KeyCode.R))
        {
            anim.SetBool("run", true);
            transform.Translate(0.02f, 0, 0);
        }
          if (Input.GetKey(KeyCode.L))
        {
            anim.SetBool("run", true);
            transform.Translate(-0.02f, 0, 0);
            Flip();
            anim.SetBool("jump", false);
        }
           if (Input.GetKey(KeyCode.J))
        {
            anim.SetBool("jump", true);
            transform.Translate(Vector2.up*Time.deltaTime*20, Space.World);
          anim.SetBool("slide", true);
          anim.SetBool("run",false);
        }
      
    }


        private void Flip()
    {
     
        m_FacingRight = !m_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
