using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //переменные
    public GameObject currentProjecktile;
    public float shootDelayGun;
    public float shootDelayLaser;
    public float shootDelayRocket;
    public float moveSpeed;
    public float Stamina;
    public float Gravity;
    public bool isGunTwo = false;
    public bool isGunTree = false;
    public bool isPalyerRotate = false;
    private float playerScale = 0.6f;

    public int direction;//направление

    //кнопки
    private float shootDelayCouter;
    private GameObject BulletPlayer;
    private Vector2 _direction = Vector2.zero;
    public GameObject GunPlayerOne;
    public GameObject GunPlayerTwo;
    public GameObject GunPlayerTree;
    public GameObject player;
    public GameObject shildPlayer;
    [SerializeField]
    private Joystick _joystickMoving,
        _joystickRotation;
    private Rigidbody2D rb;

    //звук
    private AudioSource AudioShut;

    //смерть
    private bool isActive;
    private bool isDead;
    public float invincibilityTime;
    public float inactivityTime;
    private float invincCounter;
    private float inactCounter;


    void Start()
    {
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

            shootDelayCouter = shootDelayGun;
            AudioShut.Play();
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
        shootDelayLaser = PlayerPrefs.GetFloat(PlayerStats.shootDelayLaser);
        shootDelayRocket = PlayerPrefs.GetFloat(PlayerStats.shootDelayRocket);

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
        StartStats();
        Shoot();
    }

}

