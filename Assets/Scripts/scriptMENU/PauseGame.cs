using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {
    [HideInInspector]
    public bool isPaused;
    [SerializeField]
    private KeyCode pauseButton;
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private GameObject player;
    PlayerController controller;

    void Start () {
        controller = player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(pauseButton))
        {
            isPaused = !isPaused;
            PauseGameFunction(isPaused, panelPause);
        }
	}

    public void PauseGameFunction(bool isPaused, GameObject panel)
    {
        if (isPaused)
        {
            panel.SetActive(true);
            //cursor.visible = true;
            //cursor.lockstate = cursorLockMode.none;
            Time.timeScale = 0;
            if (controller)
            {
                controller.enabled = false;
            }
        }
        else
        {
            panel.SetActive(false);
            Time.timeScale = 1;
            if (controller)
            {
                controller.enabled = true;
            }
        }
    }
     
}
