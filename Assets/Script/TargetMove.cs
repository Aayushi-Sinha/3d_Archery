using UnityEngine;

public class PeriodicLinearMovement : MonoBehaviour
{
    public Vector3 direction = Vector3.forward; // Direction in which the object will move
    public float speed = 5.0f; // Speed at which the object will move
    public float distance = 5.0f; // Distance the object will travel before reversing direction

    private Vector3 initialPosition;
    private bool movingForward = true;

    void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position based on the direction, speed, and PingPong movement
        float pingPongValue = Mathf.PingPong(Time.time * speed, distance);
        Vector3 newPosition = initialPosition + direction.normalized * pingPongValue;

        // Update the object's position
        transform.position = newPosition;

        // Check if it's time to reverse direction
        if (pingPongValue >= distance && movingForward)
        {
            movingForward = false;
        }
        else if (pingPongValue <= 0 && !movingForward)
        {
            movingForward = true;
        }

        // Update the direction based on the movement
        direction = movingForward ? direction.normalized : -direction.normalized;
    }
}
