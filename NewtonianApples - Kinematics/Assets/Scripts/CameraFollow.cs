using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offest;
    public float damping;

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        // Vector3 movePosition = Player.position + offest;
        // transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
    }
}