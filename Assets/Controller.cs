using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    [SerializeField] Transform Actor;
    private Vector3 velocity;
    public float maxSpeed = 1.0f;
    public float gravity = 9.81f;
    public float drag = 1.0f;
    public CameraController cam;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void Update()
    {
        MovementManager();
    }

    void MovementManager()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 camForward = cam.transform.forward;
        Vector3 camRight = cam.transform.right;
        camForward.y = 0;
        camRight.y = 0;
        Vector3 relativeForward = verticalInput * camForward;
        Vector3 relativeRight = horizontalInput * camRight;
        Vector3 direction = relativeForward + relativeRight;

        if (velocity.magnitude < maxSpeed)
        {
            velocity += direction;
        }
        if (velocity.magnitude > 0)
        {

            velocity += new Vector3(velocity.normalized.x, 0, velocity.normalized.z) * -drag * Time.deltaTime;
        }
        if (velocity.magnitude < 10 && direction.magnitude < 0.1)
        {
            velocity.x = 0;
            velocity.z = 0;
        }

        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;

        if (Physics.Raycast(transform.position - transform.up * 0.4f, -transform.up, out hit, 0.2f))
        {
            velocity.y = 0;
        }
        else
        {
            velocity += Vector3.down * gravity * Time.deltaTime;
        }
        if (velocity.magnitude > 0)
        {
            rb.rotation = Quaternion.LookRotation(direction);
        }
        rb.velocity = velocity;
    }
}
