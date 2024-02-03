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
                //FindObjectOfType<PlayerHP>().Damage(25);
                break;
            case "Enemy":
                //FindObjectOfType<PlayerHP>().Damage(30);
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                break;
            case "EnemySquare":
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                Instantiate(ExplosionHitPlayerShield, transform.position, Quaternion.identity);
                FindObjectOfType<ShieldHP>().Damage(65);
                break;
            case "EnemyBullet":
                collider.GetComponent<EnemyBullet>().BulletHitPlayerShield();
                FindObjectOfType<ShieldHP>().Damage(35);
                break;
            default:
                break;

        }
    }
}
