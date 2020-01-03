using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMove")]
    [SerializeField] float playerSpeed;
    [SerializeField] float playerWalkSpeed;
    [SerializeField] float playerRunSpeed;
    [SerializeField] float AccelerationFactor;
    [SerializeField] float walkDecelerationFactor;
    [SerializeField] float runDecelerationFactor;
    [Header("PlayerTurn")]
    public float turnSpeed = 0f;
    [Header("PlayerStat")]
    public float health;

    private Rigidbody2D rb;
    Vector2 movement;
    Vector2 target;
    Rigidbody2D Pos;
    private Animator anim;

    public bool isRuning = false;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRuning = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRuning = false;
        }
    }
    void FixedUpdate()
    {
        Quaternion rotation = Quaternion.LookRotation(transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        if (isRuning == false)
        {
            rb.velocity = new Vector2(0, 0);

            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");

            transform.Translate(movement * playerWalkSpeed * Time.deltaTime, Space.World);
            
        }
        else if (isRuning == true)
        {
            transform.Translate(Vector2.up * playerRunSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
  

    void Turn()
    {
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector2(0, transform.position.y) / Time.deltaTime, Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(new Vector2(turnSpeed, transform.position.y) / Time.deltaTime, Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector2(-turnSpeed, transform.position.y) / Time.deltaTime, Space.World);
        }
        else transform.Translate(new Vector2(0, transform.position.y) / Time.deltaTime, Space.World);

    }
}