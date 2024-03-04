using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusHP : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(WaitToDestroyPlusHP(6));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            FindObjectOfType<PlayerHP>().AddHP(60);
            Destroy(gameObject);
        }
    }

    private IEnumerator WaitToDestroyPlusHP(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (gameObject)
        {
            Destroy(gameObject);
        }
    }
}
