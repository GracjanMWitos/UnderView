using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMovement : MonoBehaviour
{
    /*Rigidbody2D m_carRigidbody = null;

    [Header("side friction")]
    [SerializeField] float m_sideFrictionLinear = 5f;
    [SerializeField] float m_sideFrictionAngular = 50f;

    [Header("Turn")]
    [SerializeField] float m_turnSpeed = 30f;
    [SerializeField] float m_turnSpeedByVelocity = 0.02f;
    [SerializeField] float m_minTurnSpeedForTurning = 0.01f;

    [Header("Move")]
    [SerializeField] float m_moveSpeed = 4f;
    [SerializeField] float m_turboSpeed = 15f;

    [Header("acceleration")]
    [SerializeField] float m_accelerationFactor = 2f;
    [SerializeField] float m_decelerationFactor = 0.4f;
    [SerializeField] float m_BrackingFactor = 5f;
    [SerializeField] PlayerInput m_input = null;
    void Start()
    {
        m_carRigidbody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Turn();
        ApplySideFriction();
    }
    void Turn()
    {
        if (m_carRigidbody.velocity.magnitude > m_minTurnSpeedForTurning)
        {
            if (m_input.KeyA && m_input.KeyD)
            {
                m_carRigidbody.angularVelocity = 0;
            }
            else if (m_input.KeyA)
            {
                m_carRigidbody.angularVelocity = m_turnSpeed;
            }
            else if (m_input.KeyD)
            {
                m_carRigidbody.angularVelocity = -m_turnSpeed;
            }
            else
            {
                m_carRigidbody.angularVelocity = 0;

            }
        }
    }

    void Move()
    {
        float directionFactor = Vector2.Dot(m_carRigidbody.velocity.normalized, m_carRigidbody.transform.up);

        if (m_input.KeyS)
        {
            Break();
        }

        else if (m_input.KeyW && Input.GetKey(KeyCode.LeftShift) && (m_carRigidbody.velocity.magnitude * directionFactor) > - 0.1f)
        {
            MoveForwardTurbo();
        }
        else if (m_input.KeyW && (m_carRigidbody.velocity.magnitude * directionFactor) > -0.1f)
        {
            MoveForward();
        }
        else if (m_input.KeyX && (m_carRigidbody.velocity.magnitude * directionFactor) < -0.1f)
        {
            MoveBreakward();
        }
        else
        {
            SlowDown();
        }
    }
    void MoveForward()
    {
        Vector2 speedVector = transform.up * m_moveSpeed;
        float accelerationTime = m_accelerationFactor * Time.deltaTime;

        m_carRigidbody.velocity = Vector2.Lerp(m_carRigidbody.velocity, speedVector, accelerationTime);



    }
    void MoveForwardTurbo()
    {
        Vector2 speedVector = transform.up * m_turboSpeed;
        float accelerationTime = m_accelerationFactor * Time.deltaTime;

        m_carRigidbody.velocity = Vector2.Lerp(m_carRigidbody.velocity, speedVector, accelerationTime);

    }
    void MoveBreakward()
    {
        Vector2 speedVector = -transform.up * m_moveSpeed;
        float accelerationTime = m_accelerationFactor * Time.deltaTime;

        m_carRigidbody.velocity = Vector2.Lerp(m_carRigidbody.velocity, speedVector, accelerationTime);
    }
    void Break()
    {
        float accelerationIime = m_BrackingFactor * Time.deltaTime;

        m_carRigidbody.velocity = Vector2.Lerp(m_carRigidbody.velocity, Vector2.zero, accelerationIime);
    }
    void SlowDown()
    {
        float accelerationIime = m_decelerationFactor * Time.deltaTime;
        m_carRigidbody.velocity = Vector2.Lerp(m_carRigidbody.velocity, Vector2.zero, accelerationIime);
    }
    void ApplySideFriction()
    {
        float sideFractionFactor = Vector2.Dot(m_carRigidbody.velocity.normalized, m_carRigidbody.transform.up);
        m_carRigidbody.drag = m_sideFrictionLinear - (m_sideFrictionLinear * Mathf.Abs(sideFractionFactor));
        m_carRigidbody.angularDrag = m_sideFrictionAngular - (m_sideFrictionAngular * Mathf.Abs(sideFractionFactor));
    }*/
}