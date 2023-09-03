using UnityEngine;

public class StopFreeFall : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the object
        rb = GetComponent<Rigidbody>();

        // Disable gravity for the Rigidbody
        rb.useGravity = false;
    }
}
