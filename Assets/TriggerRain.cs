using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TriggerRain : MonoBehaviour
{
    public GameObject rain01;
    public GameObject rain02;
    public GameObject rain03;
    public GameObject rain04;
    public GameObject rain05;
    public GameObject rain06;
    public GameObject rain07;
    public GameObject rain08;
    public GameObject rain09;
    public GameObject rain10;
    public GameObject rain11;
    public GameObject rain12;
    public GameObject rain13;
    public GameObject rain14;
    public GameObject rain15;
    public GameObject rain16;
    public GameObject rain17;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var myscript01 = rain01.GetComponent<MoveToTarget>();
            myscript01.triggerToMove();
            var myscript02 = rain02.GetComponent<MoveToTarget>();
            myscript02.triggerToMove();
            var myscript03 = rain03.GetComponent<MoveToTarget>();
            myscript03.triggerToMove();
            var myscript04 = rain02.GetComponent<MoveToTarget>();
            myscript04.triggerToMove();
            var myscript05 = rain05.GetComponent<MoveToTarget>();
            myscript05.triggerToMove();
            var myscript06 = rain06.GetComponent<MoveToTarget>();
            myscript06.triggerToMove();
            var myscript07 = rain07.GetComponent<MoveToTarget>();
            myscript07.triggerToMove();
            var myscript08 = rain08.GetComponent<MoveToTarget>();
            myscript08.triggerToMove();
            var myscript09 = rain09.GetComponent<MoveToTarget>();
            myscript09.triggerToMove();
            var myscript10 = rain10.GetComponent<MoveToTarget>();
            myscript10.triggerToMove();
            var myscript11 = rain11.GetComponent<MoveToTarget>();
            myscript11.triggerToMove();
            var myscript12 = rain12.GetComponent<MoveToTarget>();
            myscript12.triggerToMove();
            var myscript13 = rain01.GetComponent<MoveToTarget>();
            myscript13.triggerToMove();
            var myscript14 = rain14.GetComponent<MoveToTarget>();
            myscript14.triggerToMove();
            var myscript15 = rain15.GetComponent<MoveToTarget>();
            myscript15.triggerToMove();
            var myscript16 = rain16.GetComponent<MoveToTarget>();
            myscript16.triggerToMove();
            var myscript17 = rain17.GetComponent<MoveToTarget>();
            myscript17.triggerToMove();
        }
    }

}
