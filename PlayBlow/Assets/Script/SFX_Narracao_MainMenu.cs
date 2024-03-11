using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SFX_Narracao_MainMenu : MonoBehaviour
{
    public AudioSource a1;

    public void PlayA1()
    {
        if (a1 != null) a1.Play();
    }
}
