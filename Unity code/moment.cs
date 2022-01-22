using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    float playerHeight = 2f;
    [Header("Movement")]
    public float moveSpeed = 10f;

    float horizontalMovement;
    float verticalMovement;
    float rbDrag = 6f;
    float distoground = -0.27f;
    bool isgrounded = true;

    Vector3 moveDirection;

    Rigidbody rb;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    

    private void Update()
    {
        MyInput();
        controlDrag();
         
    }

    void MyInput()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

    }

    void controlDrag(){
        rb.drag = rbDrag;

    }

    
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }

    
}