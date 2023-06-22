using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class jumpPad : MonoBehaviour
{
    public float LaunchPower = 10;
    public Rigidbody rb;
    bool touchingTrigger = false;

    private void Update()
    {
        if (touchingTrigger == true)
        {
            rb.AddForce(transform.up * LaunchPower);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bouncePad")
        {
            Debug.Log("test");
            touchingTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "bouncePad")
        {
            Debug.Log("test");
            touchingTrigger = false;
        }
    }
}
