using UnityEngine;

public class PlayerMove : MonoBehaviour, IMoveable
{
    [SerializeField] private float _movementSpeed;

    private Vector2 _moveInput;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 input)
    {
        _moveInput = input;
    }

    private void Update()
    {
        rb.linearVelocity = new Vector3(_moveInput.x * _movementSpeed, rb.linearVelocity.y, _moveInput.y * _movementSpeed);
    }
   
}
