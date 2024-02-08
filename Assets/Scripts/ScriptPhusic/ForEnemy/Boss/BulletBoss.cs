using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
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
}
