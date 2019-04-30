using UnityEngine;
using UnityEngine.UI;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    Animator anim;
    public Text gameOver;
    public GameObject button;
    public Text restartText;
    public Transform playertransform;

    public void Start()
    {
        anim = GetComponent<Animator>();
        button = GameObject.Find("Restart1");
    }
    void OnCollisionEnter(Collision CollisioInfo)
    {
        if (CollisioInfo.collider.tag == "Obstacle" || playertransform.position.y < -1)
        {
            
            restartText.text = "Restart";
            gameOver.text = "GameOver";
            
            button.SetActive(true);
            movement.enabled = false;



        }
    }
}
