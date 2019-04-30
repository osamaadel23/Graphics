using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform lookAt;
    public Vector3 startOffset;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + startOffset;
    }
}
