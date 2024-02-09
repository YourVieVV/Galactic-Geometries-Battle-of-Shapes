using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBoss : MonoBehaviour
{
    public GameObject expotionShield;
    private float shieldHP = 120;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "DropShield")
        {
            shieldHP -= 60;
        } if (collision.tag == "PlayerBullet")
        {
            shieldHP -= 10;
        }
    }

    void Update()
    {
        if (shieldHP <= 0)
        {
            Instantiate(expotionShield, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
