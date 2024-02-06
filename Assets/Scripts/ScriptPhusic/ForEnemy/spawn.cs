using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public int waveNumber;
    public int enemiesPerWave = 10;
    public GameObject enemy;
    public int currentNumberOfEnemies = 5;
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        
        while (true)
        {
            
            if (currentNumberOfEnemies <= 1)
            {
                waveNumber++;
                
                float randDirection;
                float randDistance;
                for (int i = 0; i < enemiesPerWave; i++)
                {
                    randDistance = Random.Range(10, 25);
                    randDirection = Random.Range(0, 360);
                    float posX = this.transform.position.x + (Mathf.Cos((randDirection) * Mathf.Deg2Rad) * randDistance);
                    float posY = this.transform.position.y + (Mathf.Cos((randDirection) * Mathf.Deg2Rad) * randDistance);
                    Instantiate(enemy, new Vector3(posX, posY, 0), this.transform.rotation);
                    currentNumberOfEnemies++;
                    
                }
            }
            yield return new WaitForSeconds(3f);

        }
    }
}
