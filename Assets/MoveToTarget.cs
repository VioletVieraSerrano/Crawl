using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    private GameObject currentTarget;
    public GameObject primaryTarget;
    public GameObject secondaryTarget;
    public GameObject parentTarget;
    public GameObject childTarget;
    public float speed = 0.01f;
    public bool move = false;
    public bool attach = false;

    private void Start()
    {
        currentTarget = primaryTarget;
    }

    void Update()
    {
        if (move == true)
        {
            moveToTarget();
        }
    }
    public void moveToTarget()
    {
        transform.position = Vector3.Lerp(transform.position, currentTarget.transform.position, speed);
        if (Vector3.Distance(transform.position, currentTarget.transform.position) <= 0.1f)
        {
            if (attach == true)
            {
                childTarget.transform.parent = parentTarget.transform;
            }
            if(secondaryTarget != currentTarget)
            {
                speed = (speed * 0.4f);
                currentTarget = secondaryTarget;
            }
            else
            {
                move = false;
            }
        }
    }
    public void triggerToMove()
    {
        move = true;
    }
    public void triggerToStop()
    {
        move = false;
    }
}
