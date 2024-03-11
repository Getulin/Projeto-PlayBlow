using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButtonAudio : MonoBehaviour
{
    public AudioSource a1;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayA1()
    {
        a1.Play();
    }
}
