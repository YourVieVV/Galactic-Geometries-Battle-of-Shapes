using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldHP : MonoBehaviour
{
    public float currentHealth = 100;

    [SerializeField]
    private Slider slider;

    private float maxHealth = 100;
    private float minHealth = 0;

    void Start()
    {
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
    }

    public void Damage(float damageValue)
    {
        currentHealth -= damageValue;

        slider.value = currentHealth;

        //FindObjectOfType<CameraSnake>().Shake();

        if (currentHealth <= 0)
        {
            currentHealth = minHealth;
            //Instantiate(ExplosionPlayer, transform.position, Quaternion.identity);  
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" || collision.tag == "EnemySquare")
        {
            collision.GetComponent<EnemyHP>().HittingEnemyByPlayer();
            Damage(65);
        }
    }
}
