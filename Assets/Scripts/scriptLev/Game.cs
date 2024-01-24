using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    public GameObject pause;
    private TimerText timer;
    private PlayerHP hp;

    private void Start()
    {
        timer = FindObjectOfType<TimerText>();
        hp = FindObjectOfType<PlayerHP>();
    }

    // Update is called once per frame
    void Update () {
        #region CheckWin
        if (timer.startingTimer <= 0 && hp.currentHealth > 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == LevelManager.countUnlockedLevel)
            {
                LevelManager.countUnlockedLevel++;
            }
            Debug.Log("win");
            //SceneManager.LoadScene(12);
        }
        #endregion

        #region CheckLose
        if(hp.currentHealth <= 0)
        {
            Debug.Log("lose");
            StartCoroutine(WaitAndThenDoSomething(1));
        }
        #endregion
    }

    private IEnumerator WaitAndThenDoSomething(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<PauseGame>().PauseGameFunction(true, pause);
    }

}
