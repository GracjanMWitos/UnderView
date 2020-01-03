using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public static bool canMove = true;
    private Rigidbody2D bulletrb;
    [SerializeField] float speed;
    private PlayerMovement PlayerPos;
    [SerializeField] float secondsToDestroy;
    private int healthPoint;
    public int damage;



    void Start()
    {
        bulletrb = GetComponent<Rigidbody2D>();
        //bulletrb.velocity = new Vector2(speed, speed);//
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
