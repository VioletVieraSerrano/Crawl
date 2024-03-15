using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowActor : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    public float xOffset = 10;
    public float yOffset = 10;
    public float zOffset = 10;
    private float yRot;

    void Update()
    {

        var targetRot = Quaternion.LookRotation(Vector3.forward);
        var focus = followTarget.position + new Vector3(xOffset, yOffset, zOffset);

        transform.position = focus;
        transform.rotation = targetRot;
    }
}
