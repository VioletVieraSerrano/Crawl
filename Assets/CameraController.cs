using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform followTarget;
    public float distance = 25;
    public float xOffset = 10;
    public float yOffset = 10;
    public float zOffset = 10;
    public float minClampAngle = 0;
    public float maxClampAngle = 45;
    public float speedRoation = 2;
    private float xRotation;
    private float yRotation;
    private float invertX = 1;
    private float invertY = -1;

    void Update()
    {
        xRotation += Input.GetAxis("Mouse Y") * invertY * speedRoation;
        xRotation = Mathf.Clamp(xRotation, minClampAngle, maxClampAngle);
        yRotation += Input.GetAxis("Mouse X") * invertX * speedRoation;

        var targetRot = Quaternion.Euler(xRotation, yRotation, 0);
        var focus = followTarget.position + new Vector3(xOffset, yOffset, zOffset);

        transform.position = focus - targetRot  * new Vector3(0, 0, distance);
        transform.rotation = targetRot;
    }
}
