using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestruction : MonoBehaviour
{
    [Header("EnemyStatistics")]
    public int currentHealth;
    [Header("OnProjectileSensitivity")]
    public int damageWeapon1;
    public int damageWeapon2;
    public int damageWeapon3;
    public int damageWeapon4;
    public int damageWeapon5;
    public Rigidbody2D smallHurt;
    public Rigidbody2D mediumHurt;
    public Rigidbody2D bigHurt;
    public Rigidbody2D hurt;
    public float maxHealth;






    void Update()
    {
        if (currentHealth <= maxHealth && currentHealth > maxHealth / 2)
        {
            hurt = smallHurt;
        }
        else if (currentHealth <= maxHealth / 2 && currentHealth > maxHealth / 4)
        {
            hurt = mediumHurt;
        }
        else if (currentHealth <= maxHealth/4 && currentHealth > 0)
        {
            hurt = bigHurt;
        }
        else if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.CompareTag("Projectile"))
        {
            currentHealth -= damageWeapon1;
            Rigidbody2D Hurt = Instantiate(hurt, transform.position, transform.rotation);
        }
    }
}
