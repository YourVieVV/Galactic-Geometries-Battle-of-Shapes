using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingAPlayer : MonoBehaviour {

    public bool isShildActive = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (isShildActive)
        {

        } else {
            if (collider.tag == "EnemyBullet")
            {
                // collider.GetComponent для того, что бы взять функцию из скрипта того объекта,
                // который ударил игрок

                FindObjectOfType<PlayerHP>().Damage(10);
                collider.GetComponent<EnemyBullet>().BulletHitPlayer();
            }
            if (collider.tag == "Meteorite")
            {
                collider.GetComponent<Meteorite>().HittingMeteorite();
                FindObjectOfType<PlayerHP>().Damage(25);
            }
            if (collider.tag == "Enemy" || collider.tag == "EnemySquare")
            {
                FindObjectOfType<PlayerHP>().Damage(30);
                collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
            }
        }
    }
}
