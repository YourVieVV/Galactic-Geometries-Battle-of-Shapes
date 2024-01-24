using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour {

    public GameObject Meteorit;
    private float spawnDelay = 5f;
    private bool isTimeHasCome3 = true;
    private bool isTimeHasCome6 = true;
    private TimerText timerText;


    void Start()
    {
        timerText = FindObjectOfType<TimerText>();
        StartCoroutine(spawn());
    }


    IEnumerator spawn()
    {
        while (timerText.timerMin < 8)
        {
            if (timerText.timerMin == 3 && isTimeHasCome3)
            {
                spawnDelay -= 1;
                isTimeHasCome3 = false;
            }
            if (timerText.timerMin == 6 && isTimeHasCome6)
            {
                spawnDelay -= 1;
                isTimeHasCome6 = false;
            }
            Vector2 pos = new Vector2(transform.position.x, Random.Range(4.5f,-4.5f));
            Instantiate(Meteorit, pos, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
