using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    Rigidbody2D myrigitbody;
    public float moveSpeed;

    void Start()
    {
        myrigitbody = GetComponent<Rigidbody2D>();
        myrigitbody.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    //оставил для примера
    //void OnTriggerEnter2D(Collider2D collision2D)
    //{
       // if (collision2D.GetComponent<ITackeDamage>() != null)
         //   {
             //   collision2D.GetComponent<ITackeDamage>().TakeDamage();
             //   Destroy(gameObject);
           // }   
   // }
}

