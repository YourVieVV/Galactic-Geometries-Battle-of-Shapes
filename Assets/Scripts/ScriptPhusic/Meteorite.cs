﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public GameObject ExplotionMeteoriteDestroy;
    public GameObject PlusHP;
    public GameObject shildPlayer;
    private float _movementSpeed = 1.5f;
    public float rotateZ = 0f;
    public bool onGround;
    private Rigidbody2D myBody;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        
        onGround = true;
    }
    private void Update()
    {
        myBody.velocity = new Vector2(_movementSpeed, myBody.velocity.y);
        transform.Rotate(new Vector3(0, 0, rotateZ));
    }

    public void HittingMeteorite()
    {
        Instantiate(ExplotionMeteoriteDestroy, transform.position, Quaternion.identity);
        Destroy(gameObject);
        if (Random.Range(5, -5) >= 0)
        {
            Instantiate(PlusHP, transform.position, Quaternion.identity);
        } else
        {
            Instantiate(shildPlayer, transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "EnemySquare")
        {
            collider.GetComponent<EnemyHP>().DestroyEnemy();
            Instantiate(ExplotionMeteoriteDestroy, transform.position, Quaternion.identity);
        }
        if (collider.tag == "PlayerBullet")
        {
            collider.GetComponent<HittingToEnemy>().DestroyPlayerBullet();
        }
        if (collider.tag == "EnemyBullet")
        {
            collider.GetComponent<EnemyBullet>().BulletHitPlayerBullet();
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}