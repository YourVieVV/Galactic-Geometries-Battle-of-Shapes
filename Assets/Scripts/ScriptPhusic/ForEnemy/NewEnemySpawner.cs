using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewEnemySpawner : MonoBehaviour
{
    private const float TimeToSpawnHexagon = 5;
    private const float TimeToSpawnIsometric = 1;
    private const float TimeToSpawnSquare = 0;
    private const float TimeToSpawnOval = 2;
    private const float TimeToSpawnCircle = 4;
    private const float TimeToSpawnCapsule = 3;

    [SerializeField]
    private TimerText timerTextScript;
    [SerializeField]
    private GameObject EnemySquare;
    [SerializeField]
    private GameObject EnemyHexagon;
    [SerializeField]
    private GameObject EnemyIsometric;
    [SerializeField]
    private GameObject EnemyOval;
    [SerializeField]
    private GameObject EnemyCircle;
    [SerializeField]
    private GameObject EnemyCapsule;

    private float randomPosition = 1;
    private bool startCoroutineSquare = true;
    private bool startCoroutineCapsule = true;
    private bool startCoroutineHexagon = true;
    private bool startCoroutineIsometric = true;
    private bool startCoroutineOval = true;
    private bool startCoroutineCircle = true;

    private float currentTime;
    private List<float> positionsArray = new();

    void Start()
    {

        currentTime = timerTextScript.timerMin;
    }
    private void Update()
    {
        switch (timerTextScript.timerMin)
        {
            case TimeToSpawnSquare:
                if (startCoroutineSquare)
                {
                    StartCoroutine(SpawnSquare());
                    startCoroutineSquare = false;
                }
                break;
            case TimeToSpawnCapsule:
                if (startCoroutineCapsule)
                {
                    StartCoroutine(SpawnCapsule());
                    startCoroutineCapsule = false;
                }
                break;
            case TimeToSpawnHexagon:
                if (startCoroutineHexagon)
                {
                    StartCoroutine(SpawnHexagon());
                    startCoroutineHexagon = false;
                }
                break;
            case TimeToSpawnCircle:
                if (startCoroutineCircle)
                {
                    StartCoroutine(SpawnCircle());
                    startCoroutineCircle = false;
                }
                break;
            case TimeToSpawnOval:
                if (startCoroutineOval)
                {
                    StartCoroutine(SpawnOval());
                    startCoroutineOval = false;
                }
                break;
            case TimeToSpawnIsometric:
                if (startCoroutineIsometric)
                {
                    StartCoroutine(SpawnIsometric());
                    startCoroutineIsometric = false;
                }
                break;
            default: break;
        }
    }

    IEnumerator SpawnOval()
    {
        while (timerTextScript.timerMin == TimeToSpawnOval)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemyOval, position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator SpawnIsometric()
    {
        while (timerTextScript.timerMin == TimeToSpawnIsometric)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemyIsometric, position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator SpawnCircle()
    {
        while (timerTextScript.timerMin == TimeToSpawnCircle)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemyCircle, position, Quaternion.identity);
            yield return new WaitForSeconds(2.4f);
        }
    }

    IEnumerator SpawnCapsule()
    {
        Debug.Log(timerTextScript.timerMin);
        while (timerTextScript.timerMin == TimeToSpawnCapsule)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemyCapsule, position, Quaternion.identity);
            yield return new WaitForSeconds(1.6f);
        }
    }

    IEnumerator SpawnSquare()
    {
        while (timerTextScript.timerMin == TimeToSpawnSquare)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemySquare, position, Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
    }

    IEnumerator SpawnHexagon()
    {
        while (timerTextScript.timerMin == TimeToSpawnHexagon)
        {
            Vector3 position = CalcPosInstans();
            Instantiate(EnemyHexagon, position, Quaternion.identity);
            yield return new WaitForSeconds(1.6f);
        }
    }

    private Vector3 CalcPosInstans()
    {
        randomPosition = Random.Range(-2.7f, 2.7f);

        Vector3 pos;
        if (!positionsArray.Any(pos => pos >= randomPosition - 1 && pos <= randomPosition + 1))
        {
            positionsArray.Add(randomPosition);
            pos = new Vector3(randomPosition, transform.position.y, transform.position.z);
        }
        else
        {
            randomPosition -= Random.Range(-1f, 1f);
            if (randomPosition < -2.6)
            {
                randomPosition += 1.5f;
            }
            if (randomPosition > 2.6)
            {
                randomPosition -= 1.5f;
            }
            positionsArray.Add(randomPosition);
            pos = new Vector3(randomPosition, transform.position.y, transform.position.z);
        }
        if (positionsArray.Count == 5)
        {
            positionsArray.Clear();
        }
        return pos;
    }
}
