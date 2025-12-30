using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput = 0, verticalInput = 0;
    Rigidbody2D rb;
    public float speed = 1000.0f;
    public float jumpForce = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }
        if (Input.GetButtonDown("Jump"))
        {
            // Add an upward force
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }

        rb.MovePosition(rb.transform.position + movement * speed;
    }
}
