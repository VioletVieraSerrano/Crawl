using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TriggerControllerOff : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var myScript = player.GetComponent<ClimbController>();
            myScript.triggerClimb();
        }
    }
}
