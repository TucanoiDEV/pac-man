using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public float baseSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed));

        if ((horizontalInput > 0 || horizontalInput < 0) && (verticalInput > 0 || verticalInput < 0))
        {
            moveSpeed = baseSpeed * 0.66f;
        }
        else
        {
            moveSpeed = baseSpeed;
        }
    }
}
