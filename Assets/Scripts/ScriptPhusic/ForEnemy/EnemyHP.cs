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
    public bool isBoss = false;

    public bool isBossDead = false;

    public float enemyHP;

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
        if (isBoss)
        {
            enemyHP = 1000f;
        }
    }

    public void TakeHPEnemy(int damage)
    {
        enemyHP -= damage;
        if (enemyHP <= 0)
        {
            if (isBoss)
            {
                isBossDead = true;
            }
            DestroyEnemy();
            FindObjectOfType<Score>().CounterScope(10);
            return;
        }
        if (ExplotionEnemyDestroy != null)
            Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
    }

    public void HittingEnemyByPlayer()
    {
        DestroyEnemy();
        FindObjectOfType<Score>().CounterScope(10);
    }

    public void DestroyEnemy()
    {
        if (ExplotionEnemyDestroy != null)
            Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
