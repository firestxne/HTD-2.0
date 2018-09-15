using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    [SerializeField] Vector3 offset;
    Vector3 smoothSpd = Vector3.zero;
    [SerializeField] float smoothTime;
    [SerializeField] Transform CameraTarget;


    // Update is called once per frame
    void FixedUpdate () {
        Vector3 OffsetPosition = CameraTarget.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, OffsetPosition, ref smoothSpd, smoothTime);
        


    }
}
