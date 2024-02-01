﻿using DigitalRuby.LightningBolt;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float shootDelayLaser;
    //[SerializeField]
    //private GameObject lightningLaser;

    public float shootDelayGun;
    public float shootDelayRocket;
    public float shootDelayCouter;
    public float moveSpeed;

    public bool isRocket;
    public bool isGunTwo;
    public bool isGunTree;
    public bool isPalyerRotate;

    public GameObject GunPlayerOne;
    public GameObject GunPlayerTwo;
    public GameObject GunPlayerTree;
    public GameObject player;
    public GameObject shildPlayer;

    [SerializeField]
    private GameObject playerBullet;
    [SerializeField]
    private GameObject playerRocket;

    [SerializeField]
    private LightningBoltScript _LightningBoltScript;
    [SerializeField]
    private Joystick _joystickMoving,
    _joystickRotation;

    private Vector2 _direction = Vector2.zero;

    private Rigidbody2D rb;

    //звук
    private AudioSource AudioShut;

    //смерть
    private bool isActive;
    private float inactCounter;


    void Start()
    {
        shootDelayCouter = 0;
        AudioShut = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        StartStats();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "DropShild")
        {
            shildPlayer.SetActive(true);
            FindObjectOfType<HittingAPlayer>().isShildActive = true;
            StartCoroutine(WaitToDestroyShildPlayer(10));
        }
    }

    private void Shoot()
    {
        //lightningLaser.SetActive(true);
        //_LightningBoltScript.StartObject.transform.position = new Vector3(GunPlayerOne.transform.position.x, GunPlayerOne.transform.position.y, 1f);
        //_LightningBoltScript.EndObject.transform.position = new Vector3(GunPlayerOne.transform.position.x, GunPlayerOne.transform.position.y + 4f, 1f);


        if (shootDelayCouter <= 0)
        {
            if (isRocket)
            {
                Instantiate(playerRocket, GunPlayerOne.transform.position, transform.rotation);
                shootDelayCouter = shootDelayRocket;
            } else
            {
                Instantiate(playerBullet, GunPlayerOne.transform.position, transform.rotation);

                if (isGunTwo)
                {
                    Instantiate(playerBullet, GunPlayerTwo.transform.position, transform.rotation);
                }

                if (isGunTree)
                {
                    Instantiate(playerBullet, GunPlayerTree.transform.position, transform.rotation);
                }

                shootDelayCouter = shootDelayGun;
                AudioShut.Play();
            }

        }

        shootDelayCouter -= Time.deltaTime;
    }

    private void Move()
    {
        _direction.x = _joystickMoving.Horizontal * moveSpeed;
        _direction.y = _joystickMoving.Vertical * moveSpeed;

        if (isPalyerRotate)
        {
            // Если джостиком управляют
            if (_joystickRotation.Vertical > 0.3f || _joystickRotation.Vertical < 0.3f && _joystickRotation.Horizontal > 0.3f || _joystickRotation.Horizontal < -0.3f)
            {
                float angle = Mathf.Atan2(_joystickRotation.Vertical, _joystickRotation.Horizontal) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90f));
            }
        }

        rb.velocity = new Vector2(_direction.x, _direction.y);
    }

    public void StartStats()
    {
        moveSpeed = PlayerPrefs.GetFloat(PlayerStats.moveSpeed);
        shootDelayGun = PlayerPrefs.GetFloat(PlayerStats.shootDelayGun);
        //shootDelayLaser = PlayerPrefs.GetFloat(PlayerStats.shootDelayLaser);
        shootDelayRocket = PlayerPrefs.GetFloat(PlayerStats.shootDelayRocket);

        isRocket = PlayerPrefs.GetInt(PlayerStats.isRocket) != PlayerStats.initIsRocket ? true : false;
        isGunTwo = PlayerPrefs.GetInt(PlayerStats.isGunTwo) == 0 ? false : true;
        isGunTree = PlayerPrefs.GetInt(PlayerStats.isGunTree) == 0 ? false : true;
        isPalyerRotate = PlayerPrefs.GetInt(PlayerStats.isPalyerRotate) == 0 ? false : true;
    }

    private IEnumerator WaitToDestroyShildPlayer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        shildPlayer.SetActive(false);
        FindObjectOfType<HittingAPlayer>().isShildActive = false;
    }

    void Update()
    {

        if (!isActive)
        {
            inactCounter -= Time.deltaTime;
            if (inactCounter < 0)
            {
                isActive = true;
            }
            return;
        }

        Move();
        Shoot();
    }

}

