using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject ExplotionEnemyDestroy;

    public bool isCapsule = false;
    public bool isCirlce = false;
    public bool isRectangle = false;
    public bool isHexagon = false;
    public bool isOval = false;
    public bool isIsometric = false;

    private float enemyHP;

    private void Start()
    {
        if (isCirlce)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpCircle);
        }
        if (isRectangle)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpRectangle);
        }
        if (isOval)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpOval);
        }
        if (isIsometric)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpIsometric);
        }
        if (isHexagon)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpHexagon);
        }
        if (isCapsule)
        {
            enemyHP = PlayerPrefs.GetFloat(EmenyStats.hpCapsule);
        }
    }

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
