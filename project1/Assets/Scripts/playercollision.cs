using UnityEngine;
using UnityEngine.UI;

public class playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    Animator anim;
    public Text gameOver;
    public GameObject btn;
    public Text restartText;
    public Transform playertransform;

    public void Start()
    {
        //anim = GetComponent<Animator>();
        //button = GameObject.Find("Restart1");
    }
    void OnCollisionEnter(Collision CollisioInfo)
    {
        if (CollisioInfo.collider.tag == "Obstacle")
        {
            RenderSettings.fogColor = Color.black;
            RenderSettings.fogDensity = 0.5f;
            RenderSettings.fog = true;

            movement.enabled = false;
            
            btn.SetActive(true);
            restartText.text = "Restart";
            gameOver.text = "GameOver";
            

        }
    }
}
