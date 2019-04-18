using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForm : MonoBehaviour {

    public GameObject objects;
    public float dropRate = 0.5f;

    private void Start()
    {
        InvokeRepeating("Drop", 0.0f, dropRate);
    }

    void Drop()
    {
        Instantiate(objects, transform.position, Quaternion.identity);
    }

}
