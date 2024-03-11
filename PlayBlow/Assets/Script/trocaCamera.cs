using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class trocaCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(trocaCam);

    }

    // Update is called once per frame
    void Update()
    {
       

    }
    private void trocaCam()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
    }
}
