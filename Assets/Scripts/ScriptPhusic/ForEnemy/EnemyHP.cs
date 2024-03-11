using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public GameObject ExplotionEnemyDestroy;
    public GameObject ExplotionEnemyDestroyTablet;

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
        if (!IsTablet())
        {
            Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(ExplotionEnemyDestroyTablet, transform.position, Quaternion.identity);
        }
    }

    public void HittingEnemyByPlayer()
    {
        DestroyEnemy();
        FindObjectOfType<Score>().CounterScope(10);
    }

    public static bool IsTablet()
    {

        float ssw;
        if (Screen.width > Screen.height) { ssw = Screen.width; } else { ssw = Screen.height; }

        if (ssw < 800) return false;

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            float screenWidth = Screen.width / Screen.dpi;
            float screenHeight = Screen.height / Screen.dpi;
            float size = Mathf.Sqrt(Mathf.Pow(screenWidth, 2) + Mathf.Pow(screenHeight, 2));
            if (size >= 6.5f) return true;
        }

        return false;
    }

    public void DestroyEnemy()
    {
        if (!IsTablet())
        {
            Instantiate(ExplotionEnemyDestroy, transform.position, Quaternion.identity);
        } else
        {
            Instantiate(ExplotionEnemyDestroyTablet, transform.position, Quaternion.identity);
        }
            
        Destroy(gameObject);
    }

}
