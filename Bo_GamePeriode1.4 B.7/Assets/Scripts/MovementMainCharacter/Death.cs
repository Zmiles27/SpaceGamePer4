using UnityEngine;

public class Death : MonoBehaviour
{
    public float resetYThreshold = -5f;
    public Vector3 resetStart = new Vector3(8, 4, 123);
    public Vector3 resetcp1 = new Vector3(10, 5, -80);

    void Update()
    {
        if (transform.position.y < resetYThreshold)
        {
            if(transform.position.z <= -80)
            {
                transform.position = resetcp1;
            }
            else
            {
                transform.position = resetStart;
            }           
        }
    }
}

