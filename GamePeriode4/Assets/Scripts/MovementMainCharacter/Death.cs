using UnityEngine;

public class Death : MonoBehaviour
{
    public float resetYThreshold = -5f;
    public Vector3 resetPosition = new Vector3(0f, 2f, 0f);

    void Update()
    {
        if (transform.position.y < resetYThreshold)
        {
            transform.position = resetPosition;
        }
    }
}

