using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform lookAt;
    public Vector3 startOffset;
    public Transform player;
    public CameraMovement cameraScript;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + startOffset;

        if(player.position.x >3 || player.position.x < -3 || player.position.y < -1.5)
        {
            cameraScript.enabled = false;
        }
    }
}
