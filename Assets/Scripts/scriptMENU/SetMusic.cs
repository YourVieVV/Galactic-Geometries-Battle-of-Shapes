using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMusic : MonoBehaviour {

    public Slider slider;
    public Text valueCount;

    void Start()
    {
    }
    void Update()
    {

        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value / 2;
    }
}﻿

