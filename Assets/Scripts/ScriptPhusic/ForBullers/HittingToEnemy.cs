using UnityEngine;

public class HittingToEnemy : MonoBehaviour
{
    public GameObject ExplotionHitEnemy;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy" || collider.tag == "EnemySquare")
        {
            Instantiate(ExplotionHitEnemy, transform.position, Quaternion.identity);
            // collision.GetComponent для того, что бы движок понимал у какого enemy отнимать хп при попадании
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
