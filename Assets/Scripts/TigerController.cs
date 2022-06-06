using UnityEngine;

public class TigerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private CharacterController characterController;
    private Animator animator;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        movement();
    }

    private void movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (Mathf.Abs(moveHorizontal) + Mathf.Abs(moveVertical) == 0)
        {
            animator.SetBool("isWalk", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isWalk", false);
            animator.SetBool("isIdle", true);
        }
        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
        characterController.Move(move * speed * Time.fixedDeltaTime);
    }
}