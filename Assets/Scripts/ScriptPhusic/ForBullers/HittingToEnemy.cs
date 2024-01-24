using UnityEngine;

public class HittingToEnemy : MonoBehaviour
{
    public GameObject ExplotionHitEnemy;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" || collider.tag == "EnemySquare")
        {
            Instantiate(ExplotionHitEnemy, transform.position, Quaternion.identity);
            // collision.GetComponent ��� ����, ��� �� ������ ������� � ������ enemy �������� �� ��� ���������
            collider.GetComponent<EnemyHP>().TakeHPEnemy();
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
