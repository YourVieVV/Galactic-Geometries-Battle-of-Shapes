using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTable : MonoBehaviour
{
    public static bool IsTablet()
    {

        float ssw;
        if (Screen.width > Screen.height) { ssw = Screen.width; } else { ssw = Screen.height; }

        if (ssw < 800) return false;

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            float screenWidth = Screen.width / Screen.dpi;
            float screenHeight = Screen.height / Screen.dpi;
            float size = Mathf.Sqrt(Mathf.Pow(screenWidth, 2) + Mathf.Pow(screenHeight, 2));
            if (size >= 6.5f) return true;
        }

        return false;
    }
}
