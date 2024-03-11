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
    public GameObject ExplosionPlayerTablet;

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

    public void Damage(float damageValue)
    {
        currentHealth -= damageValue;

        slider.value = currentHealth;
        FindObjectOfType<CameraSnake>().Shake();
        if (currentHealth <= 0)
        {
            currentHealth = minHealth;
            
            if (!IsTablet())
            {
                Instantiate(ExplosionPlayer, transform.position, Quaternion.identity);
            } else
            {
                Instantiate(ExplosionPlayerTablet, transform.position, Quaternion.identity);
            }
                
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
