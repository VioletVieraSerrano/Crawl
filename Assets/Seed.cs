using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    private float counter = 0;
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rain")
        {
            Destroy(other.gameObject);
            counter++;
            if (counter >= 5)
            {
                var myScript = target.GetComponent<MoveToTarget>();
                myScript.triggerToMove();
                Destroy(this.gameObject);

            }
        }

    }
}
