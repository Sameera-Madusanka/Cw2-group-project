using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header("Ground check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;


    public Transform orientation;

    float horizontalInput;
    float virticalInput;

    Vector3 moveDirection;

    Rigidbody rb;




    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {   //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        // handle drag
        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
        
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput() 
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        virticalInput = Input.GetAxisRaw("Vertical");
    }
    private void MovePlayer() 
    {
        //calculate move direction
        moveDirection = orientation.forward * virticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    } 
     
   
}
