using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("PlayerMaxStatistics")]
    public int maxHealth;
    public int maxStamina;
    [Header("PlayerCurrrentStatistics")]
    public float curHealth;
    public float curStamina;
    [Header("Timer")]
    public float damageTimer;
    [Header("IsUnder the influence of factors? ")]
    public bool isDamage;
    [Header("EnemiesDamages")]
    public int NightmareDamage;

    private void Update()
    {
        if(damageTimer>0)
        damageTimer -= Time.deltaTime;
        Death();
    }
    void Awake()
    {
        curHealth = maxHealth;
        curStamina = maxStamina;
    }
     public void Death()
    {
        if (isDamage == true && damageTimer<=0)
        {
            damageTimer = 0.6f;
            curHealth -= NightmareDamage;
        }
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Nightmare")
        {
            isDamage = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Nightmare")
        {
            isDamage = false;
        }
    }
}
