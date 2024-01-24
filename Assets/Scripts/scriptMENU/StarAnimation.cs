using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour
{
    public GameObject ExplosionStar;
    private SpriteRenderer star;
    private float _movementSpeed = 0.1f;
    void Start()
    {
        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 20f);
    }
    private void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 7f, 1));

         
        //move star
        transform.position += transform.up * Time.deltaTime * _movementSpeed;
        //OnMouseDown();
    }
     void OnMouseDown()
    {
        Instantiate(ExplosionStar, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}