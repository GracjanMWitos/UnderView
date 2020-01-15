using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("PlayerStatistics")]
    public int maxHealth;
    public int maxStamina;
    public float curHealth;
    public float curStamina;
    public float timer;
    public bool isDamage;

    private void FixedUpdate()
    {
        if (isDamage == true)
        {
                curHealth -= 1/ Time.deltaTime;
        }
        Death();
    }
    void Awake()
    {
        curHealth = maxHealth;
        curStamina = maxStamina;
    }
     public void Death()
    {
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
