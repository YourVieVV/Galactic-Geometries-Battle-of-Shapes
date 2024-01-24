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
    private bool movingDown;
    private bool movingLeft;
    private bool movingRight;
    private float dirX;
    private float dirY;
    public GameObject GunPlayerOne;
    public GameObject GunPlayerTwo;
    public GameObject GunPlayerTree;
    public GameObject player;
    public GameObject ExplosionPlayer;
    public GameObject shildPlayer;
    public Joystick joystic;
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

        GetInput();
        //faceMouse();
        //CalculateDirection();
        Animate();
        Move();
        Shoot();
        //cursoremouse();

    }
    //поворот за мышкой (рабочий)
    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 Direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = Direction * Time.deltaTime;
    }
    //присваивание ввода по кнопкам
    void GetInput()
    {
/*        KeyLeft = Input.GetKey(KeyCode.LeftArrow);
        KeyRight = Input.GetKey(KeyCode.RightArrow);
        KeyUp = Input.GetKey(KeyCode.UpArrow);
        KeyDown = Input.GetKey(KeyCode.DownArrow);*/
    }
    //движение
    void Move()
    {
        dirX = joystic.Horizontal * MoveSpeed;
        dirY = joystic.Vertical * MoveSpeed;
        rb.velocity = new Vector2(dirX, dirY);
    }
    //направление
    void CalculateDirection()
    {
        if (KeyUp && !KeyRight && !KeyLeft && !KeyDown && transform.localScale.y > 0)
        {
            direction = 8; movingUp = true;
        }
        else if (KeyDown && !KeyRight && !KeyLeft && !KeyUp && transform.localScale.y < 0) { direction = 2; movingDown = true; }
        else if (transform.localScale.x > 0)
        {
            if (KeyUp && KeyRight) direction = 9;
            else if (KeyDown && KeyRight) direction = 3;
            else if (KeyRight) { direction = 6; movingRight = true; }

        }
        else if (transform.localScale.x < 0)
        {
            if (KeyUp && KeyLeft) direction = 7;
            else if (KeyDown && KeyLeft) direction = 1;
            else if (KeyLeft && !KeyRight) { direction = 4; movingLeft = true; }

        }

        if (!KeyRight && !KeyLeft && !KeyDown && !KeyUp)
        {
            movingUp = false;
            movingLeft = false;
            movingDown = false;
            movingRight = false;
        }
    }

    //Анимация
    private void Animate()
    {
        for (int i = 0; i < animators.Length; i++)
        {
            animators[i].SetBool("movingUp", movingUp);
            //animators[i].SetBool("movingDown", movingDown);
            //animators[i].SetBool("movingLeft", movingLeft);
            //animators[i].SetBool("movingRight", movingRight);
            //animators[i].SetInteger("direction", direction);
        }
    }

    private IEnumerator WaitToDestroyShildPlayer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        shildPlayer.SetActive(false);
        FindObjectOfType<HittingAPlayer>().isShildActive = false;
    }
}

