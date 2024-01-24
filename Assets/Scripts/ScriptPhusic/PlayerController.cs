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
    private float playerScale = 0.6f;

    public int direction;//направление

    //направление движения вверх и вниз
    private float hsp;
    private float vsp;

    //кнопки
    private float shootDelayCouter;
    private bool KeyLeft;
    private bool KeyRight;
    private bool KeyUp;
    private bool KeyDown;
    private float KeyAction;
    private bool KeyStamina;
    private bool KeyShoot;
    private GameObject BulletPlayer;
    private bool Rotation;
    private bool movingUp;
    private Vector2 _direction = Vector2.zero;
    public GameObject GunPlayerOne;
    public GameObject GunPlayerTwo;
    public GameObject GunPlayerTree;
    public GameObject player;
    public GameObject ExplosionPlayer;
    public GameObject shildPlayer;
    [SerializeField]
    private Joystick _joystic;
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

    //выстрел
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

    //движение
    void Move()
    {
        _direction.x = _joystic.Horizontal * MoveSpeed;
        _direction.y = _joystic.Vertical * MoveSpeed;
        rb.velocity = new Vector2(_direction.x, _direction.y);
    }

    private IEnumerator WaitToDestroyShildPlayer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        shildPlayer.SetActive(false);
        FindObjectOfType<HittingAPlayer>().isShildActive = false;
    }
}

