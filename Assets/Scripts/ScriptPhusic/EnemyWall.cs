using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWall : MonoBehaviour {

    public float delay = 0.3f;

    public float shootDelay = 1;
    private float shootDelayCounter;

    private EnemyController angler;
    private float angleToPlayer;
    private float currentAngle;
    private float delayCounter;
    private PlayerController player;

    public GameObject projectile;
    public GameObject dulo;

    private AudioSource AudioShutEn;

    private void Start()
    {
        shootDelay = PlayerPrefs.GetFloat(EmenyStats.shootDelayCircle);
        player = FindObjectOfType<PlayerController>();
        angler = GetComponent<EnemyController>();
        delayCounter = delay;
        AudioShutEn = GetComponent<AudioSource>();
    }

    void Update() {

        //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angler.checkAngle());


        if (delayCounter <= 0)
        {
            delayCounter = delay;
            angleToPlayer = angler.checkAngle();
            if (angleToPlayer < 0) angleToPlayer += 360;
            currentAngle = Mathf.Round(transform.rotation.eulerAngles.z);

            if (currentAngle - angleToPlayer > 0)
            {
                if (currentAngle - angleToPlayer > 180)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentAngle +3);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentAngle -3);
                }
            }
            else if (currentAngle - angleToPlayer < 0)
            {
                if (currentAngle - angleToPlayer < -180)
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentAngle -3);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentAngle +3);
                }
            }

            else if (currentAngle == angleToPlayer)
            {
                Shoot();
            }
        }else
        {
            delayCounter -= Time.deltaTime;
        }
        shootDelayCounter -= Time.deltaTime;
    }
    void Shoot()
    {
       if (shootDelayCounter <= 0)
        {
            GameObject bulletShoot = Instantiate(projectile, dulo.transform.position, transform.rotation);
           bulletShoot.GetComponent<Rigidbody2D>().velocity = (player.transform.position - transform.position).normalized * 5;
           
            shootDelayCounter = shootDelay;

            AudioShutEn.Play();
        }
    }
}

