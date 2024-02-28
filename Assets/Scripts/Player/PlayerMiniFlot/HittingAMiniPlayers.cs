using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingAMiniPlayers : MonoBehaviour
{
    [SerializeField]
    private bool isMiniPlayerOne = false,
        isMiniPlayerTwo = false;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (isMiniPlayerOne)
        {
            switch (collider.tag)
            {
                case "EnemyBullet":
                    // collider.GetComponent для того, что бы взять функцию из скрипта того объекта,
                    // который ударил игрок
                    FindObjectOfType<MiniPlayerHP>().Damage(25);
                    collider.GetComponent<EnemyBullet>().BulletHitPlayer();
                    break;
                case "Meteorite":
                    collider.GetComponent<Meteorite>().HittingMeteorite();
                    FindObjectOfType<MiniPlayerHP>().Damage(60);
                    break;
                case "Enemy":
                    FindObjectOfType<MiniPlayerHP>().Damage(60);
                    collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                    break;
                case "EnemySquare":
                    FindObjectOfType<MiniPlayerHP>().Damage(60);
                    collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                    break;
                default:
                    break;

            }
        }
        if (isMiniPlayerTwo)
        {
            switch (collider.tag)
            {
                case "EnemyBullet":
                    // collider.GetComponent для того, что бы взять функцию из скрипта того объекта,
                    // который ударил игрок
                    FindObjectOfType<MiniPlayerHPTwo>().Damage(25);
                    collider.GetComponent<EnemyBullet>().BulletHitPlayer();
                    break;
                case "Meteorite":
                    collider.GetComponent<Meteorite>().HittingMeteorite();
                    FindObjectOfType<MiniPlayerHPTwo>().Damage(60);
                    break;
                case "Enemy":
                    FindObjectOfType<MiniPlayerHPTwo>().Damage(60);
                    collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                    break;
                case "EnemySquare":
                    FindObjectOfType<MiniPlayerHPTwo>().Damage(60);
                    collider.GetComponent<EnemyHP>().HittingEnemyByPlayer();
                    break;
                default:
                    break;

            }
        }
        
    }

}
