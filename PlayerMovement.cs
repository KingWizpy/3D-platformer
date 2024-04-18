using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MovementSpeed = 2;
    [SerializeField] float JumpForce = 4;
    [SerializeField] Transform GroundCheck;
    [SerializeField] LayerMask Ground;
    [SerializeField] AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * MovementSpeed, rb.velocity.y, verticalInput * MovementSpeed);

        if (Input.GetButtonDown("Jump") && IsGround())
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            jumpSound.Play();

        }
    }

    bool IsGround()
    {
        return Physics.CheckSphere(GroundCheck.position, 1f, Ground);
    }
}
