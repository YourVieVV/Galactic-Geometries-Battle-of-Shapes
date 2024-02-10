using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMusic : MonoBehaviour {

    public Slider slider;
    public Text valueCount;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    void Update()
    {
        valueCount.text = slider.value.ToString();
        if (AudioListener.volume == slider.value)
        {
            PlayerPrefs.SetFloat("musicVolume", slider.value);
        }
        AudioListener.volume = slider.value;
    }
}﻿

