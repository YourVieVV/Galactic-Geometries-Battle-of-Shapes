using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPlayerHPTwo : MonoBehaviour
{
    public float currentHealth = 100;
    public GameObject ExplosionPlayer;

    public void Damage(float damageValue)
    {
        Instantiate(ExplosionPlayer, transform.position, Quaternion.identity);
        currentHealth -= damageValue;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
