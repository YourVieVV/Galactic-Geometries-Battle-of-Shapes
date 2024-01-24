using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

    [SerializeField]
    private Slider slider;
    public float currentHealth = 100;
    private float upgradeHealth = 100;
    private float maxHealth = 100;
    private float minHealth = 0;
    public GameObject player;
    public GameObject ExplosionPlayer;

    void Start () {
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
    }

    public void UpgradeAddHP(float Hp)
    {
        upgradeHealth += Hp;
        currentHealth = upgradeHealth;
        slider.maxValue = currentHealth;
        slider.value = currentHealth;
    }

    public void AddHP(float Hp)
    {
        currentHealth += Hp;
        slider.value = currentHealth;
    }

    public void Damage (float damageValue)
    {
        currentHealth -= damageValue;
        
        slider.value = currentHealth;

        FindObjectOfType<CameraSnake>().Shake();

        if (currentHealth <= 0) {
            currentHealth = minHealth;
            Instantiate(ExplosionPlayer, transform.position, Quaternion.identity);
            Destroy(player);
        }
    }
}
