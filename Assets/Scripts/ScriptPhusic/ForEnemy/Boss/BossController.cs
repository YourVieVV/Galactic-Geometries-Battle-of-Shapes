using System.Collections;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public float shootDelayGun;
    public GameObject GunBossOne;
    public GameObject GunBossTwo;
    public GameObject GunBossTree;
    public GameObject ControlDodge;
    public GameObject ShieldBoss;
    [SerializeField]
    private GameObject enemyBullet;
    private float shootDelayCouter;
    private void Shoot()
    {
       
        if (shootDelayCouter <= 0)
        {
            Instantiate(enemyBullet, GunBossOne.transform.position, transform.rotation);
            Instantiate(enemyBullet, GunBossTwo.transform.position, transform.rotation);
            Instantiate(enemyBullet, GunBossTree.transform.position, transform.rotation);

            shootDelayCouter = shootDelayGun;
                //AudioShut.Play();
        }

        shootDelayCouter -= Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        ControlDodge.transform.position = transform.position;
        ShieldBoss.transform.position = transform.position;
        Shoot();
    }
}
