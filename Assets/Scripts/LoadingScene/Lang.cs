using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lang : MonoBehaviour
{
    private string lang;
    // Start is called before the first frame update
    void Start()
    {
        if (Application.systemLanguage.ToString() == "Russian")
        {
            lang = "ru";
        }
        else
        {
            lang = "en";
        }
        PlayerPrefs.SetString("Lang", lang);
    }
}
