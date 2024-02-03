using UnityEngine;

public class HittingAPlayer : MonoBehaviour
{
    [SerializeField] private GameObject shieldPlayer;
    [SerializeField] private ShieldHP shieldHPScript;

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.tag)
        {
            case "EnemyBullet":
                // collider.GetComponent для того, что бы взять функцию из скрипта того объекта,
                // который ударил игрок
                FindObjectOfType<PlayerHP>().Damage(10);
                collider.GetComponent<EnemyBullet>().BulletHitPlayer();
                break;
            case "Meteorite":
                collider.GetComponent<Meteorite>().HittingMeteorite();
                FindObjectOfType<PlayerHP>().Damage(25);
                break;
            case "Enemy":
                FindObjectOfType<PlayerHP>().Damage(30);
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                break;
            case "EnemySquare":
                FindObjectOfType<PlayerHP>().Damage(30);
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                break;
            case "DropShild":
                shieldHPScript.ReactivateShield();
                break;
            default:
                break;

        }

    }
}
