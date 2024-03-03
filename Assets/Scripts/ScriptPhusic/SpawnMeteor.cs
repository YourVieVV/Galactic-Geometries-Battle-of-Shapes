using System.Collections;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{

    public GameObject Meteorit;
    private float spawnDelay = 4f;
    private bool isTimeHasCome3;
    private TimerText timerText;


    void Start()
    {
        isTimeHasCome3 = true;
        StartCoroutine(spawn());
    }

    private void Update()
    {
        timerText = FindObjectOfType<TimerText>();
    }

    IEnumerator spawn()
    {
        while (timerText.timerMin < 8)
        {
            if (timerText.timerMin == 2 && isTimeHasCome3)
            {
                spawnDelay -= 1;
                isTimeHasCome3 = false;
            }
            Vector2 pos = new Vector2(transform.position.x, Random.Range(4.2f, -4.2f));
            Instantiate(Meteorit, pos, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
