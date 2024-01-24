using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemyMovie : MonoBehaviour
{
    public float movementSpeed = -0.5f;
    public float movementSpeedHorizontal = -3f;
    public bool isCircleEnemy = false;
    private bool isLeft = false;
    private Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector2(transform.position.x, transform.position.y - movementSpeed);

        if (isCircleEnemy)
        {
            CircleEnemyMovement(isLeft);
        } else {
            EnemyMovement();
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
