using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {

    public float startingTimer;
    [HideInInspector]
    public float timerMin = 0;

    private Text theText;

    private PauseGame thePauseMenu;

	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();
        thePauseMenu = FindObjectOfType<PauseGame>();
    }


	void Update () {

        if (thePauseMenu.isPaused)
            return;
        
            
        startingTimer += Time.deltaTime;

        if (startingTimer > 59){
            timerMin += 1;
            startingTimer = 0;
        };

        theText.text = $"Time lived - {Mathf.Round(timerMin)} : {Mathf.Round(startingTimer)}";
	}
}
