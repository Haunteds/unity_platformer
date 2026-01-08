using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumpPower = 2f;

    private Rigidbody2D _rigidbody;
    private Vector2 moveInput;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Vector2 capsuleSize = new Vector2(0.5f, 0.2f);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocityX, jumpPower);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = new Vector2(moveInput.x * speed, _rigidbody.linearVelocityY);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCapsule(groundCheck.position,
            capsuleSize,
            CapsuleDirection2D.Horizontal,
            0f,
            groundLayer);
    }

}
