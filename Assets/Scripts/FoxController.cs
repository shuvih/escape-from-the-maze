using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 velocity;
    private CharacterController characterController;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        animator.SetTrigger("Walk");
        animator.SetTrigger("Sit");
        animator.SetTrigger("Walk");
        animator.SetTrigger("Stay");
        //animator.SetTrigger("Sit");
    }

    void Update()
    {
        move();
    }



    private void move()
    {
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        /*
         * »дЄм играть и ждЄм
         */
        rb.velocity = Vector3.up;
    }
}
