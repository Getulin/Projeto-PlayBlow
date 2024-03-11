using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barcoCollider : MonoBehaviour
{
    public GameObject ponte1;
    public GameObject ponte2;
    public GameObject ponte3;

    public GameOverScreen GameOverScreen;

    private void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "ponte1":
                ponte1.GetComponent<Collider>().enabled = false;
                break;
            case "ponte2":
                ponte2.GetComponent<Collider>().enabled = false;
                break;
            case "ponte3":
                ponte3.GetComponent<Collider>().enabled = false;
                Rigidbody.Destroy(this);
                break;

        }
    }
}
