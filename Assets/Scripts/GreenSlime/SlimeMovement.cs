using UnityEngine;

public class SlimeMovement : MonoBehaviour
{

    [SerializeField] private float speed = 1f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckDistance = 0.5f;
    private Rigidbody2D _rigidbody;
    private bool movingRight = true;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        float direction = movingRight ? 1f : -1f;
        _rigidbody.linearVelocityX = direction * speed;

        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckDistance, groundLayer);

        if (hit.collider == null)
        {
            Flip();
        }
    }

    public void Flip()
    {
        movingRight = !movingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
