using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject ExplotionEnemyDestroy;
    public float enemyHP = 100;

    public void TakeHPEnemy(int damage)
    {
        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            DestroyEnemy();
            FindObjectOfType<Score>().CounterScope(10);
            return;
        }
        Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
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
