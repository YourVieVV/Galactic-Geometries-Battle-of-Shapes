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
            ShowShield(false);
        }
    }

    public void ReactivateShield()
    {
        ShowShield(true);
        currentHealth = 99;
        slider.value = currentHealth;
    }

    private void ShowShield(bool isShow)
    {
        gameObject.SetActive(isShow);
    }
}
