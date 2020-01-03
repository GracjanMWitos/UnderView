using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    Camera m_camera = null;

    [SerializeField] Transform m_carCameraHold = null;
    [SerializeField] Transform m_cameraRigTransform = null;
    [SerializeField] Rigidbody2D m_carRigidbody = null;

    [SerializeField] float m_cameraSizeFactor = 5f;
    [SerializeField] float m_cameraMinimumSize = 5f;
    [SerializeField] float m_cameraSizeChangeSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        m_cameraRigTransform.position = m_carCameraHold.position;

        float targetCameraSize =
            m_cameraMinimumSize + m_carRigidbody.velocity.magnitude
            * m_cameraSizeFactor;

        m_camera.orthographicSize = Mathf.Lerp(
            m_camera.orthographicSize,
            targetCameraSize, m_cameraSizeChangeSpeed * Time.deltaTime);
    }
    void Awake()
    {
        m_camera = this.GetComponent<Camera>();
        if (m_camera == null)
        {
            Debug.LogError("In CameraController: m_cameraMinimumSize is NULL");
        }
    }
}
