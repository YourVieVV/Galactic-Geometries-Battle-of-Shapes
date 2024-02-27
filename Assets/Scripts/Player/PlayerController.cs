using DigitalRuby.LightningBolt;
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
    //[SerializeField]
    //private ShieldHP shieldHPScript;

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


    public void StartStats()
    {
        moveSpeed = PlayerPrefs.GetFloat(PlayerStats.moveSpeed);
        shootDelayGun = PlayerPrefs.GetFloat(PlayerStats.shootDelayGun);
        //shootDelayLaser = PlayerPrefs.GetFloat(PlayerStats.shootDelayLaser);
        //shootDelayRocket = PlayerPrefs.GetFloat(PlayerStats.shootDelayRocket);

        isRocket = PlayerPrefs.GetInt(PlayerStats.isRocket) != PlayerStats.initIsRocket ? true : false;
        isGunTwo = PlayerPrefs.GetInt(PlayerStats.isGunTwo) == 0 ? false : true;
        isGunTree = PlayerPrefs.GetInt(PlayerStats.isGunTree) == 0 ? false : true;
        isPalyerRotate = PlayerPrefs.GetInt(PlayerStats.isPalyerRotate) == 0 ? false : true;
        if (isPalyerRotate)
            _joystickRotation.gameObject.SetActive(true);
    }

    void Start()
    {
        shootDelayCouter = 0;
        AudioShut = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        StartStats();
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
                InstantiateBullet(playerRocket);

                shootDelayCouter = shootDelayRocket;
            }
            else
            {
                InstantiateBullet(playerBullet);

                shootDelayCouter = shootDelayGun;
                AudioShut.Play();
            }

        }

        shootDelayCouter -= Time.deltaTime;
    }

    private void InstantiateBullet(GameObject pref)
    {
        Instantiate(pref, GunPlayerOne.transform.position, transform.rotation);

        if (isGunTwo)
        {
            Instantiate(pref, GunPlayerTwo.transform.position, transform.rotation);
        }

        if (isGunTree)
        {
            Instantiate(pref, GunPlayerTree.transform.position, transform.rotation);
        }

    }

    private void Move()
    {
        //_direction.x = _joystickMoving.Horizontal * moveSpeed;
        _direction.x = _joystickMoving.Horizontal;
        _direction.y = _joystickMoving.Vertical;

        // Поворот вокруг
        if (isPalyerRotate)
        {
            if (_joystickRotation.Vertical > 0.3f || _joystickRotation.Vertical < -0.3f && _joystickRotation.Horizontal > 0.3f || _joystickRotation.Horizontal < -0.3f)
            {
                float angle = Mathf.Atan2(_joystickRotation.Vertical, _joystickRotation.Horizontal) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90f));
            }
        }

        //rb.velocity = new Vector2(_direction.x, _direction.y);
        rb.MovePosition(rb.position + _direction * moveSpeed * Time.fixedDeltaTime);
    }

    void Update()
    {
        if (shildPlayer.activeSelf)
        {
            shildPlayer.gameObject.transform.position = gameObject.transform.position;
        }
        if (!isActive)
        {
            inactCounter -= Time.deltaTime;
            if (inactCounter < 0)
            {
                isActive = true;
            }
            return;
        }

        // Move();
        Shoot();
    }
    private void FixedUpdate()
    {
        Move();
    }

}

