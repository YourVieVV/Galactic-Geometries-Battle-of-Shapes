using UnityEngine;

public class DpdgeControl : MonoBehaviour
{
    [SerializeField]
    private DodgePlayerBullet dodgePlayerBulletSrcipt;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "EnemyBullet")
            return;

        dodgePlayerBulletSrcipt.isTriggerCollider = true;
    }
}
