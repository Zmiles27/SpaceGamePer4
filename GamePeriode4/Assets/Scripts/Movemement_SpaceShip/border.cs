using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class border : MonoBehaviour
{
    public float borderRadius = 100;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= borderRadius)
        {
            transform.position = new Vector3(borderRadius, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -borderRadius)
        {
            transform.position = new Vector3(-borderRadius, transform.position.y, transform.position.z);
        }
        if (transform.position.y >= borderRadius)
        {
            transform.position = new Vector3(transform.position.x, borderRadius, transform.position.z);
        }
        if (transform.position.y <= -borderRadius)
        {
            transform.position = new Vector3(transform.position.x, -borderRadius, transform.position.z);
        }
        if (transform.position.z >= borderRadius)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, borderRadius);
        }
        if (transform.position.z <= -borderRadius)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -borderRadius);
        }
    }
}
