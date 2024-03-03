using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{

    [SerializeField]
    private Slider slider;
    public float currentHealth;
    private float maxHealth;
    private float minHealth = 0;
    private float differenceHp;
    public GameObject player;
    public GameObject ExplosionPlayer;

    void Start()
    {
        currentHealth = PlayerPrefs.GetFloat(PlayerStats.hpPlayer);
        maxHealth = PlayerPrefs.GetFloat(PlayerStats.hpPlayer);
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
    }

    public void UpgradeAddHP(float Hp)
    {
        maxHealth += Hp;
        DiffHP(100f);

        slider.maxValue = maxHealth;
        slider.value = currentHealth;
    }

    public void AddHP(float Hp)
    {
        DiffHP(Hp);

        slider.value = currentHealth;
    }

    public void Damage(float damageValue)
    {
        currentHealth -= damageValue;

        slider.value = currentHealth;

        FindObjectOfType<CameraSnake>().Shake();

        if (currentHealth <= 0)
        {
            currentHealth = minHealth;
            if (ExplosionPlayer != null)
                Instantiate(ExplosionPlayer, transform.position, Quaternion.identity);
            Destroy(player);
        }
    }

    private void DiffHP(float Hp)
    {
        differenceHp = currentHealth + Hp - maxHealth;
        if (differenceHp > 0)
        {
            currentHealth = currentHealth + Hp - differenceHp;
        }
        else
        {
            currentHealth += Hp;
        }
    }

}
