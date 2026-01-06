using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 500f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = inputX * speed * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.linearVelocityY = 0;
            rb.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector2.down * 15, ForceMode2D.Impulse);
        }
    }
}
