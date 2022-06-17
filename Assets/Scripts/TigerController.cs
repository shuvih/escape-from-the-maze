using UnityEngine;

public class TigerController : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    private CharacterController characterController;
    private Animator animator;
    private float gravity = -9.81f;
    private Vector3 velocity;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement();
    }

    private void movement()
    {
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (Mathf.Abs(x) + Mathf.Abs(z) == 0)
        {
            animator.SetBool("isWalk", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isWalk", false);
            animator.SetBool("isIdle", true);
        }
        Vector3 movement = transform.right * x + transform.forward * z;
        characterController.Move(movement * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}