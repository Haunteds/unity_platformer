using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public float speed = 2f;

    private Rigidbody2D _rigidbody;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rigidbody.linearVelocity = moveInput * speed;
    }

}
