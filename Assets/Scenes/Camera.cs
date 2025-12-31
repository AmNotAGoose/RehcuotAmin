using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Vector3 offset;   // Offset from the player (e.g., (0, 0, -10) for 2D)

    // LateUpdate is called after all Update functions have been called
    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            desiredPosition.z = transform.position.z; // Keep the camera's Z position the same
            transform.position = desiredPosition;
        }
    }
}