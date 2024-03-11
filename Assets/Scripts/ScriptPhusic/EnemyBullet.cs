using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody2D myrigitbody;
    public bool isMovieBulletEnemy = false;
    public float moveSpeed;
    public GameObject ExplosionBullet;
    public GameObject ExplosionHitPlayer;
    public GameObject ExplosionHitPlayerTablet;
    public GameObject ExplosionHitPlayerShield;
    public bool isBossBullet = false;

    void Start()
    {
        if (!isBossBullet)
        {
            myrigitbody = GetComponent<Rigidbody2D>();
            if (isMovieBulletEnemy)
            {
                //transform.rotation = Quaternion.Euler(transform.rotation.x + 10, transform.rotation.y -10, transform.rotation.z + 10);
                //myrigitbody.AddRelativeForce(Vector2.up * moveSpeed, ForceMode2D.Impulse);

            }
            else
            {
                myrigitbody.AddRelativeForce(Vector2.down * moveSpeed, ForceMode2D.Impulse);
            }
        }
    }
    public static bool IsTablet()
    {

        float ssw;
        if (Screen.width > Screen.height) { ssw = Screen.width; } else { ssw = Screen.height; }

        if (ssw < 800) return false;

        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            float screenWidth = Screen.width / Screen.dpi;
            float screenHeight = Screen.height / Screen.dpi;
            float size = Mathf.Sqrt(Mathf.Pow(screenWidth, 2) + Mathf.Pow(screenHeight, 2));
            if (size >= 6.5f) return true;
        }

        return false;
    }
    public void BulletHitPlayer()
    {
        if (!IsTablet())
        {
            Instantiate(ExplosionHitPlayer, transform.position, Quaternion.identity);
        } else
        {
            Instantiate(ExplosionHitPlayerTablet, transform.position, Quaternion.identity);
        }
            
        Destroy(gameObject);
    }
    public void BulletHitPlayerBullet()
    {
        if (!IsTablet())
        {
            Instantiate(ExplosionHitPlayer, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(ExplosionHitPlayerTablet, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
    public void BulletHitPlayerShield()
    {
        if (ExplosionHitPlayer != null)
            Instantiate(ExplosionHitPlayerShield, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
