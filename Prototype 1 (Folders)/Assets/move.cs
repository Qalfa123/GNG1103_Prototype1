using UnityEngine;

public class FlyingCarController : MonoBehaviour
{
    public float forwardSpeed = 5f; // Adjust this value to set the speed of forward movement

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        // Calculate the forward movement vector based on the car's current rotation
        Vector3 moveDirection = transform.forward * forwardSpeed * Time.deltaTime;

        // Move the car
        transform.position += moveDirection;
    }
}
