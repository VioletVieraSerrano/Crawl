using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClimbController : MonoBehaviour
{
    public GameObject cacoon;
    public GameObject butterflyMid;
    public GameObject wingLeft;
    public GameObject wingRight;
    public GameObject body1;
    public GameObject body2;
    public GameObject body3;
    public float speed = 2.0f;
    public float timer = 10.0f;
    public float duration = 10.0f;
    public bool climb = true;
    public float shakeSpeed = 1f;
    public Material cacoonMaterial;
    Color currentColor;
    Rigidbody rb;
    Rigidbody cacoonRb;
    Color startColor = Color.clear;
    Color endColor = Color.gray;
    Quaternion rotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cacoonRb = GetComponent<Rigidbody>();
        cacoon.GetComponent<MeshRenderer>().enabled = true;
        body1.GetComponent<MeshRenderer>().enabled = false;
        body2.GetComponent<MeshRenderer>().enabled = false;
        body3.GetComponent<MeshRenderer>().enabled = false;
    }

    void Update()
    {
        if (climb == true)
        {
            ClimbMovement();
        }
        Color currentColor = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time, 1));
        cacoonMaterial.color = currentColor;
    }

    void ClimbMovement()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = Vector3.Lerp(new Vector3(0, verticalInput * speed, 0), Vector3.up, timer);
        timer -= Time.deltaTime * duration;
    }

    public void triggerClimb()
    {
        climb = false;
        rb.velocity = Vector3.zero;
        triggerButterfly();
    }
    public void triggerButterfly()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        cacoon.GetComponent<MeshRenderer>().enabled = false;
        butterflyMid.GetComponent<MeshRenderer>().enabled = true;
        wingLeft.GetComponent<MeshRenderer>().enabled = true;
        wingRight.GetComponent<MeshRenderer>().enabled = true;
    }

}
