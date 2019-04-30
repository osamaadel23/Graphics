using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float navspeed = 7f;
    private float gravity = 12.0f;
    private float verticalVelocity;
    private float movingspeed = 6f;

    public float jumpSpeed = 5.5f;
    private Vector3 moveDirection = Vector3.zero;
    public Rigidbody rb;
    Animator anim;

    public Transform playertransfom;
    public GameObject button;
    public Text restartText;
    public Text WinText;
    public PlayerMovement movement;
    public Text gameOver;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        button = GameObject.Find("Restart1");
        button.SetActive(false);
        restartText.text = "" ;

        
    }

    // Update is called once per frame
    void Update()
    {

        

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection.z = movingspeed;
            //anim.SetBool("isjumping", false);

            moveDirection.x = Input.GetAxisRaw("Horizontal") * navspeed;
        }

        
        if (Input.GetButton("Jump") && controller.isGrounded==true)
            {
            moveDirection.y = jumpSpeed;
            //anim.SetBool("isjumping", true);
        }

        if(playertransfom.position.z >50 && playertransfom.position.z < 100)
        {
            RenderSettings.fogColor = Color.white;
            RenderSettings.fogDensity = 0.1f;
            RenderSettings.fog = true;

        }

       else if (playertransfom.position.z >= 100 && playertransfom.position.z < 150)
        {

            RenderSettings.fog = false;
        }

        else if (playertransfom.position.z >= 150 && playertransfom.position.z < 200)
        {
            RenderSettings.fogDensity = 0.25f;
            RenderSettings.fog = true;
        }

        else if (playertransfom.position.z >= 200 && playertransfom.position.z < 250)
        {

            RenderSettings.fog = false;
        }

        else if (playertransfom.position.z >= 250 && playertransfom.position.z < 300)
        {
            RenderSettings.fogDensity = 0.29f;
            RenderSettings.fog = true;
        }

        else if (playertransfom.position.z >= 300 && playertransfom.position.z < 350)
        {

            RenderSettings.fog = false;
        }

        else if (playertransfom.position.z >= 350 && playertransfom.position.z < 400)
        {
            RenderSettings.fogDensity = 0.3f;
            RenderSettings.fog = true;
        }

        else if (playertransfom.position.z >= 400 && playertransfom.position.z < 450)
        {

            RenderSettings.fog = false;
        }
        else if (playertransfom.position.z >= 450 && playertransfom.position.z < 500)
        {
            RenderSettings.fog = false;
        }
        else if (playertransfom.position.z == 500)
        {
            WinText.text = "You Win !!";
            movement.enabled = false;
        }


        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


        if (playertransfom.position.y < -1)
        {
            showMenu();
        }
    }

    void showMenu()
    {
        RenderSettings.fogColor = Color.black;
        RenderSettings.fogDensity = 0.5f;
        RenderSettings.fog = true;


        
        restartText.text = "Restart";
        button.SetActive(true);
        gameOver.text = "GameOver";
               
        movement.enabled = false;
    }
}
