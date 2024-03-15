using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody rb;
    public float gravity = 9.81f;
    private Vector3 velocity;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        velocity += Vector3.down * gravity * Time.deltaTime;
        rb.velocity = velocity;
    }
}
