using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBetaScript : MonoBehaviour
{
    private bool betaEnd = false;
    void Update()
    {
        if (betaEnd == true)
        {
            SceneManager.LoadScene("endBeta");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "endBeta")
        {
            betaEnd= true;
        }
    }
}
