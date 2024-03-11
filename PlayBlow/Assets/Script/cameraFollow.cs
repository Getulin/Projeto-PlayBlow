using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{


    private Vector3 offset = new Vector3(0f, 0f, 0f);
    [SerializeField] public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] public Camera cam;

    [SerializeField] private Transform target;

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        cam.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
