using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb; 
    public float moveSpeed; 
    private Vector2 _moveDirection;

    public InputActionReference move;

    // Update is called once per frame
    private void FixedUpdate()
    {
        _moveDirection = move.action.ReadValue<Vector2>();
        rb.velocity = new Vector2(x:_moveDirection.x *moveSpeed, y:_moveDirection.y*moveSpeed);
    }
}
