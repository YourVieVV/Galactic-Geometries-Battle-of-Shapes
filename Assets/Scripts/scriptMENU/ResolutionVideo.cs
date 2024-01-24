using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionVideo : MonoBehaviour {

    public Dropdown dropdown;
    public Toggle toggle;

    Resolution[] res;

	// Use this for initialization
	void Start () {

        Screen.fullScreen = true;

        toggle.isOn = false;

        Resolution [] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];
        for (int i = 0; i<res.Length; i++)
        {
            // strRes[i] = res[i].ToString();
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(strRes.ToList());
        Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);
	}
	
	public void SetRes()
    {
        Screen.SetResolution(res[dropdown.value].width, res[dropdown.value].height, Screen.fullScreen);
    }
    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
    }
}
