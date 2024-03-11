using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveNuvem : MonoBehaviour
{

    [SerializeField] public int movespeed = 1;
    [SerializeField] public GameObject destroyerWall;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
  
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destroyerWall")
        {
            Destroy(this.gameObject);
        }

    }

}
