using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //переменные
    public GameObject currentProjecktile;
    public float shootDelay = 1.2f;
    public float MoveSpeed;
    public float Stamina;
    public float Gravity;
    public bool isGunTwo = false;
    public bool isGunTree = false;
    public bool isPalyerRotate = false;
    private float playerScale = 0.6f;

    public int direction;//направление

    //направление движения вверх и вниз
    private float hsp;
    private float vsp;

    //кнопки
    private float shootDelayCouter;
    private GameObject BulletPlayer;
    private Vector2 _direction = Vector2.zero;
    public GameObject GunPlayerOne;
    public GameObject GunPlayerTwo;
    public GameObject GunPlayerTree;
    public GameObject player;
    public GameObject ExplosionPlayer;
    public GameObject shildPlayer;
    [SerializeField]
    private Joystick _joystickMoving,
        _joystickRotation;
    private Rigidbody2D rb;

    //звук
    private AudioSource AudioShut;

    //animation
    private Animator[] animators;

    //смерть
    private bool isActive;
    private bool isDead;
    public float invincibilityTime;
    public float inactivityTime;
    private float invincCounter;
    private float inactCounter;


    void Start()
    {
        animators = GetComponentsInChildren<Animator>();
        shootDelayCouter = 0;
        BulletPlayer = currentProjecktile;
        AudioShut = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
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
        if (shootDelayCouter <= 0)
        {
            Instantiate(currentProjecktile, GunPlayerOne.transform.position, transform.rotation);

            if (isGunTwo)
            {
                Instantiate(currentProjecktile, GunPlayerTwo.transform.position, transform.rotation);
            }
            
            if (isGunTree)
            {
                Instantiate(currentProjecktile, GunPlayerTree.transform.position, transform.rotation);
            }

            shootDelayCouter = shootDelay;
            AudioShut.Play();
        }

        shootDelayCouter -= Time.deltaTime;
    }

    private void Move()
    {
        _direction.x = _joystickMoving.Horizontal * MoveSpeed;
        _direction.y = _joystickMoving.Vertical * MoveSpeed;

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


    private void Rotarion()
    {

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

