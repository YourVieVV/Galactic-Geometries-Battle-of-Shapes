using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemyMovie : MonoBehaviour
{
    [SerializeField]
    private bool isCircleEnemy = false;
    [SerializeField]
    private bool isRotate;
    [SerializeField]
    private float movementSpeed = -0.5f;
    [SerializeField]
    private float movementSpeedHorizontal = -3f;

    private bool isLeft = false;
    private Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isCircleEnemy)
        {
            CircleEnemyMovement(isLeft);
        } else {
            EnemyMovement();
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

    private void CircleEnemyMovement(bool isTest)
    {
        if (isLeft)
        {
            myBody.velocity = new Vector2(-movementSpeedHorizontal, movementSpeed);
            
        } else
        {
            myBody.velocity = new Vector2(+movementSpeedHorizontal, movementSpeed);
        }
    }

    private void EnemyMovement()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, movementSpeed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
