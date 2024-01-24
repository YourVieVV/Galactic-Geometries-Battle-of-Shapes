using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropShild : MonoBehaviour
{
    public GameObject shildPlayer;
    private void Start()
    {
        StartCoroutine(WaitToDestroyDropShild(5));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator WaitToDestroyDropShild(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (gameObject)
        {
            Destroy(gameObject);
        }
    }
}
