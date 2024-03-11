using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geraBaloes : MonoBehaviour
{
    public GameObject baloes;
    public GameObject ponte;
    public GameObject luz;
    public GameObject nextScene;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //nextScene.GetComponent<ChangeScene>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ponte.GetComponent<Collider>().enabled == false)
        {
            baloes.SetActive(true);
        }
        
    }
}
