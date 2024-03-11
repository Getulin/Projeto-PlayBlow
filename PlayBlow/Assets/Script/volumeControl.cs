using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeControl : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] public AudioSource a1;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("globalVolume"))
        {
            PlayerPrefs.SetFloat("globalVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
        
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        a1.Play();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("globalVolume", volumeSlider.value);
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("globalVolume");
    }

}
