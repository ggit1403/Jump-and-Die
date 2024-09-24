using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    /*[SerializeField] private float playerSpeed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 playerDirection;
    private bool _isJumped = false;
    private bool _isOnGround = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

        transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isOnGround = true;
            _isJumped = false;

        }
    }*/
    [SerializeField] private float speed = 10;
    [SerializeField] private float jumpForce = 5000;
    /* private bool _isJumping = false;*/
    private bool _isJumped = false;
    private bool _isOnGround = false;
    [SerializeField] private bool moving = true;

    Rigidbody2D rb;
    void Start()
    {
        moving = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (moving)
        {
            Vector3 movement = new Vector3(0f, 0f, verticalInput) * speed * Time.fixedDeltaTime;
            transform.Translate(movement);
            transform.Translate(speed * Time.fixedDeltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (!_isOnGround)
            {
                return;
            }

            if (_isJumped)
            {
                return;
            }

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            _isJumped = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isOnGround = true;
            _isJumped = false;

        }
    }
}
