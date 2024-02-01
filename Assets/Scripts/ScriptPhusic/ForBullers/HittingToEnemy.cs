using UnityEngine;

public class HittingToEnemy : MonoBehaviour
{
    public GameObject ExplotionHitEnemy;
    
    // �� ������� ���������� �����
    //private int damagePlayer;

    //private void Start()
    //{
      //  damagePlayer = PlayerPrefs.GetInt
    //}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" || collider.tag == "EnemySquare")
        {
            // collision.GetComponent ��� ����, ��� �� ������ ������� � ������ enemy �������� �� ��� ���������
            collider.GetComponent<EnemyHP>().TakeHPEnemy(100);
            DestroyPlayerBullet();
        }
        if (collider.tag == "EnemyBullet")
        {
            collider.GetComponent<EnemyBullet>().BulletHitPlayerBullet();
            DestroyPlayerBullet();
        }
    }

    public void DestroyPlayerBullet()
    {
        Destroy(gameObject);
    }
}
