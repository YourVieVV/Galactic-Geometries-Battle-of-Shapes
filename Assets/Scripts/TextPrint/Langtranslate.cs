using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Langtranslate : MonoBehaviour
{
    private string lang;
    private Text theText;
    public string textRu;
    public string textEn;
    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();
        lang = PlayerPrefs.GetString("Lang");
        if (lang == "ru")
        {
            theText.text = textRu;
        }
        else
        {
            theText.text = textEn;
        }
    }
}
