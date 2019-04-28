using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float navspeed = 7f;
    private float gravity = 12.0f;
    private float verticalVelocity;
    private float movingspeed = 6f;
    private bool isGrounded;

    public float jumpSpeed = 5.5f;
    private Vector3 moveDirection = Vector3.zero;
    public Rigidbody rb;
    Animator anim;




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection.z = movingspeed;
            anim.SetBool("isjumping", false);

            moveDirection.x = Input.GetAxisRaw("Horizontal") * navspeed;

        }

        
        if (Input.GetButton("Jump") && controller.isGrounded==true)
            {
            moveDirection.y = jumpSpeed;
            anim.SetBool("isjumping", true);
        }


        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
}
