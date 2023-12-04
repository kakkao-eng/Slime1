using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Maxhealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject gameOv;

    public Healthbar healthBar;
    
    public AudioSource damageSound;
    
    public float yourForceAmount = 5.0f;
    
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
        IncreaseHealth(20);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TakeDamage(20);
        }
        
       

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            gameOv.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            if (damageSound != null)
            {
                damageSound.Play();
            }

            PlayerDamageEffect damageEffect = GetComponent<PlayerDamageEffect>();
            if (damageEffect != null)
            {
                damageEffect.PlayDamageEffect();
            }

            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(-transform.forward * yourForceAmount, ForceMode.Impulse);
            }
        }
        
        
    }

    public void DecreaseMaxHealth(int amount)
    {
        maxHealth -= amount;
        // แนะนำให้ใส่การตรวจสอบที่นี่เพื่อไม่ให้ Max Health ติดลบ
        // if (maxHealth < 0) maxHealth = 0;
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))  
        {
            TakeDamage(20);
        }
        
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
    public void IncreaseHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
    }

}
