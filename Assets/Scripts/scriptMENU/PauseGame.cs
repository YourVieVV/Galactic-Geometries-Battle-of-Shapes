using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [HideInInspector]
    public bool isPaused;
    [SerializeField]
    private KeyCode pauseButton;
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private PlayerController playerControllerScript;
    [SerializeField]
    private Joystick joystickMove;


    void Update()
    {
        if (Input.GetKeyDown(pauseButton))
        {
            isPaused = !isPaused;
            PauseAndSetActivePanelFunction(isPaused, panelPause);
        }
    }

    public void PauseAndSetActivePanelFunction(bool isPaused, GameObject panel)
    {
        if (isPaused)
        {
            panel.SetActive(true);
            if (joystickMove.gameObject)
                joystickMove.gameObject.SetActive(false);
            Time.timeScale = 0;
            if (playerControllerScript)
            {
                playerControllerScript.enabled = false;
            }
        }
        else
        {
            panel.SetActive(false);
            if (joystickMove.gameObject)
                joystickMove.gameObject.SetActive(true);
            Time.timeScale = 1;
            if (playerControllerScript)
            {
                playerControllerScript.enabled = true;
            }
        }
    }

}
