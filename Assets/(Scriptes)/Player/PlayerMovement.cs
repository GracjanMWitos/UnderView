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

    private Rigidbody2D rb;
    Vector2 movement;
    Vector2 target;
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
}