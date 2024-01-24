using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ExplotionEnemyDestroy;
    public float enemyHP = 100;
    public float damageByEnemy = 50;

    public void TakeHPEnemy()
    {
        enemyHP -= damageByEnemy;
        if (enemyHP <= 0)
        {
            DestroyEnemy();
            FindObjectOfType<Score>().CounterScope(10);
        }
    }

    public void HittingEnemyByPlayer()
    {
        DestroyEnemy();
        FindObjectOfType<Score>().CounterScope(10);
    }

    public void DestroyEnemy()
    {
        Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
