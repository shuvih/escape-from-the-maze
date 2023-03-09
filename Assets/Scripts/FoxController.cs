using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FoxController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 velocity;
    private CharacterController characterController;
    private Animator animator;
    private NavMeshAgent agent;
    private float gravity = -9.81f;
    private float speed = 7f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(new Vector3(155, 30, 189));
        animator.SetTrigger("Walk");
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

        if (agent.remainingDistance < 0.1f)
        {
            animator.SetTrigger("Stay");
        }
        else
        {
            Vector3 movement = transform.right * 0 + transform.forward * 0.3f;
            characterController.Move(movement * speed * Time.deltaTime);
            velocity.y += gravity * Time.deltaTime;
            characterController.Move(velocity * Time.deltaTime);
        }
    }
}
