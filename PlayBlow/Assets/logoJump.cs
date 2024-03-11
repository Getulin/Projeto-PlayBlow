using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoJump : MonoBehaviour
{
    public float animationSpeed = 1f;
    public float scaleX = 10.3f;
    public float scaleY = 5.6f;

    public float rotateX = 15f;
    public float rotateY = 0f;

    void Start()
    {
        StartJumping();

    }

    public void StartJumping()
    {
        transform.LeanScale(new Vector3(scaleX, scaleY), animationSpeed).setEaseOutBack().setLoopPingPong() ;
        transform.LeanRotate(new Vector3 (rotateX, rotateY), animationSpeed).setEaseOutBack().setLoopPingPong();
        
    }
}
