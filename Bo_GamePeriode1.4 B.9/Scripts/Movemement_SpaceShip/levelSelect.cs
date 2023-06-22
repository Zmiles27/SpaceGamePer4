using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    bool touchingPlanet1Trigger;
    public TextMeshProUGUI text;
    private void Start()
    {
        text.enabled = false;
        touchingPlanet1Trigger = false;
    }
    private void Update()
    {
       if (touchingPlanet1Trigger == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("level1");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "planet1")
        {
            text.enabled = true;
            touchingPlanet1Trigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "planet1")
        {
            text.enabled = false;
            touchingPlanet1Trigger = false;
        }
    }
}
