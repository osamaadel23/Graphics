using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public Score scoreScript;

    // Update is called once per frame
    void Update()
    {
        score.text = "score " + player.position.z.ToString("0");



        if (player.position.y < -1)
        {
            scoreScript.enabled = false;
        }

    



    }

 
}
