using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewEnemySpawner : MonoBehaviour
{
    public GameObject EnemySquare;
    public GameObject EnemyIsometric;
    public float TimeToSpawnIsometric = 1;
    public float MoreTimeToSpawnSquare = 1;
    private float randomPosition = 1;
    private float calculatePositionPlus = 0;
    private float calculatePositionMinus = 0;
/*    IList positionsArray = new List<float>();*/
    List<float> positionsArray = new List<float>();
    private TimerText timerText;

    void Start()
    {
        timerText = FindObjectOfType<TimerText>();
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (timerText.timerMin < MoreTimeToSpawnSquare)
        {
            // Debug.Log($"Timer=== {timerText.timerMin}");
            randomPosition = Random.Range(-2.7f, 2.7f);
            calculatePositionPlus = randomPosition + 1;

            Vector2 pos;
            if (!positionsArray.Any(pos => pos > randomPosition - 1 && pos < randomPosition + 1))
            {
                positionsArray.Add(randomPosition);
                pos = new Vector2(randomPosition, transform.position.y);
            } else {
                randomPosition -= Random.Range(-0.5f, 0.5f);
                positionsArray.Add(randomPosition);
                pos = new Vector2(randomPosition, transform.position.y);
            }
            if (positionsArray.Count == 5)
            {
                positionsArray.Clear();
            }
            Instantiate(EnemySquare, pos, Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
        while (timerText.timerMin == TimeToSpawnIsometric)
        {
            randomPosition = Random.Range(-2.7f, 2.7f);
            Vector2 pos = new Vector2(randomPosition, transform.position.y);
            Instantiate(EnemyIsometric, pos, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }

    }
}
