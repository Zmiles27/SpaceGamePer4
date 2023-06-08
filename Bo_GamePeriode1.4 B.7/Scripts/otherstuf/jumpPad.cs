using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    public float jumpHight = 40f;
    public Rigidbody rb;
    bool touchingTrigger = false;

    private void Update()
    {
        if (touchingTrigger == true)
        {
            rb.AddForce(Vector3.up * jumpHight);
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
