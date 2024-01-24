using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private PlayerController player;
    private float angle;
    private Vector2 A, B, C;
    private float currentHealth = 20;
    private float minHealth = 0;
    public GameObject Explotion;

     void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
        
    public float checkAngle()
    {
        A = new Vector2(transform.position.x, transform.position.y);
        B = new Vector2(player.transform.position.x, player.transform.position.y);
        C = B - A;

        angle = Mathf.Atan2(C.y, C.x) * Mathf.Rad2Deg;
        angle = Mathf.Round(angle/3) * 3;

        return angle;


    }

    public void EnemyDamage()
    {
        float damage = 10;
        currentHealth -= damage;
        
        if (currentHealth <= minHealth)
        {
            Destroy(gameObject);
            Instantiate(Explotion, transform.position, Quaternion.identity);
        }

    }
}
