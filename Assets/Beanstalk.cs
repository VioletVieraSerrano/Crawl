using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beanstalk : MonoBehaviour
{
    public GameObject player;
    public float timer = 10;
    public Vector3 direction;
    public float duration = 5;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<Controller>().enabled = false;
            player.GetComponent<ClimbController>().enabled = true;
            direction = Vector3.Lerp(new Vector3(0, 1, 0), Vector3.zero, timer);
            timer -= Time.deltaTime * duration;
            target.GetComponent<CapsuleCollider>().enabled = true;
        }
    }
}
