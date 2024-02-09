using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody2D myrigitbody;
    public bool isMovieBulletEnemy = false;
    public float moveSpeed;
    public GameObject ExplosionBullet;
    public GameObject ExplosionHitPlayer;
    public GameObject ExplosionHitPlayerShield;
    public bool isBossBullet = false;

    void Start()
    {
        if (!isBossBullet)
        {
            myrigitbody = GetComponent<Rigidbody2D>();
            if (isMovieBulletEnemy)
            {
                //transform.rotation = Quaternion.Euler(transform.rotation.x + 10, transform.rotation.y -10, transform.rotation.z + 10);
                //myrigitbody.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);

            }
            else
            {
                myrigitbody.AddRelativeForce(Vector2.down * moveSpeed, ForceMode2D.Impulse);
            }
        } 
        
    }

    public void BulletHitPlayer()
    {
        Instantiate(ExplosionHitPlayer, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void BulletHitPlayerBullet()
    {
        Instantiate(ExplosionBullet, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void BulletHitPlayerShield()
    {
        Instantiate(ExplosionHitPlayerShield, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
