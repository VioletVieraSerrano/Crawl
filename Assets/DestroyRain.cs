using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRain : MonoBehaviour
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

    public void OnTriggerEnter(Collider other)
    {
        Destroy(rain01);
        Destroy(rain02);
        Destroy(rain03);
        Destroy(rain04);
        Destroy(rain05);
        Destroy(rain06);
        Destroy(rain07);
        Destroy(rain08);
        Destroy(rain09);
        Destroy(rain10);
        Destroy(rain11);
        Destroy(rain12);
        Destroy(rain13);
        Destroy(rain14);
        Destroy(rain15);
        Destroy(rain16);
        Destroy(rain17);

    }

}
