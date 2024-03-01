using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.1f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {

    }

    private void LateUpdate()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z;

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    //void Update()
    //{
    //    // Define a target position above and behind the target transform
    //    Vector3 targetPosition = target.position + offset;
    //    targetPosition.z = transform.position.z;

    //    // Smoothly move the camera towards that target position
    //    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    //}
}

