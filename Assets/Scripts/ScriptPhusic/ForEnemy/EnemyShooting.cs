using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public bool isCapsule = false;
    public bool isRectangle = false;
    public bool isHexagon = false;
    public bool isOval = false;
    public bool isIsometric = false;
    public Vector3 bulletoffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public GameObject dulo1;
    public GameObject dulo2;
    private float fireDelay;
    float cooldownTimer = 0;

    private AudioSource AudioShutEn;

    private void Start()
    {
        if (isRectangle)
        {
            fireDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayRectangle);
        }
        if (isOval)
        {
            fireDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayOval);
        }
        if (isIsometric)
        {
            fireDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayIsometric);
        }
        if (isHexagon)
        {
            fireDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayHexagon);
        }
        if (isCapsule)
        {
            fireDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayCapsule);
            StartCoroutine(FireBurst());
        }

        AudioShutEn = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        cooldownTimer -= Time.deltaTime;
        if (!isCapsule)
        {
            if (cooldownTimer <= 0)
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
        else
        {
            if (cooldownTimer <= 0)
            {
                StartCoroutine(FireBurst());
                cooldownTimer = fireDelay;
            }
                
        }
        
	}

    IEnumerator FireBurst()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject bulletGO = Instantiate(bulletPrefab, dulo1.transform.position, transform.rotation);
            bulletGO.layer = gameObject.layer;
            if (dulo2 != null)
            {
                GameObject bulletGO2 = Instantiate(bulletPrefab, dulo2.transform.position, transform.rotation);
                bulletGO2.layer = gameObject.layer;
            }
            yield return new WaitForSeconds(0.2f);
        }
       
    }
}
