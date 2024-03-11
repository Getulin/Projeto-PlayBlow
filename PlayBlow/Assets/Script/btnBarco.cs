using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class btnBarco : MonoBehaviour
{
    public float speed = 5.0f;
    private float forwardInput;
    public GameObject barco;

    // Start is called before the first frame update
    void Start()
    {
        forwardInput = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Button>().onClick.AddListener(andaBarco);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void andaBarco()
    {
        
        barco.transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput);
    }
}
