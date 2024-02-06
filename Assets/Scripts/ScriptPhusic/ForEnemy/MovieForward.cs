using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieForward : MonoBehaviour, ITackeDamage {

   public float maxSpeed = 3f;
   private float damage = 10;
   private float currentHealth = 20;
   private float minHealth = 0;
   public GameObject Explotion;
   
    // Update is called once per frame
    void Update () {

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);

        pos += transform.rotation * velocity;
        transform.position = pos;
	}
    public void TakeDamage()
    {
        currentHealth -= damage;

        if (currentHealth <= minHealth)
        {
            Destroy(gameObject);
            Instantiate(Explotion, transform.position, Quaternion.identity);
        }

    }
}
