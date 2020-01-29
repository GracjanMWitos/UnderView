using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightmare_AI : MonoBehaviour
{
    public Transform target;
    public float speed;
    Rigidbody2D rb;
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
