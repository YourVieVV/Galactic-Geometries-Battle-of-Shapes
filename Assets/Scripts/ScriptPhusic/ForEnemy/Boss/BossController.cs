using System.Collections;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public float shootDelayCouter;
    public float shootDelayGun = 1f;
    public GameObject GunBossOne;
    public GameObject GunBossTwo;
    public GameObject GunBossTree;
    public GameObject ControlDodge;
    [SerializeField]
    private GameObject enemyBullet;
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

        shootDelayCouter -= Time.deltaTime;
    }

    private void Update()
    {
        ControlDodge.transform.position = transform.position;
        Shoot();
    }
}
