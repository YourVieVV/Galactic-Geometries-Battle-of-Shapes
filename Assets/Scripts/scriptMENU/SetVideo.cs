using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SetVideo : MonoBehaviour {

    public Dropdown dropDown; 


    void Start()
    {
        //QualitySettings.names;
        dropDown.ClearOptions();
        dropDown.AddOptions(QualitySettings.names.ToList());
        dropDown.value = QualitySettings.GetQualityLevel();
    }
    
    void Update()
    {

    }
    public void SetQuality()
    {
        QualitySettings.SetQualityLevel(dropDown.value);
    }
    
}﻿

