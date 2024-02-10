using UnityEngine;

public class HittingToEnemy : MonoBehaviour
{
    public GameObject ExplotionHitEnemy;
    public GameObject ExplosionShieldBoss;
    public GameObject ExplosionMeteorite;
    // Этот скрипт для пуль игрока
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "Enemy" || collider.tag == "EnemySquare")
        {
            // collision.GetComponent для того, что бы движок понимал у какого enemy отнимать хп при попадании
            collider.GetComponent<EnemyHP>().TakeHPEnemy(100);
            DestroyPlayerBullet();
        }
        if (collider.tag == "EnemyBullet")
        {
            collider.GetComponent<EnemyBullet>().BulletHitPlayerBullet();
            DestroyPlayerBullet();
        }
        if (collider.tag == "ShieldBoss")
        {
            Instantiate(ExplosionShieldBoss, transform.position, Quaternion.identity);
            DestroyPlayerBullet();
        }
        if (collider.tag == "Meteorite")
        {
            Instantiate(ExplosionMeteorite, transform.position, Quaternion.identity);
            DestroyPlayerBullet();
        }
    }

    public void DestroyPlayerBullet()
    {
        Destroy(gameObject);
    }
}
