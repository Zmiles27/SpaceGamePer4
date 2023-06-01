using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    public float sensitivity = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY += Input.GetAxis("Mouse Y") * sensitivity;
        transform.eulerAngles = new Vector3(0, mouseX, mouseY);
    }
}
