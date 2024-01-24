using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalForPlayer : MonoBehaviour
{
    [SerializeField] private Transform toPortal;

    public static bool isTpActive;
    public bool isOpenPortal = false;

    void Start()
    {
        isTpActive = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isOpenPortal)
        {
            if (collision.tag == "Player")
            {
                if (isTpActive)
                {
                    Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
                    isTpActive = false;
                    float magnitude = rb.velocity.magnitude;
                    rb.velocity = Vector3.zero;
                    Vector3 direction = toPortal.transform.TransformDirection(Vector3.right) - transform.TransformDirection(Vector3.left);
                    collision.transform.position = new Vector3(toPortal.transform.position.x, collision.transform.position.y, collision.transform.position.z);
                    rb.AddForce(direction * magnitude, ForceMode2D.Impulse);
                }
                else isTpActive = true;
            }
        }
    }
}
