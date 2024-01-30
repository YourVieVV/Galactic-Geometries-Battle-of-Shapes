using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMiniPlayers : MonoBehaviour
{
    private float shootDelayCouter;
    [SerializeField]
    private float shootDelay = 0.8f;
    [SerializeField]
    private GameObject miniBullet;
    [SerializeField]
    private GameObject miniGun;

    private void Shoot()
    {
        if (shootDelayCouter <= 0)
        {
            Instantiate(miniBullet, miniGun.transform.position, transform.rotation);

            shootDelayCouter = shootDelay;
            //AudioShut.Play();
        }

        shootDelayCouter -= Time.deltaTime;
    }

    void Update()
    {
        Shoot();
    }
}
