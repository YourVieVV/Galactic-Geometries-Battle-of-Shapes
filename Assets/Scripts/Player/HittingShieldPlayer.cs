using UnityEngine;

public class HittingShieldPlayer : MonoBehaviour
{
    public GameObject ExplosionHitPlayerShield;
    void OnTriggerEnter2D(Collider2D collider)
    {

        switch (collider.tag)
        {
            case "Meteorite":
                collider.GetComponent<Meteorite>().HittingMeteorite();
                FindObjectOfType<ShieldHP>().Damage(60);
                break;
            case "Enemy":
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                Instantiate(ExplosionHitPlayerShield, transform.position, Quaternion.identity);
                FindObjectOfType<ShieldHP>().Damage(60);
                break;
            case "EnemySquare":
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                Instantiate(ExplosionHitPlayerShield, transform.position, Quaternion.identity);
                FindObjectOfType<ShieldHP>().Damage(60);
                break;
            case "EnemyBullet":
                collider.GetComponent<EnemyBullet>().BulletHitPlayerShield();
                FindObjectOfType<ShieldHP>().Damage(20);
                break;
            default:
                break;

        }
    }
}
