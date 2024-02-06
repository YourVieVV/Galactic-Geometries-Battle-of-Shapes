using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    public GameObject ExplosionStar;
    private SpriteRenderer star;
    private float _movementSpeed = 0.5f;
    void Start()
    {
        star = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 4f, 2));

        //move star
        transform.position += transform.up * Time.deltaTime * _movementSpeed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnMouseDown()
    {
        Instantiate(ExplosionStar, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}