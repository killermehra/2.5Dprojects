using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;

public class playercontroller : MonoBehaviour
{
    public float moveSpeed = 5f;
  
    public Button jumpbutton;
    private Rigidbody rigidBody;

    private Animator anim;

    public float jumpForce = 5f;
   
    private bool isGrounded;

    public Joystick joystick;
    public ParticleSystem trail;
 

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        jumpbutton.onClick.AddListener(Jump);

    }

    void Update()
    {

        moveforward();
        
        
        
        if (Mathf.Abs(rigidBody.velocity.y) < 0.01f)
        {
            trail.Play();
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
           
           
        }

        if (joystick.Vertical <= -.3f)
        {
            anim.SetBool("down", true);
        }
        else if(joystick.Vertical > -.3f)
        {
            anim.SetBool("down", false);
        }
        

        if (joystick.Vertical >= .3f)
        {
            anim.SetBool("up", true);
        }
       else if(joystick.Vertical < .3f)
        {
            anim.SetBool("up", false);
        }

    }

    void Jump()
    {
        if (IsGrounded())
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.Play("jump");
            trail.Play();
        }
    }
    bool IsGrounded()
    {
        
        return Mathf.Abs(rigidBody.velocity.y) < 0.01f;
       

        
    }
    void moveforward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }
    

}

   

