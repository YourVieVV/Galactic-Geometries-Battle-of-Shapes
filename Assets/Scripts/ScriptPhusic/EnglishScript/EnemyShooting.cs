using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public Vector3 bulletoffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public GameObject dulo1;
    public GameObject dulo2;
    public float fireDelay = 0.50f;
    float cooldownTimer = 0;

    private AudioSource AudioShutEn;

    private void Start()
    {
        AudioShutEn = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        cooldownTimer -= Time.deltaTime;

        if(cooldownTimer <= 0)
        {
            // стрельба
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletoffset;

           GameObject bulletGO = Instantiate(bulletPrefab, dulo1.transform.position, transform.rotation);
            bulletGO.layer = gameObject.layer;
            if (dulo2 != null)
            {
                GameObject bulletGO2 = Instantiate(bulletPrefab, dulo2.transform.position, transform.rotation);
                bulletGO2.layer = gameObject.layer;
            }
          
            //AudioShutEn.Play();
        }
	}
}
