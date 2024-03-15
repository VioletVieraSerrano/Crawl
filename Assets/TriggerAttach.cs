using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TriggerAttach : MonoBehaviour
{
    public GameObject childTarget;
    public GameObject parentTarget;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            childTarget.transform.parent = parentTarget.transform;
        }

    }

}
