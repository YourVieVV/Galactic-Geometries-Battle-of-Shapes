using UnityEngine;

public class BulletFly : MonoBehaviour
{
    Rigidbody2D myrigitbody;
    public float moveSpeed;
    [SerializeField]
    private bool isRocket = false;

    void Start()
    {
        myrigitbody = GetComponent<Rigidbody2D>();

        myrigitbody.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);

    }

    private void Update()
    {
        if (isRocket)
            transform.Rotate(0, 0, 1);
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

