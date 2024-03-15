using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerMove : MonoBehaviour
{
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var myScript = target.GetComponent<MoveToTarget>();
            myScript.triggerToMove();
        }

    }
}
