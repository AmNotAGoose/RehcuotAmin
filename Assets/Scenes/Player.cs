using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    private Vector2 movement = new Vector2(1, 1);
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputX, 0.0f, inputY);

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        transform.Translate(movement * speed * Time.deltaTime);

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector2.down * 15, ForceMode2D.Impulse);
        }


    }
}
