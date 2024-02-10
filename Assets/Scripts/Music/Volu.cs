using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("musicVolume") > 10f)
        {
            AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
        } else
        {
            AudioListener.volume = 100;
        }
        
    }
}
