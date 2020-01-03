using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestruction : MonoBehaviour
{
    [Header("EnemyStatistics")]
    public int health;
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
        if (health <= maxHealth && health > maxHealth / 2)
        {
            hurt = smallHurt;
        }
        else if (health <= maxHealth / 2 && health > maxHealth / 4)
        {
            hurt = mediumHurt;
        }
        else if (health <= maxHealth/4 && health > 0)
        {
            hurt = bigHurt;
        }
        else if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.CompareTag("Projectile"))
        {
            health -= damageWeapon1;
            Rigidbody2D Hurt = Instantiate(hurt, transform.position, transform.rotation);
        }
    }
}
