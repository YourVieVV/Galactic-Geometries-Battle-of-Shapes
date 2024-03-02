using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private bool isOvalEnemy = false;
    [SerializeField]
    private bool isRotate;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float movementSpeedHorizontal;

    private bool isLeft = false;
    private Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (isOvalEnemy)
        {
            OvalEnemyMovement(isLeft);
        } else {
            myBody.velocity = new Vector2(myBody.velocity.x, movementSpeed);
            if (isRotate)
            {
                transform.Rotate(0, 0, 2.2f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "BorderRight")
        {
            isLeft = true;
        }
        if (collider.tag == "BorderLeft")
        {
            isLeft = false;
        }
    }

    private void OvalEnemyMovement(bool isTest)
    {
        if (isLeft)
        {
            myBody.velocity = new Vector2(-movementSpeedHorizontal, movementSpeed);
            
        } else
        {
            myBody.velocity = new Vector2(+movementSpeedHorizontal, movementSpeed);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
